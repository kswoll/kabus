// <copyright file="KabusDb.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2018 PlanGrid, Inc. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;

namespace Kabus.Api.Database
{
	public class KabusDb : DbContext
	{
		public DbSet<DbTopic> Topics { get; set; }

		public KabusDb(DbContextOptions options) : base(options)
		{
		}

		public KabusDb()
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			optionsBuilder.UseSqlite("Data Source=kabus.db");
		}
	}
}