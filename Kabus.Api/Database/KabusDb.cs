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
        public DbSet<DbUser> Users { get; set; }
        public DbSet<DbTeam> Teams { get; set; }
        public DbSet<DbEntity> Entities { get; set; }
        public DbSet<DbTeamUser> TeamUsers { get; set; }

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

	        modelBuilder.Entity<DbTopicTag>().HasKey(x => new { x.TopicUid, x.TagUid });
	        modelBuilder.Entity<DbTopicTag>().HasOne(x => x.Topic).WithMany(x => x.TopicTags).HasForeignKey(x => x.TopicUid);
	        modelBuilder.Entity<DbTopicTag>().HasOne(x => x.Tag).WithMany(x => x.TopicTags).HasForeignKey(x => x.TagUid);

	        modelBuilder.Entity<DbTeamUser>().HasKey(x => new { x.TeamUid, x.UserUid });
	        modelBuilder.Entity<DbTeamUser>().HasOne(x => x.Team).WithMany(x => x.TeamUsers).HasForeignKey(x => x.TeamUid);
	        modelBuilder.Entity<DbTeamUser>().HasOne(x => x.User).WithMany(x => x.TeamUsers).HasForeignKey(x => x.UserUid);
	    }
	}
}