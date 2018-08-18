// <copyright file="DbTag.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2018 PlanGrid, Inc. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kabus.Api.Database
{
    public class DbTag
    {
        [Key]
        public Guid Uid { get; set; }
        public string Name { get; set; }

        public List<DbTopicTag> TopicTags { get; set; }
    }
}