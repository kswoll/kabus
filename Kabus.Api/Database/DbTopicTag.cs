// <copyright file="DbTopicTag.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2018 PlanGrid, Inc. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations;

namespace Kabus.Api.Database
{
    public class DbTopicTag
    {
        [Key]
        public string Uid { get; set; }
        public string TopicUid { get; set; }
        public string TagUid { get; set; }

        public DbTopic Topic { get; set; }
        public DbTag Tag { get; set; }
    }
}