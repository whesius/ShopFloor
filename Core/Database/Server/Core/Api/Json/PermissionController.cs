// <copyright file="DatabaseController.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Protocol.Json
{
    using System;
    using System.Threading;
    using Allors.Protocol.Json.Api.Security;
    using Allors.Services;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("allors/permission")]
    public class PermissionController : ControllerBase
    {
        public PermissionController(ITransactionService transactionService, IPolicyService policyService)
        {
            this.TransactionService = transactionService;
            this.PolicyService = policyService;
        }

        private ITransactionService TransactionService { get; }

        private IPolicyService PolicyService { get; }

        [HttpPost]
        [Authorize]
        [AllowAnonymous]
        public ActionResult<PermissionResponse> Post([FromBody] PermissionRequest permissionRequest, CancellationToken cancellationToken) =>
            this.PolicyService.SyncPolicy.Execute(
                () =>
                {
                    try
                    {
                        using var transaction = this.TransactionService.Transaction;
                        var api = new Api(transaction, "Default", cancellationToken);
                        return api.Permission(permissionRequest);
                    }
                    catch (Exception e)
                    {
                        throw;
                    }
                });
    }
}
