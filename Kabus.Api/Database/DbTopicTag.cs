// <copyright file="DbTopicTag.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2018 PlanGrid, Inc. All rights reserved.
// </copyright>

using System;
using System.ComponentModel.DataAnnotations;

namespace Kabus.Api.Database
{
    public class DbTopicTag
    {
//        [Key]
//        public Guid Uid { get; set; }
        public Guid TopicUid { get; set; }
        public Guid TagUid { get; set; }

        public DbTopic Topic { get; set; }
        public DbTag Tag { get; set; }
    }
}