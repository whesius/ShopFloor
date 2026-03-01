// <copyright file="DatabaseController.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Protocol.Json
{
    using System;
    using System.Threading;
    using Allors.Protocol.Json.Api.Invoke;
    using Allors.Services;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("allors/invoke")]
    public class InvokeController : ControllerBase
    {
        public InvokeController(ITransactionService transactionService, IPolicyService policyService)
        {
            this.TransactionService = transactionService;
            this.PolicyService = policyService;
        }

        private ITransactionService TransactionService { get; }

        private IPolicyService PolicyService { get; }

        [HttpPost]
        [Authorize]
        [AllowAnonymous]
        public ActionResult<InvokeResponse> Post(InvokeRequest invokeRequest, CancellationToken cancellationToken) =>
            this.PolicyService.InvokePolicy.Execute(
                () =>
                    {
                        try
                        {
                            using var transaction = this.TransactionService.Transaction;
                            var api = new Api(transaction, "Default", cancellationToken);
                            return api.Invoke(invokeRequest);
                        }
                        catch (Exception e)
                        {
                            throw;
                        }
                    });
    }
}
