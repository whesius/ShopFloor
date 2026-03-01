// <copyright file="TestAuthenticationController.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Server
{
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using Allors.Database.Domain;
    using Allors.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;
    using Microsoft.IdentityModel.Tokens;
    using Protocol.Json.Auth;

    public class TestAuthenticationController : Controller
    {
        public TestAuthenticationController(IDatabaseService databaseService, ILogger<TestAuthenticationController> logger, IConfiguration config)
        {
            this.DatabaseService = databaseService;
            this.Logger = logger;
            this.Configuration = config;
        }

        public IDatabaseService DatabaseService { get; }

        public ILogger Logger { get; }

        public IConfiguration Configuration { get; }

        [HttpPost]
        public IActionResult Token([FromBody] AuthenticationTokenRequest request)
        {
            if (this.ModelState.IsValid && !string.IsNullOrWhiteSpace(request.l))
            {
                using var transaction = this.DatabaseService.Database.CreateTransaction();
                var m = transaction.Database.Services.Get<Database.Meta.M>();

                var user = new Users(transaction).FindBy(m.User.NormalizedUserName, Users.Normalize(request.l));

                if (user != null)
                {
                    var token = this.CreateToken(user);
                    var response = new AuthenticationTokenResponse
                    {
                        a = true,
                        u = user.Id.ToString(),
                        t = token,
                    };

                    return this.Ok(response);
                }
            }

            return this.Ok(new { Authenticated = false });
        }

        private string CreateToken(User user)
        {
            var jwtKey = this.Configuration["JwtToken:Key"]
                ?? throw new InvalidOperationException("JwtToken:Key configuration is required");
            var jwtIssuer = this.Configuration["JwtToken:Issuer"] ?? "http://allors.com";
            var jwtAudience = this.Configuration["JwtToken:Audience"] ?? jwtIssuer;
            var jwtExpiration = this.Configuration["JwtToken:Expiration"] ?? "30d";

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                jwtIssuer,
                jwtAudience,
                claims,
                expires: DateTime.Now.Add(ParseExpiration(jwtExpiration)),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private static TimeSpan ParseExpiration(string expiration)
        {
            if (string.IsNullOrWhiteSpace(expiration))
            {
                return TimeSpan.FromDays(30);
            }

            var value = expiration.Trim();

            if (value.EndsWith("d", StringComparison.OrdinalIgnoreCase))
            {
                if (int.TryParse(value[..^1], out var days))
                {
                    return TimeSpan.FromDays(days);
                }
            }
            else if (value.EndsWith("h", StringComparison.OrdinalIgnoreCase))
            {
                if (int.TryParse(value[..^1], out var hours))
                {
                    return TimeSpan.FromHours(hours);
                }
            }
            else if (value.EndsWith("m", StringComparison.OrdinalIgnoreCase))
            {
                if (int.TryParse(value[..^1], out var minutes))
                {
                    return TimeSpan.FromMinutes(minutes);
                }
            }

            return TimeSpan.FromDays(30);
        }
    }
}
