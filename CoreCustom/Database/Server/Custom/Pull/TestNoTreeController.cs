// <copyright file="TestNoTreeController.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Server.Controllers
{
    using System.Threading;
    using Database;
    using Database.Domain;
    using Database.Protocol.Json;
    using Microsoft.AspNetCore.Mvc;
    using Allors.Services;

    public class TestNoTreeController : Controller
    {
        public TestNoTreeController(ITransactionService transactionService)
        {
            this.Transaction = transactionService.Transaction;
            this.TreeCache = this.Transaction.Database.Services.Get<ITreeCache>();
        }

        private ITransaction Transaction { get; }

        public ITreeCache TreeCache { get; }

        [HttpPost]
        public IActionResult Pull(CancellationToken cancellationToken)
        {
            var api = new Api(this.Transaction, "Default", cancellationToken);
            var response = api.CreatePullResponseBuilder();
            response.AddObject("object", api.User);
            var organisations = new Organisations(this.Transaction);
            response.AddCollection("collection", organisations.ObjectType, organisations.Extent().ToArray());
            return this.Ok(response.Build());
        }
    }
}
