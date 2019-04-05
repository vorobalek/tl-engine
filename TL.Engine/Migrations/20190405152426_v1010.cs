using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v1010 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_Groups",
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
                    table.PrimaryKey("PK__Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_Roles",
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
                    table.PrimaryKey("PK__Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    IsClosed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Integrations_TgBots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Token = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    NativeName = table.Column<string>(nullable: true),
                    TypeName = table.Column<string>(nullable: true),
                    SkipUpdates = table.Column<bool>(nullable: false),
                    AutoStart = table.Column<bool>(nullable: false),
                    IsRelevant = table.Column<bool>(nullable: false),
                    LastStartDate = table.Column<DateTime>(nullable: true),
                    State = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integrations_TgBots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Integrations_TgRoles",
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
                    table.PrimaryKey("PK_Integrations_TgRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_Reports",
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
                    table.PrimaryKey("PK__Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Reports__Users_UserId",
                        column: x => x.UserId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "_StringVariables",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    AuthorId = table.Column<Guid>(nullable: false, defaultValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StringVariables", x => x.Id);
                    table.ForeignKey(
                        name: "FK__StringVariables__Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_UsersGroups",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UsersGroups", x => new { x.UserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK__UsersGroups__Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "_Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__UsersGroups__Users_UserId",
                        column: x => x.UserId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_UsersRoles",
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
                    table.PrimaryKey("PK__UsersRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK__UsersRoles__Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "_Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__UsersRoles__Users_UserId",
                        column: x => x.UserId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Account_Subscriptions",
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
                    table.PrimaryKey("PK_Account_Subscriptions", x => new { x.FromId, x.ToId });
                    table.ForeignKey(
                        name: "FK_Account_Subscriptions__Users_FromId",
                        column: x => x.FromId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Api_Tokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Api_Tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Api_Tokens__Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Integrations_TgUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    TgId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integrations_TgUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Integrations_TgUsers__Users_UserId",
                        column: x => x.UserId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Integrations_TgConnections",
                columns: table => new
                {
                    BotId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integrations_TgConnections", x => new { x.BotId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Integrations_TgConnections_Integrations_TgBots_BotId",
                        column: x => x.BotId,
                        principalTable: "Integrations_TgBots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Integrations_TgConnections_Integrations_TgUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "Integrations_TgUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Integrations_TgUsersRoles",
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
                    table.PrimaryKey("PK_Integrations_TgUsersRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_Integrations_TgUsersRoles_Integrations_TgRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Integrations_TgRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Integrations_TgUsersRoles_Integrations_TgUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "Integrations_TgUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Integrations_TgRoles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 4, 5, 15, 24, 24, 885, DateTimeKind.Utc).AddTicks(4781), false, new DateTime(2019, 4, 5, 15, 24, 24, 885, DateTimeKind.Utc).AddTicks(4805), "sa" },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new DateTime(2019, 4, 5, 15, 24, 24, 885, DateTimeKind.Utc).AddTicks(7298), false, new DateTime(2019, 4, 5, 15, 24, 24, 885, DateTimeKind.Utc).AddTicks(7307), "admin" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 15, 24, 24, 885, DateTimeKind.Utc).AddTicks(8283), false, new DateTime(2019, 4, 5, 15, 24, 24, 885, DateTimeKind.Utc).AddTicks(8290), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 15, 24, 24, 885, DateTimeKind.Utc).AddTicks(9120), false, new DateTime(2019, 4, 5, 15, 24, 24, 885, DateTimeKind.Utc).AddTicks(9127), "system" }
                });

            migrationBuilder.InsertData(
                table: "_Groups",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 4, 5, 15, 24, 24, 846, DateTimeKind.Utc).AddTicks(7585), false, new DateTime(2019, 4, 5, 15, 24, 24, 846, DateTimeKind.Utc).AddTicks(7601), "sa" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 4, 5, 15, 24, 24, 846, DateTimeKind.Utc).AddTicks(7627), false, new DateTime(2019, 4, 5, 15, 24, 24, 846, DateTimeKind.Utc).AddTicks(7628), "all" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 15, 24, 24, 846, DateTimeKind.Utc).AddTicks(7636), false, new DateTime(2019, 4, 5, 15, 24, 24, 846, DateTimeKind.Utc).AddTicks(7638), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 15, 24, 24, 846, DateTimeKind.Utc).AddTicks(7644), false, new DateTime(2019, 4, 5, 15, 24, 24, 846, DateTimeKind.Utc).AddTicks(7645), "system" }
                });

            migrationBuilder.InsertData(
                table: "_Roles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 4, 5, 15, 24, 24, 844, DateTimeKind.Utc).AddTicks(9505), false, new DateTime(2019, 4, 5, 15, 24, 24, 844, DateTimeKind.Utc).AddTicks(9527), "sa" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 15, 24, 24, 844, DateTimeKind.Utc).AddTicks(9573), false, new DateTime(2019, 4, 5, 15, 24, 24, 844, DateTimeKind.Utc).AddTicks(9576), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 15, 24, 24, 844, DateTimeKind.Utc).AddTicks(9590), false, new DateTime(2019, 4, 5, 15, 24, 24, 844, DateTimeKind.Utc).AddTicks(9593), "system" }
                });

            migrationBuilder.InsertData(
                table: "_Users",
                columns: new[] { "Id", "CreationDate", "Description", "IsClosed", "IsDeleted", "ModifiedDate", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 4, 5, 15, 24, 24, 833, DateTimeKind.Utc).AddTicks(5619), "Супер-пользователь системы TL Engine", false, false, new DateTime(2019, 4, 5, 15, 24, 24, 833, DateTimeKind.Utc).AddTicks(5642), null, "sa" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 15, 24, 24, 833, DateTimeKind.Utc).AddTicks(8234), "Шаблонный пользователь системы TL Engine", true, false, new DateTime(2019, 4, 5, 15, 24, 24, 833, DateTimeKind.Utc).AddTicks(8252), null, "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 15, 24, 24, 833, DateTimeKind.Utc).AddTicks(8291), "Автоматика системы TL Engine", true, false, new DateTime(2019, 4, 5, 15, 24, 24, 833, DateTimeKind.Utc).AddTicks(8294), null, "system" }
                });

            migrationBuilder.InsertData(
                table: "Account_Subscriptions",
                columns: new[] { "FromId", "ToId", "CreationDate", "IsDeleted", "ModifiedDate", "Quiet" },
                values: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 15, 24, 24, 813, DateTimeKind.Utc).AddTicks(6993), false, new DateTime(2019, 4, 5, 15, 24, 24, 814, DateTimeKind.Utc).AddTicks(8108), false });

            migrationBuilder.InsertData(
                table: "_UsersGroups",
                columns: new[] { "UserId", "GroupId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 4, 5, 15, 24, 24, 842, DateTimeKind.Utc).AddTicks(966), false, new DateTime(2019, 4, 5, 15, 24, 24, 842, DateTimeKind.Utc).AddTicks(982) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 4, 5, 15, 24, 24, 842, DateTimeKind.Utc).AddTicks(4771), false, new DateTime(2019, 4, 5, 15, 24, 24, 842, DateTimeKind.Utc).AddTicks(4778) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 15, 24, 24, 842, DateTimeKind.Utc).AddTicks(5706), false, new DateTime(2019, 4, 5, 15, 24, 24, 842, DateTimeKind.Utc).AddTicks(5708) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 15, 24, 24, 842, DateTimeKind.Utc).AddTicks(6560), false, new DateTime(2019, 4, 5, 15, 24, 24, 842, DateTimeKind.Utc).AddTicks(6562) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 4, 5, 15, 24, 24, 842, DateTimeKind.Utc).AddTicks(9222), false, new DateTime(2019, 4, 5, 15, 24, 24, 842, DateTimeKind.Utc).AddTicks(9229) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 15, 24, 24, 842, DateTimeKind.Utc).AddTicks(9278), false, new DateTime(2019, 4, 5, 15, 24, 24, 842, DateTimeKind.Utc).AddTicks(9280) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 4, 5, 15, 24, 24, 843, DateTimeKind.Utc).AddTicks(1442), false, new DateTime(2019, 4, 5, 15, 24, 24, 843, DateTimeKind.Utc).AddTicks(1449) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 15, 24, 24, 843, DateTimeKind.Utc).AddTicks(1479), false, new DateTime(2019, 4, 5, 15, 24, 24, 843, DateTimeKind.Utc).AddTicks(1481) }
                });

            migrationBuilder.InsertData(
                table: "_UsersRoles",
                columns: new[] { "UserId", "RoleId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 4, 5, 15, 24, 24, 838, DateTimeKind.Utc).AddTicks(5147), false, new DateTime(2019, 4, 5, 15, 24, 24, 838, DateTimeKind.Utc).AddTicks(5173) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 15, 24, 24, 838, DateTimeKind.Utc).AddTicks(9272), false, new DateTime(2019, 4, 5, 15, 24, 24, 838, DateTimeKind.Utc).AddTicks(9279) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 15, 24, 24, 839, DateTimeKind.Utc).AddTicks(303), false, new DateTime(2019, 4, 5, 15, 24, 24, 839, DateTimeKind.Utc).AddTicks(305) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 15, 24, 24, 839, DateTimeKind.Utc).AddTicks(2293), false, new DateTime(2019, 4, 5, 15, 24, 24, 839, DateTimeKind.Utc).AddTicks(2301) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 15, 24, 24, 839, DateTimeKind.Utc).AddTicks(3915), false, new DateTime(2019, 4, 5, 15, 24, 24, 839, DateTimeKind.Utc).AddTicks(3923) }
                });

            migrationBuilder.CreateIndex(
                name: "IX__Groups_Name",
                table: "_Groups",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX__Reports_CreationDate",
                table: "_Reports",
                column: "CreationDate");

            migrationBuilder.CreateIndex(
                name: "IX__Reports_Message",
                table: "_Reports",
                column: "Message");

            migrationBuilder.CreateIndex(
                name: "IX__Reports_ModifiedDate",
                table: "_Reports",
                column: "ModifiedDate");

            migrationBuilder.CreateIndex(
                name: "IX__Reports_UserId",
                table: "_Reports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX__Roles_Name",
                table: "_Roles",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX__StringVariables_AuthorId",
                table: "_StringVariables",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX__StringVariables_Name",
                table: "_StringVariables",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX__Users_Username",
                table: "_Users",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX__UsersGroups_GroupId",
                table: "_UsersGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX__UsersRoles_RoleId",
                table: "_UsersRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Api_Tokens_OwnerId",
                table: "Api_Tokens",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations_TgBots_Token_TypeName",
                table: "Integrations_TgBots",
                columns: new[] { "Token", "TypeName" },
                unique: true,
                filter: "[Token] IS NOT NULL AND [TypeName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations_TgConnections_UserId",
                table: "Integrations_TgConnections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations_TgRoles_Name",
                table: "Integrations_TgRoles",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations_TgUsers_UserId",
                table: "Integrations_TgUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations_TgUsersRoles_RoleId",
                table: "Integrations_TgUsersRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_Reports");

            migrationBuilder.DropTable(
                name: "_StringVariables");

            migrationBuilder.DropTable(
                name: "_UsersGroups");

            migrationBuilder.DropTable(
                name: "_UsersRoles");

            migrationBuilder.DropTable(
                name: "Account_Subscriptions");

            migrationBuilder.DropTable(
                name: "Api_Tokens");

            migrationBuilder.DropTable(
                name: "Integrations_TgConnections");

            migrationBuilder.DropTable(
                name: "Integrations_TgUsersRoles");

            migrationBuilder.DropTable(
                name: "_Groups");

            migrationBuilder.DropTable(
                name: "_Roles");

            migrationBuilder.DropTable(
                name: "Integrations_TgBots");

            migrationBuilder.DropTable(
                name: "Integrations_TgRoles");

            migrationBuilder.DropTable(
                name: "Integrations_TgUsers");

            migrationBuilder.DropTable(
                name: "_Users");
        }
    }
}
