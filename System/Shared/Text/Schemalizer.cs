// <copyright file="Pluralizer.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Text
{
    using System;
    using System.Linq;
    using System.Text;

    public static class Schemalizer
    {
        public static string Schemalize(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return name;
            }

            var normalizedString = name.Normalize(NormalizationForm.FormKD);
            var stringBuilder = new StringBuilder(normalizedString.Length);

            foreach (var c in normalizedString.Where(c => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z' or >= '0' and <= '9'))
            {
                stringBuilder.Append(c);
            }

            return stringBuilder.ToString();
        }
    }
}
