// <copyright file="KabusDb.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2018 PlanGrid, Inc. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;

namespace Kabus.Api.Database
{
	public class KabusDb : DbContext
	{
		public DbSet<DbTopic> Topics { get; set; }
		public DbSet<DbTopicTag> TopicTags { get; set; }
		public DbSet<DbTag> Tags { get; set; }

		public KabusDb(DbContextOptions options) : base(options)
		{
		}

		public KabusDb()
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			optionsBuilder.UseSqlServer("Data Source=MAINGEAR;Initial Catalog=Kabus;Persist Security Info=True;User ID=kabus;Password=kabus");
		}

	    protected override void OnModelCreating(ModelBuilder modelBuilder)
	    {
	        base.OnModelCreating(modelBuilder);

	        modelBuilder.Entity<DbTopicTag>().HasOne(x => x.Topic).WithMany(x => x.TopicTags).HasForeignKey(x => x.TopicUid);
	        modelBuilder.Entity<DbTopicTag>().HasOne(x => x.Tag).WithMany(x => x.TopicTags).HasForeignKey(x => x.TagUid);
	    }
	}
}