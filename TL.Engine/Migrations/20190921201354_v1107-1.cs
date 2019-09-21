using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v11071 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "core.groups",
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
                    table.PrimaryKey("PK_core.groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "core.permissions",
                columns: table => new
                {
                    SubjectId = table.Column<byte[]>(nullable: false),
                    ObjectId = table.Column<byte[]>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_core.permissions", x => new { x.SubjectId, x.ObjectId });
                });

            migrationBuilder.CreateTable(
                name: "core.roles",
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
                    table.PrimaryKey("PK_core.roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "core.users",
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
                    table.PrimaryKey("PK_core.users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "integrations.tg.bots",
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
                    table.PrimaryKey("PK_integrations.tg.bots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "integrations.tg.roles",
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
                    table.PrimaryKey("PK_integrations.tg.roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "justbot.person",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_justbot.person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "linker.links",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Identifier = table.Column<decimal>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    LifetimeSeconds = table.Column<int>(nullable: false, defaultValue: 2147483647)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_linker.links", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "account.subscriptions",
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
                    table.PrimaryKey("PK_account.subscriptions", x => new { x.FromId, x.ToId });
                    table.ForeignKey(
                        name: "FK_account.subscriptions_core.users_FromId",
                        column: x => x.FromId,
                        principalTable: "core.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "api.tokens",
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
                    table.PrimaryKey("PK_api.tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_api.tokens_core.users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "core.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "core.reports",
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
                    table.PrimaryKey("PK_core.reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_core.reports_core.users_UserId",
                        column: x => x.UserId,
                        principalTable: "core.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "core.static.files",
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
                    table.PrimaryKey("PK_core.static.files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_core.static.files_core.users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "core.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_core.static.files_core.static.files_OriginalId",
                        column: x => x.OriginalId,
                        principalTable: "core.static.files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "core.string.variables",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    AuthorId = table.Column<Guid>(nullable: false, defaultValue: new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_core.string.variables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_core.string.variables_core.users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "core.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "core.users.groups",
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
                    table.PrimaryKey("PK_core.users.groups", x => new { x.UserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_core.users.groups_core.groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "core.groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_core.users.groups_core.users_UserId",
                        column: x => x.UserId,
                        principalTable: "core.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "core.users.roles",
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
                    table.PrimaryKey("PK_core.users.roles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_core.users.roles_core.roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "core.roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_core.users.roles_core.users_UserId",
                        column: x => x.UserId,
                        principalTable: "core.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "integrations.tg.users",
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
                    table.PrimaryKey("PK_integrations.tg.users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_integrations.tg.users_core.users_UserId",
                        column: x => x.UserId,
                        principalTable: "core.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "registry.folders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ParantId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registry.folders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_registry.folders_core.users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "core.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_registry.folders_registry.folders_ParantId",
                        column: x => x.ParantId,
                        principalTable: "registry.folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "justbot.history",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    AuthorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_justbot.history", x => x.Id);
                    table.ForeignKey(
                        name: "FK_justbot.history_justbot.person_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "justbot.person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "api.tokens.logs",
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
                    table.PrimaryKey("PK_api.tokens.logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_api.tokens.logs_api.tokens_TokenId",
                        column: x => x.TokenId,
                        principalTable: "api.tokens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_api.tokens.logs_core.users_UserId",
                        column: x => x.UserId,
                        principalTable: "core.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "integrations.tg.connections",
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
                    table.PrimaryKey("PK_integrations.tg.connections", x => new { x.BotId, x.UserId });
                    table.ForeignKey(
                        name: "FK_integrations.tg.connections_integrations.tg.bots_BotId",
                        column: x => x.BotId,
                        principalTable: "integrations.tg.bots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_integrations.tg.connections_integrations.tg.users_UserId",
                        column: x => x.UserId,
                        principalTable: "integrations.tg.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "integrations.tg.users.roles",
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
                    table.PrimaryKey("PK_integrations.tg.users.roles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_integrations.tg.users.roles_integrations.tg.roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "integrations.tg.roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_integrations.tg.users.roles_integrations.tg.users_UserId",
                        column: x => x.UserId,
                        principalTable: "integrations.tg.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "registry.files",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    FileId = table.Column<Guid>(nullable: false),
                    FolderId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registry.files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_registry.files_core.static.files_FileId",
                        column: x => x.FileId,
                        principalTable: "core.static.files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_registry.files_registry.folders_FolderId",
                        column: x => x.FolderId,
                        principalTable: "registry.folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_registry.files_core.users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "core.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "registry.registries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    OwnerId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    RootId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registry.registries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_registry.registries_core.users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "core.users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_registry.registries_registry.folders_RootId",
                        column: x => x.RootId,
                        principalTable: "registry.folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "core.groups",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "sa" },
                    { new Guid("81d73ef6-da15-43ab-8f6d-d9663d9e2822"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "all" },
                    { new Guid("92581db6-0e31-4669-a77d-1730f464b005"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user" },
                    { new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "system" }
                });

            migrationBuilder.InsertData(
                table: "core.permissions",
                columns: new[] { "SubjectId", "ObjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 184, 7, 130, 153, 138, 241, 8, 69, 164, 21, 15, 182, 209, 110, 22, 21, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 254, 69, 198, 160, 57, 98, 6, 79, 133, 17, 174, 182, 218, 81, 134, 244, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 171, 236, 115, 44, 129, 186, 144, 70, 169, 110, 57, 152, 104, 80, 164, 122, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 254, 69, 198, 160, 57, 98, 6, 79, 133, 17, 174, 182, 218, 81, 134, 244, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 32, 120, 107, 4, 142, 132, 164, 74, 133, 105, 109, 46, 148, 201, 9, 179, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 254, 69, 198, 160, 57, 98, 6, 79, 133, 17, 174, 182, 218, 81, 134, 244, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 136, 21, 230, 23, 62, 50, 234, 73, 142, 223, 215, 122, 5, 157, 112, 235, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 254, 69, 198, 160, 57, 98, 6, 79, 133, 17, 174, 182, 218, 81, 134, 244, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 227, 231, 45, 242, 187, 174, 222, 75, 132, 91, 103, 2, 164, 169, 38, 130, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 254, 69, 198, 160, 57, 98, 6, 79, 133, 17, 174, 182, 218, 81, 134, 244, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 91, 128, 104, 107, 69, 18, 71, 79, 178, 233, 93, 58, 220, 104, 119, 152, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 254, 69, 198, 160, 57, 98, 6, 79, 133, 17, 174, 182, 218, 81, 134, 244, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 184, 7, 130, 153, 138, 241, 8, 69, 164, 21, 15, 182, 209, 110, 22, 21, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 193, 188, 74, 177, 167, 57, 32, 68, 172, 112, 43, 24, 237, 115, 225, 70, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 32, 120, 107, 4, 142, 132, 164, 74, 133, 105, 109, 46, 148, 201, 9, 179, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 193, 188, 74, 177, 167, 57, 32, 68, 172, 112, 43, 24, 237, 115, 225, 70, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 91, 128, 104, 107, 69, 18, 71, 79, 178, 233, 93, 58, 220, 104, 119, 152, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 207, 117, 12, 91, 165, 226, 40, 64, 175, 180, 242, 101, 178, 157, 27, 236, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 136, 21, 230, 23, 62, 50, 234, 73, 142, 223, 215, 122, 5, 157, 112, 235, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 193, 188, 74, 177, 167, 57, 32, 68, 172, 112, 43, 24, 237, 115, 225, 70, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 184, 7, 130, 153, 138, 241, 8, 69, 164, 21, 15, 182, 209, 110, 22, 21, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 62, 128, 68, 255, 152, 233, 31, 69, 133, 7, 209, 236, 191, 203, 207, 121, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 171, 236, 115, 44, 129, 186, 144, 70, 169, 110, 57, 152, 104, 80, 164, 122, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 62, 128, 68, 255, 152, 233, 31, 69, 133, 7, 209, 236, 191, 203, 207, 121, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 32, 120, 107, 4, 142, 132, 164, 74, 133, 105, 109, 46, 148, 201, 9, 179, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 62, 128, 68, 255, 152, 233, 31, 69, 133, 7, 209, 236, 191, 203, 207, 121, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 136, 21, 230, 23, 62, 50, 234, 73, 142, 223, 215, 122, 5, 157, 112, 235, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 62, 128, 68, 255, 152, 233, 31, 69, 133, 7, 209, 236, 191, 203, 207, 121, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 171, 236, 115, 44, 129, 186, 144, 70, 169, 110, 57, 152, 104, 80, 164, 122, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 193, 188, 74, 177, 167, 57, 32, 68, 172, 112, 43, 24, 237, 115, 225, 70, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 227, 231, 45, 242, 187, 174, 222, 75, 132, 91, 103, 2, 164, 169, 38, 130, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 207, 117, 12, 91, 165, 226, 40, 64, 175, 180, 242, 101, 178, 157, 27, 236, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 136, 21, 230, 23, 62, 50, 234, 73, 142, 223, 215, 122, 5, 157, 112, 235, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 207, 117, 12, 91, 165, 226, 40, 64, 175, 180, 242, 101, 178, 157, 27, 236, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 32, 120, 107, 4, 142, 132, 164, 74, 133, 105, 109, 46, 148, 201, 9, 179, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 207, 117, 12, 91, 165, 226, 40, 64, 175, 180, 242, 101, 178, 157, 27, 236, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 171, 236, 115, 44, 129, 186, 144, 70, 169, 110, 57, 152, 104, 80, 164, 122, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 207, 117, 12, 91, 165, 226, 40, 64, 175, 180, 242, 101, 178, 157, 27, 236, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 184, 7, 130, 153, 138, 241, 8, 69, 164, 21, 15, 182, 209, 110, 22, 21, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 207, 117, 12, 91, 165, 226, 40, 64, 175, 180, 242, 101, 178, 157, 27, 236, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "core.roles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("f22de7e3-aebb-4bde-845b-6702a4a92682"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "sa" },
                    { new Guid("9a2814f7-b6c9-481d-882b-f5f5be4a5a89"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user" },
                    { new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "system" },
                    { new Guid("59fe43ef-245b-4222-bfba-6b1c9e92c726"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user_creator" },
                    { new Guid("abaadf2c-137b-433a-87c8-33b437526bd4"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "role_creator" },
                    { new Guid("eaf895bc-9c09-47e3-b539-d8b389323416"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "group_creator" },
                    { new Guid("49b185ee-070d-4831-a614-fe9d6bf509d4"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "registry_folder_creator" },
                    { new Guid("dbd2c97b-db84-4fc3-a3ca-ad0c3953ca35"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "registry_file_creator" },
                    { new Guid("d90ae8ad-3d22-4a60-8342-b85b2c9b7965"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "registry_creator" }
                });

            migrationBuilder.InsertData(
                table: "core.users",
                columns: new[] { "Id", "CreationDate", "Description", "IsClosed", "IsDeleted", "LastActivity", "LastLogon", "ModifiedDate", "PasswordHash", "Username", "WebTicket" },
                values: new object[,]
                {
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Супер-пользователь системы TL Engine", false, false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "sa", new Guid("138c3a38-faab-460e-9e99-717458bf50a2") },
                    { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Шаблонный пользователь системы TL Engine", true, false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "user", new Guid("d5467afd-2222-4b95-a41a-66f8ee032ee8") },
                    { new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Автоматика системы TL Engine", true, false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "system", new Guid("0eea538e-82c5-4728-b2e6-a33640128f7c") }
                });

            migrationBuilder.InsertData(
                table: "integrations.tg.roles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("c6682671-0238-492c-a871-db76d512a280"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user" },
                    { new Guid("bc59f363-3d93-479c-97f6-8f9cc1fe3440"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "sa" },
                    { new Guid("3f83a69f-1fe3-4a10-b6a6-6ceb7e66367c"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "admin" },
                    { new Guid("0e7012ab-115a-48b2-9291-3bb97b3712e8"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "system" }
                });

            migrationBuilder.InsertData(
                table: "account.subscriptions",
                columns: new[] { "FromId", "ToId", "CreationDate", "IsDeleted", "ModifiedDate", "Quiet" },
                values: new object[,]
                {
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false },
                    { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false }
                });

            migrationBuilder.InsertData(
                table: "core.users.groups",
                columns: new[] { "UserId", "GroupId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("81d73ef6-da15-43ab-8f6d-d9663d9e2822"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("92581db6-0e31-4669-a77d-1730f464b005"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("81d73ef6-da15-43ab-8f6d-d9663d9e2822"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new Guid("92581db6-0e31-4669-a77d-1730f464b005"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new Guid("81d73ef6-da15-43ab-8f6d-d9663d9e2822"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "core.users.roles",
                columns: new[] { "UserId", "RoleId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new Guid("9a2814f7-b6c9-481d-882b-f5f5be4a5a89"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("dbd2c97b-db84-4fc3-a3ca-ad0c3953ca35"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("d90ae8ad-3d22-4a60-8342-b85b2c9b7965"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("d90ae8ad-3d22-4a60-8342-b85b2c9b7965"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("eaf895bc-9c09-47e3-b539-d8b389323416"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("abaadf2c-137b-433a-87c8-33b437526bd4"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("59fe43ef-245b-4222-bfba-6b1c9e92c726"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("9a2814f7-b6c9-481d-882b-f5f5be4a5a89"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("f22de7e3-aebb-4bde-845b-6702a4a92682"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("49b185ee-070d-4831-a614-fe9d6bf509d4"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "registry.folders",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name", "OwnerId", "ParantId" },
                values: new object[] { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Root Registry Folder", new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), null });

            migrationBuilder.InsertData(
                table: "registry.folders",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name", "OwnerId", "ParantId" },
                values: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Module Store Registry Folder", new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4") });

            migrationBuilder.InsertData(
                table: "registry.registries",
                columns: new[] { "Id", "CreationDate", "Description", "IsDeleted", "ModifiedDate", "Name", "OwnerId", "RootId", "Type" },
                values: new object[] { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Root Registry", false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "<Root>", new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), 1 });

            migrationBuilder.InsertData(
                table: "registry.registries",
                columns: new[] { "Id", "CreationDate", "Description", "IsDeleted", "ModifiedDate", "Name", "OwnerId", "RootId", "Type" },
                values: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Module Store Registry", false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "M-Store", new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_api.tokens_OwnerId",
                table: "api.tokens",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_api.tokens.logs_TokenId",
                table: "api.tokens.logs",
                column: "TokenId");

            migrationBuilder.CreateIndex(
                name: "IX_api.tokens.logs_UserId",
                table: "api.tokens.logs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_core.groups_Name",
                table: "core.groups",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_core.reports_CreationDate",
                table: "core.reports",
                column: "CreationDate");

            migrationBuilder.CreateIndex(
                name: "IX_core.reports_Message",
                table: "core.reports",
                column: "Message");

            migrationBuilder.CreateIndex(
                name: "IX_core.reports_ModifiedDate",
                table: "core.reports",
                column: "ModifiedDate");

            migrationBuilder.CreateIndex(
                name: "IX_core.reports_UserId",
                table: "core.reports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_core.roles_Name",
                table: "core.roles",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_core.static.files_AuthorId",
                table: "core.static.files",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_core.static.files_OriginalId",
                table: "core.static.files",
                column: "OriginalId");

            migrationBuilder.CreateIndex(
                name: "IX_core.string.variables_AuthorId",
                table: "core.string.variables",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_core.string.variables_Name",
                table: "core.string.variables",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_core.users_Username",
                table: "core.users",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_core.users.groups_GroupId",
                table: "core.users.groups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_core.users.roles_RoleId",
                table: "core.users.roles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_integrations.tg.bots_Token_TypeName",
                table: "integrations.tg.bots",
                columns: new[] { "Token", "TypeName" },
                unique: true,
                filter: "[Token] IS NOT NULL AND [TypeName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_integrations.tg.connections_UserId",
                table: "integrations.tg.connections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_integrations.tg.roles_Name",
                table: "integrations.tg.roles",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_integrations.tg.users_UserId",
                table: "integrations.tg.users",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_integrations.tg.users.roles_RoleId",
                table: "integrations.tg.users.roles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_justbot.history_AuthorId",
                table: "justbot.history",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_justbot.person_Token",
                table: "justbot.person",
                column: "Token",
                unique: true,
                filter: "[Token] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_linker.links_Identifier",
                table: "linker.links",
                column: "Identifier",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_linker.links_Url",
                table: "linker.links",
                column: "Url",
                unique: true,
                filter: "[Url] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_registry.files_FileId",
                table: "registry.files",
                column: "FileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_registry.files_FolderId",
                table: "registry.files",
                column: "FolderId");

            migrationBuilder.CreateIndex(
                name: "IX_registry.files_Id",
                table: "registry.files",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_registry.files_Name",
                table: "registry.files",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_registry.files_OwnerId",
                table: "registry.files",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_registry.folders_Name",
                table: "registry.folders",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_registry.folders_OwnerId",
                table: "registry.folders",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_registry.folders_ParantId",
                table: "registry.folders",
                column: "ParantId");

            migrationBuilder.CreateIndex(
                name: "IX_registry.registries_Name",
                table: "registry.registries",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_registry.registries_OwnerId",
                table: "registry.registries",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_registry.registries_RootId",
                table: "registry.registries",
                column: "RootId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account.subscriptions");

            migrationBuilder.DropTable(
                name: "api.tokens.logs");

            migrationBuilder.DropTable(
                name: "core.permissions");

            migrationBuilder.DropTable(
                name: "core.reports");

            migrationBuilder.DropTable(
                name: "core.string.variables");

            migrationBuilder.DropTable(
                name: "core.users.groups");

            migrationBuilder.DropTable(
                name: "core.users.roles");

            migrationBuilder.DropTable(
                name: "integrations.tg.connections");

            migrationBuilder.DropTable(
                name: "integrations.tg.users.roles");

            migrationBuilder.DropTable(
                name: "justbot.history");

            migrationBuilder.DropTable(
                name: "linker.links");

            migrationBuilder.DropTable(
                name: "registry.files");

            migrationBuilder.DropTable(
                name: "registry.registries");

            migrationBuilder.DropTable(
                name: "api.tokens");

            migrationBuilder.DropTable(
                name: "core.groups");

            migrationBuilder.DropTable(
                name: "core.roles");

            migrationBuilder.DropTable(
                name: "integrations.tg.bots");

            migrationBuilder.DropTable(
                name: "integrations.tg.roles");

            migrationBuilder.DropTable(
                name: "integrations.tg.users");

            migrationBuilder.DropTable(
                name: "justbot.person");

            migrationBuilder.DropTable(
                name: "core.static.files");

            migrationBuilder.DropTable(
                name: "registry.folders");

            migrationBuilder.DropTable(
                name: "core.users");
        }
    }
}
