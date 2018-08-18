// <copyright file="DbTopic.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2018 PlanGrid, Inc. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kabus.Api.Database
{
	public class DbTopic
	{
		[Key]
		public Guid    Uid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<DbTopicTag> TopicTags { get; set; }
	}
}