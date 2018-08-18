// <copyright file="DbEntity.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2018 PlanGrid, Inc. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;

namespace Kabus.Api.Database
{
    public class DbEntity
    {
        [Key]
        public Guid Uid { get; set; }
        public string Name { get; set; }
    }
}