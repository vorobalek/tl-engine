using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v0600Account : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    IsClosed = table.Column<bool>(nullable: false),
                    ReferrerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountUsers_AccountUsers_ReferrerId",
                        column: x => x.ReferrerId,
                        principalTable: "AccountUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountSubscriptions",
                columns: table => new
                {
                    FromId = table.Column<Guid>(nullable: false),
                    ToId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Quiet = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountSubscriptions", x => new { x.FromId, x.ToId });
                    table.ForeignKey(
                        name: "FK_AccountSubscriptions_AccountUsers_FromId",
                        column: x => x.FromId,
                        principalTable: "AccountUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountUsersRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountUsersRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AccountUsersRoles_AccountRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AccountRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountUsersRoles_AccountUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AccountUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EngineReports",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    StackTrace = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EngineReports_AccountUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AccountUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "EngineStringVariables",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    AuthorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineStringVariables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EngineStringVariables_AccountUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AccountUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccountRoles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sa" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system" }
                });

            migrationBuilder.InsertData(
                table: "AccountUsers",
                columns: new[] { "Id", "CreationDate", "Description", "IsClosed", "IsDeleted", "ModifiedDate", "PasswordHash", "ReferrerId", "Username" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Супер-пользователь системы TL Engine", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "sa" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Автоматика системы TL Engine", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "system" }
                });

            migrationBuilder.InsertData(
                table: "AccountSubscriptions",
                columns: new[] { "FromId", "ToId", "CreationDate", "IsDeleted", "ModifiedDate", "Quiet" },
                values: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "AccountUsersRoles",
                columns: new[] { "UserId", "RoleId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountRoles_Name",
                table: "AccountRoles",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUsers_ReferrerId",
                table: "AccountUsers",
                column: "ReferrerId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUsers_Username",
                table: "AccountUsers",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUsersRoles_RoleId",
                table: "AccountUsersRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineReports_CreationDate",
                table: "EngineReports",
                column: "CreationDate");

            migrationBuilder.CreateIndex(
                name: "IX_EngineReports_Message",
                table: "EngineReports",
                column: "Message");

            migrationBuilder.CreateIndex(
                name: "IX_EngineReports_ModifiedDate",
                table: "EngineReports",
                column: "ModifiedDate");

            migrationBuilder.CreateIndex(
                name: "IX_EngineReports_UserId",
                table: "EngineReports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineStringVariables_AuthorId",
                table: "EngineStringVariables",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineStringVariables_Name",
                table: "EngineStringVariables",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountSubscriptions");

            migrationBuilder.DropTable(
                name: "AccountUsersRoles");

            migrationBuilder.DropTable(
                name: "EngineReports");

            migrationBuilder.DropTable(
                name: "EngineStringVariables");

            migrationBuilder.DropTable(
                name: "AccountRoles");

            migrationBuilder.DropTable(
                name: "AccountUsers");
        }
    }
}
