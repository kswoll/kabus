// <copyright file="DbTeam.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2018 PlanGrid, Inc. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace Kabus.Api.Database
{
    public class DbTeam : DbEntity
    {
        public List<DbTeamUser> TeamUsers { get; set; }
    }
}