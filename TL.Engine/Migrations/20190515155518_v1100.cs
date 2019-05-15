using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v1100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_.Groups",
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
                    table.PrimaryKey("PK__.Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_.Roles",
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
                    table.PrimaryKey("PK__.Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_.Users",
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
                    WebTicket = table.Column<Guid>(nullable: false),
                    LastActivity = table.Column<DateTime>(nullable: false),
                    LastLogon = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__.Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Integrations.TgBots",
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
                    table.PrimaryKey("PK_Integrations.TgBots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Integrations.TgRoles",
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
                    table.PrimaryKey("PK_Integrations.TgRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Linker.Links",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Identifier = table.Column<decimal>(nullable: false),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linker.Links", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_.Reports",
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
                    table.PrimaryKey("PK__.Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK__.Reports__.Users_UserId",
                        column: x => x.UserId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "_.StaticFiles",
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
                    table.PrimaryKey("PK__.StaticFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK__.StaticFiles__.Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__.StaticFiles__.StaticFiles_OriginalId",
                        column: x => x.OriginalId,
                        principalTable: "_.StaticFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "_.StringVariables",
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
                    table.PrimaryKey("PK__.StringVariables", x => x.Id);
                    table.ForeignKey(
                        name: "FK__.StringVariables__.Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_.UsersGroups",
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
                    table.PrimaryKey("PK__.UsersGroups", x => new { x.UserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK__.UsersGroups__.Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "_.Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__.UsersGroups__.Users_UserId",
                        column: x => x.UserId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_.UsersRoles",
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
                    table.PrimaryKey("PK__.UsersRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK__.UsersRoles__.Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "_.Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__.UsersRoles__.Users_UserId",
                        column: x => x.UserId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Account.Subscriptions",
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
                    table.PrimaryKey("PK_Account.Subscriptions", x => new { x.FromId, x.ToId });
                    table.ForeignKey(
                        name: "FK_Account.Subscriptions__.Users_FromId",
                        column: x => x.FromId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Api.Tokens",
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
                    table.PrimaryKey("PK_Api.Tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Api.Tokens__.Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Integrations.TgUsers",
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
                    table.PrimaryKey("PK_Integrations.TgUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Integrations.TgUsers__.Users_UserId",
                        column: x => x.UserId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Api.TokensLogs",
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
                    table.PrimaryKey("PK_Api.TokensLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Api.TokensLogs_Api.Tokens_TokenId",
                        column: x => x.TokenId,
                        principalTable: "Api.Tokens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Api.TokensLogs__.Users_UserId",
                        column: x => x.UserId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Integrations.TgConnections",
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
                    table.PrimaryKey("PK_Integrations.TgConnections", x => new { x.BotId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Integrations.TgConnections_Integrations.TgBots_BotId",
                        column: x => x.BotId,
                        principalTable: "Integrations.TgBots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Integrations.TgConnections_Integrations.TgUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "Integrations.TgUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Integrations.TgUsersRoles",
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
                    table.PrimaryKey("PK_Integrations.TgUsersRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_Integrations.TgUsersRoles_Integrations.TgRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Integrations.TgRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Integrations.TgUsersRoles_Integrations.TgUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "Integrations.TgUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Integrations.TgRoles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(2449), false, new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(2476), "sa" },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(4982), false, new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(4991), "admin" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(5868), false, new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(5875), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(6865), false, new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(6874), "system" }
                });

            migrationBuilder.InsertData(
                table: "_.Groups",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(5947), false, new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(5965), "sa" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(5997), false, new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(5998), "all" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(6007), false, new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(6008), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(6015), false, new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(6016), "system" }
                });

            migrationBuilder.InsertData(
                table: "_.Roles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 5, 15, 15, 55, 18, 10, DateTimeKind.Utc).AddTicks(7146), false, new DateTime(2019, 5, 15, 15, 55, 18, 10, DateTimeKind.Utc).AddTicks(7163), "sa" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 5, 15, 15, 55, 18, 10, DateTimeKind.Utc).AddTicks(7194), false, new DateTime(2019, 5, 15, 15, 55, 18, 10, DateTimeKind.Utc).AddTicks(7195), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 5, 15, 15, 55, 18, 10, DateTimeKind.Utc).AddTicks(7204), false, new DateTime(2019, 5, 15, 15, 55, 18, 10, DateTimeKind.Utc).AddTicks(7206), "system" }
                });

            migrationBuilder.InsertData(
                table: "_.Users",
                columns: new[] { "Id", "CreationDate", "Description", "IsClosed", "IsDeleted", "LastActivity", "LastLogon", "ModifiedDate", "PasswordHash", "Username", "WebTicket" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 5, 15, 15, 55, 17, 999, DateTimeKind.Utc).AddTicks(7448), "Супер-пользователь системы TL Engine", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 15, 15, 55, 17, 999, DateTimeKind.Utc).AddTicks(7469), null, "sa", new Guid("150913db-d129-4b02-b7b3-41e713d72630") },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 5, 15, 15, 55, 17, 999, DateTimeKind.Utc).AddTicks(8558), "Шаблонный пользователь системы TL Engine", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 15, 15, 55, 17, 999, DateTimeKind.Utc).AddTicks(8565), null, "user", new Guid("46a5e34b-60a0-4920-91d5-0c7e9c65d160") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 5, 15, 15, 55, 17, 999, DateTimeKind.Utc).AddTicks(8599), "Автоматика системы TL Engine", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 15, 15, 55, 17, 999, DateTimeKind.Utc).AddTicks(8601), null, "system", new Guid("b03a1e11-5639-4a67-a343-6e118280ddc5") }
                });

            migrationBuilder.InsertData(
                table: "Account.Subscriptions",
                columns: new[] { "FromId", "ToId", "CreationDate", "IsDeleted", "ModifiedDate", "Quiet" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 5, 15, 15, 55, 18, 29, DateTimeKind.Utc).AddTicks(7090), false, new DateTime(2019, 5, 15, 15, 55, 18, 29, DateTimeKind.Utc).AddTicks(7116), false },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 5, 15, 15, 55, 18, 29, DateTimeKind.Utc).AddTicks(9538), false, new DateTime(2019, 5, 15, 15, 55, 18, 29, DateTimeKind.Utc).AddTicks(9545), false }
                });

            migrationBuilder.InsertData(
                table: "_.UsersGroups",
                columns: new[] { "UserId", "GroupId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 5, 15, 15, 55, 18, 7, DateTimeKind.Utc).AddTicks(5425), false, new DateTime(2019, 5, 15, 15, 55, 18, 7, DateTimeKind.Utc).AddTicks(5445) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 5, 15, 15, 55, 18, 7, DateTimeKind.Utc).AddTicks(9718), false, new DateTime(2019, 5, 15, 15, 55, 18, 7, DateTimeKind.Utc).AddTicks(9727) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(838), false, new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(839) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(1717), false, new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(1718) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(4436), false, new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(4442) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(4503), false, new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(4505) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(7091), false, new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(7101) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(7157), false, new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(7159) }
                });

            migrationBuilder.InsertData(
                table: "_.UsersRoles",
                columns: new[] { "UserId", "RoleId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 5, 15, 15, 55, 18, 3, DateTimeKind.Utc).AddTicks(3706), false, new DateTime(2019, 5, 15, 15, 55, 18, 3, DateTimeKind.Utc).AddTicks(3727) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 5, 15, 15, 55, 18, 3, DateTimeKind.Utc).AddTicks(7933), false, new DateTime(2019, 5, 15, 15, 55, 18, 3, DateTimeKind.Utc).AddTicks(7940) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 5, 15, 15, 55, 18, 3, DateTimeKind.Utc).AddTicks(8918), false, new DateTime(2019, 5, 15, 15, 55, 18, 3, DateTimeKind.Utc).AddTicks(8919) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 5, 15, 15, 55, 18, 4, DateTimeKind.Utc).AddTicks(1134), false, new DateTime(2019, 5, 15, 15, 55, 18, 4, DateTimeKind.Utc).AddTicks(1142) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 5, 15, 15, 55, 18, 4, DateTimeKind.Utc).AddTicks(3363), false, new DateTime(2019, 5, 15, 15, 55, 18, 4, DateTimeKind.Utc).AddTicks(3370) }
                });

            migrationBuilder.CreateIndex(
                name: "IX__.Groups_Name",
                table: "_.Groups",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX__.Reports_CreationDate",
                table: "_.Reports",
                column: "CreationDate");

            migrationBuilder.CreateIndex(
                name: "IX__.Reports_Message",
                table: "_.Reports",
                column: "Message");

            migrationBuilder.CreateIndex(
                name: "IX__.Reports_ModifiedDate",
                table: "_.Reports",
                column: "ModifiedDate");

            migrationBuilder.CreateIndex(
                name: "IX__.Reports_UserId",
                table: "_.Reports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX__.Roles_Name",
                table: "_.Roles",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX__.StaticFiles_AuthorId",
                table: "_.StaticFiles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX__.StaticFiles_OriginalId",
                table: "_.StaticFiles",
                column: "OriginalId");

            migrationBuilder.CreateIndex(
                name: "IX__.StringVariables_AuthorId",
                table: "_.StringVariables",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX__.StringVariables_Name",
                table: "_.StringVariables",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX__.Users_Username",
                table: "_.Users",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX__.UsersGroups_GroupId",
                table: "_.UsersGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX__.UsersRoles_RoleId",
                table: "_.UsersRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Api.Tokens_OwnerId",
                table: "Api.Tokens",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Api.TokensLogs_TokenId",
                table: "Api.TokensLogs",
                column: "TokenId");

            migrationBuilder.CreateIndex(
                name: "IX_Api.TokensLogs_UserId",
                table: "Api.TokensLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations.TgBots_Token_TypeName",
                table: "Integrations.TgBots",
                columns: new[] { "Token", "TypeName" },
                unique: true,
                filter: "[Token] IS NOT NULL AND [TypeName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations.TgConnections_UserId",
                table: "Integrations.TgConnections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations.TgRoles_Name",
                table: "Integrations.TgRoles",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations.TgUsers_UserId",
                table: "Integrations.TgUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations.TgUsersRoles_RoleId",
                table: "Integrations.TgUsersRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Linker.Links_Identifier",
                table: "Linker.Links",
                column: "Identifier",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Linker.Links_Url",
                table: "Linker.Links",
                column: "Url",
                unique: true,
                filter: "[Url] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_.Reports");

            migrationBuilder.DropTable(
                name: "_.StaticFiles");

            migrationBuilder.DropTable(
                name: "_.StringVariables");

            migrationBuilder.DropTable(
                name: "_.UsersGroups");

            migrationBuilder.DropTable(
                name: "_.UsersRoles");

            migrationBuilder.DropTable(
                name: "Account.Subscriptions");

            migrationBuilder.DropTable(
                name: "Api.TokensLogs");

            migrationBuilder.DropTable(
                name: "Integrations.TgConnections");

            migrationBuilder.DropTable(
                name: "Integrations.TgUsersRoles");

            migrationBuilder.DropTable(
                name: "Linker.Links");

            migrationBuilder.DropTable(
                name: "_.Groups");

            migrationBuilder.DropTable(
                name: "_.Roles");

            migrationBuilder.DropTable(
                name: "Api.Tokens");

            migrationBuilder.DropTable(
                name: "Integrations.TgBots");

            migrationBuilder.DropTable(
                name: "Integrations.TgRoles");

            migrationBuilder.DropTable(
                name: "Integrations.TgUsers");

            migrationBuilder.DropTable(
                name: "_.Users");
        }
    }
}
