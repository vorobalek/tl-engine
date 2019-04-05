using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v1014 : Migration
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
                name: "IntegrationsTgBots",
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
                    table.PrimaryKey("PK_IntegrationsTgBots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntegrationsTgRoles",
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
                    table.PrimaryKey("PK_IntegrationsTgRoles", x => x.Id);
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
                name: "_StaticFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    OriginalId = table.Column<Guid>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    LocalPath = table.Column<string>(nullable: true),
                    AuthorId = table.Column<Guid>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StaticFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK__StaticFiles__Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__StaticFiles__StaticFiles_OriginalId",
                        column: x => x.OriginalId,
                        principalTable: "_StaticFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_AccountSubscriptions__Users_FromId",
                        column: x => x.FromId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApiTokens",
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
                    table.PrimaryKey("PK_ApiTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApiTokens__Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IntegrationsTgUsers",
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
                    table.PrimaryKey("PK_IntegrationsTgUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IntegrationsTgUsers__Users_UserId",
                        column: x => x.UserId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApiTokensLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    TokenId = table.Column<Guid>(nullable: false),
                    Method = table.Column<string>(nullable: true),
                    Parameters = table.Column<string>(nullable: true),
                    StatusCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiTokensLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApiTokensLogs_ApiTokens_TokenId",
                        column: x => x.TokenId,
                        principalTable: "ApiTokens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApiTokensLogs__Users_UserId",
                        column: x => x.UserId,
                        principalTable: "_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IntegrationsTgConnections",
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
                    table.PrimaryKey("PK_IntegrationsTgConnections", x => new { x.BotId, x.UserId });
                    table.ForeignKey(
                        name: "FK_IntegrationsTgConnections_IntegrationsTgBots_BotId",
                        column: x => x.BotId,
                        principalTable: "IntegrationsTgBots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IntegrationsTgConnections_IntegrationsTgUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "IntegrationsTgUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IntegrationsTgUsersRoles",
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
                    table.PrimaryKey("PK_IntegrationsTgUsersRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_IntegrationsTgUsersRoles_IntegrationsTgRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "IntegrationsTgRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IntegrationsTgUsersRoles_IntegrationsTgUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "IntegrationsTgUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IntegrationsTgRoles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 4, 5, 23, 1, 2, 926, DateTimeKind.Utc).AddTicks(6061), false, new DateTime(2019, 4, 5, 23, 1, 2, 926, DateTimeKind.Utc).AddTicks(6080), "sa" },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new DateTime(2019, 4, 5, 23, 1, 2, 926, DateTimeKind.Utc).AddTicks(8570), false, new DateTime(2019, 4, 5, 23, 1, 2, 926, DateTimeKind.Utc).AddTicks(8579), "admin" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 23, 1, 2, 926, DateTimeKind.Utc).AddTicks(9450), false, new DateTime(2019, 4, 5, 23, 1, 2, 926, DateTimeKind.Utc).AddTicks(9458), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 23, 1, 2, 927, DateTimeKind.Utc).AddTicks(272), false, new DateTime(2019, 4, 5, 23, 1, 2, 927, DateTimeKind.Utc).AddTicks(279), "system" }
                });

            migrationBuilder.InsertData(
                table: "_Groups",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9609), false, new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9617), "sa" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9636), false, new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9637), "all" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9645), false, new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9646), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9653), false, new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9655), "system" }
                });

            migrationBuilder.InsertData(
                table: "_Roles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 4, 5, 23, 1, 2, 889, DateTimeKind.Utc).AddTicks(4313), false, new DateTime(2019, 4, 5, 23, 1, 2, 889, DateTimeKind.Utc).AddTicks(4321), "sa" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 23, 1, 2, 889, DateTimeKind.Utc).AddTicks(4342), false, new DateTime(2019, 4, 5, 23, 1, 2, 889, DateTimeKind.Utc).AddTicks(4344), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 23, 1, 2, 889, DateTimeKind.Utc).AddTicks(4352), false, new DateTime(2019, 4, 5, 23, 1, 2, 889, DateTimeKind.Utc).AddTicks(4353), "system" }
                });

            migrationBuilder.InsertData(
                table: "_Users",
                columns: new[] { "Id", "CreationDate", "Description", "IsClosed", "IsDeleted", "ModifiedDate", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 4, 5, 23, 1, 2, 880, DateTimeKind.Utc).AddTicks(2268), "Супер-пользователь системы TL Engine", false, false, new DateTime(2019, 4, 5, 23, 1, 2, 880, DateTimeKind.Utc).AddTicks(2292), null, "sa" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 23, 1, 2, 880, DateTimeKind.Utc).AddTicks(2330), "Шаблонный пользователь системы TL Engine", true, false, new DateTime(2019, 4, 5, 23, 1, 2, 880, DateTimeKind.Utc).AddTicks(2331), null, "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 23, 1, 2, 880, DateTimeKind.Utc).AddTicks(2340), "Автоматика системы TL Engine", true, false, new DateTime(2019, 4, 5, 23, 1, 2, 880, DateTimeKind.Utc).AddTicks(2342), null, "system" }
                });

            migrationBuilder.InsertData(
                table: "AccountSubscriptions",
                columns: new[] { "FromId", "ToId", "CreationDate", "IsDeleted", "ModifiedDate", "Quiet" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 23, 1, 2, 849, DateTimeKind.Utc).AddTicks(3180), false, new DateTime(2019, 4, 5, 23, 1, 2, 850, DateTimeKind.Utc).AddTicks(3770), false },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 23, 1, 2, 851, DateTimeKind.Utc).AddTicks(6032), false, new DateTime(2019, 4, 5, 23, 1, 2, 851, DateTimeKind.Utc).AddTicks(6040), false }
                });

            migrationBuilder.InsertData(
                table: "_UsersGroups",
                columns: new[] { "UserId", "GroupId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 4, 5, 23, 1, 2, 886, DateTimeKind.Utc).AddTicks(6674), false, new DateTime(2019, 4, 5, 23, 1, 2, 886, DateTimeKind.Utc).AddTicks(6686) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(590), false, new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(597) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(1587), false, new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(1589) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(2442), false, new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(2443) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(5086), false, new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(5095) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(5184), false, new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(5185) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(7392), false, new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(7399) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(7432), false, new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(7433) }
                });

            migrationBuilder.InsertData(
                table: "_UsersRoles",
                columns: new[] { "UserId", "RoleId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 4, 5, 23, 1, 2, 882, DateTimeKind.Utc).AddTicks(7765), false, new DateTime(2019, 4, 5, 23, 1, 2, 882, DateTimeKind.Utc).AddTicks(7785) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(3914), false, new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(3923) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(5030), false, new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(5032) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(7350), false, new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(7357) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(9000), false, new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(9008) }
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
                name: "IX__StaticFiles_AuthorId",
                table: "_StaticFiles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX__StaticFiles_OriginalId",
                table: "_StaticFiles",
                column: "OriginalId");

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
                name: "IX_ApiTokens_OwnerId",
                table: "ApiTokens",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ApiTokensLogs_TokenId",
                table: "ApiTokensLogs",
                column: "TokenId");

            migrationBuilder.CreateIndex(
                name: "IX_ApiTokensLogs_UserId",
                table: "ApiTokensLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IntegrationsTgBots_Token_TypeName",
                table: "IntegrationsTgBots",
                columns: new[] { "Token", "TypeName" },
                unique: true,
                filter: "[Token] IS NOT NULL AND [TypeName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IntegrationsTgConnections_UserId",
                table: "IntegrationsTgConnections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IntegrationsTgRoles_Name",
                table: "IntegrationsTgRoles",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IntegrationsTgUsers_UserId",
                table: "IntegrationsTgUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IntegrationsTgUsersRoles_RoleId",
                table: "IntegrationsTgUsersRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_Reports");

            migrationBuilder.DropTable(
                name: "_StaticFiles");

            migrationBuilder.DropTable(
                name: "_StringVariables");

            migrationBuilder.DropTable(
                name: "_UsersGroups");

            migrationBuilder.DropTable(
                name: "_UsersRoles");

            migrationBuilder.DropTable(
                name: "AccountSubscriptions");

            migrationBuilder.DropTable(
                name: "ApiTokensLogs");

            migrationBuilder.DropTable(
                name: "IntegrationsTgConnections");

            migrationBuilder.DropTable(
                name: "IntegrationsTgUsersRoles");

            migrationBuilder.DropTable(
                name: "_Groups");

            migrationBuilder.DropTable(
                name: "_Roles");

            migrationBuilder.DropTable(
                name: "ApiTokens");

            migrationBuilder.DropTable(
                name: "IntegrationsTgBots");

            migrationBuilder.DropTable(
                name: "IntegrationsTgRoles");

            migrationBuilder.DropTable(
                name: "IntegrationsTgUsers");

            migrationBuilder.DropTable(
                name: "_Users");
        }
    }
}
