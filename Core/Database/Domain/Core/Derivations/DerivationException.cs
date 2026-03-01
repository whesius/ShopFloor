// <copyright file="DerivationException.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Domain.Derivations
{
    using System;
    using System.Globalization;
    using System.Text;
    using Database.Derivations;

    public class DerivationException : Exception
    {
        public DerivationException(IValidation validation)
        {
            this.Validation = validation;
            this.Errors = validation.Errors;
        }


        public IValidation Validation { get; private set; }

        public IDerivationError[] Errors { get; set; }

        public override string Message
        {
            get
            {
                var message = new StringBuilder();
                message.Append(CultureInfo.InvariantCulture, $"{this.Errors.Length} derivation error(s):\n");
                foreach (var error in this.Errors)
                {
                    message.Append(CultureInfo.InvariantCulture, $" - {error.Message}\n");
                }

                return message.ToString();
            }
        }
    }
}
