// <copyright file="DbTeamUser.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2018 PlanGrid, Inc. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace Kabus.Api.Database
{
    public class DbTeamUser
    {
        public Guid TeamUid { get; set; }
        public Guid UserUid { get; set; }

        public DbTeam Team { get; set; }
        public DbUser User { get; set; }
    }
}