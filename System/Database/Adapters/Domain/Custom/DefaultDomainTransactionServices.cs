// <copyright file="DefaultDomainTransactionServices.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>Defines the Default type.</summary>
//------------------------------------------------------------------------------------------------

namespace Allors.Database
{
    using System;

    public class DefaultDomainTransactionServices : IDomainTransactionServices
    {
        public void OnInit(ITransaction transaction) { }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public T Get<T>() => default;
    }
}
