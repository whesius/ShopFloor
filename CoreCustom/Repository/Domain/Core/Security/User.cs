// <copyright file="User.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>Defines the Extent type.</summary>

namespace Allors.Repository
{
    using Attributes;
    using static Workspaces;


    #region Allors
    [Id("a0309c3b-6f80-4777-983e-6e69800df5be")]
    #endregion
    public partial interface User : UniquelyIdentifiable, SecurityTokenOwner, Deletable
    {
        #region Allors
        [Id("5e8ab257-1a1c-4448-aacc-71dbaaba525b")]
        #endregion
        [Size(256)]
        [Workspace(Default)]
        string UserName { get; set; }

        #region Allors
        [Id("7397B596-D8FA-4E3C-8E0E-EA24790FE2E4")]
        #endregion
        [Size(256)]
        [Derived]
        string NormalizedUserName { get; set; }
    }
}
