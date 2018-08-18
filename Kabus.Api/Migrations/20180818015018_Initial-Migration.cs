using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kabus.Api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Uid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Uid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Uid = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "TeamUsers",
                columns: table => new
                {
                    TeamUid = table.Column<Guid>(nullable: false),
                    UserUid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamUsers", x => new { x.TeamUid, x.UserUid });
                    table.ForeignKey(
                        name: "FK_TeamUsers_Entities_TeamUid",
                        column: x => x.TeamUid,
                        principalTable: "Entities",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamUsers_Entities_UserUid",
                        column: x => x.UserUid,
                        principalTable: "Entities",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TopicTags",
                columns: table => new
                {
                    TopicUid = table.Column<Guid>(nullable: false),
                    TagUid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicTags", x => new { x.TopicUid, x.TagUid });
                    table.ForeignKey(
                        name: "FK_TopicTags_Tags_TagUid",
                        column: x => x.TagUid,
                        principalTable: "Tags",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicTags_Topics_TopicUid",
                        column: x => x.TopicUid,
                        principalTable: "Topics",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamUsers_UserUid",
                table: "TeamUsers",
                column: "UserUid");

            migrationBuilder.CreateIndex(
                name: "IX_TopicTags_TagUid",
                table: "TopicTags",
                column: "TagUid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamUsers");

            migrationBuilder.DropTable(
                name: "TopicTags");

            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
