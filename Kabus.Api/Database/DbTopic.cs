﻿// <copyright file="DbTopic.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2018 PlanGrid, Inc. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kabus.Api.Database
{
	public class DbTopic
	{
		[Key]
		public string Uid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<DbTopicTag> TopicTags { get; set; }
	}
}