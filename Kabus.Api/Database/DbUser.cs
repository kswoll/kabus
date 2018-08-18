// <copyright file="DbUser.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2018 PlanGrid, Inc. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace Kabus.Api.Database
{
    public class DbUser : DbEntity
    {
        public string Email { get; set; }

        public List<DbTeamUser> TeamUsers { get; set; }
    }
}