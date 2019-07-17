using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v11064 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"));

            migrationBuilder.DeleteData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"));

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") });

            migrationBuilder.DeleteData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"));

            migrationBuilder.DeleteData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"));

            migrationBuilder.DeleteData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"));

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "_.StringVariables",
                nullable: false,
                defaultValue: new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.CreateTable(
                name: "Registry.Folders",
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
                    table.PrimaryKey("PK_Registry.Folders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registry.Folders__.Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registry.Folders_Registry.Folders_ParantId",
                        column: x => x.ParantId,
                        principalTable: "Registry.Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.Files",
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
                    table.PrimaryKey("PK_Registry.Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registry.Files__.StaticFiles_FileId",
                        column: x => x.FileId,
                        principalTable: "_.StaticFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.Files_Registry.Folders_FolderId",
                        column: x => x.FolderId,
                        principalTable: "Registry.Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registry.Files__.Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registry.FoldersGroupPermissions",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    ObjectId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.FoldersGroupPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.FoldersGroupPermissions_Registry.Folders_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.FoldersGroupPermissions__.Groups_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.FoldersRolePermissions",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    ObjectId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.FoldersRolePermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.FoldersRolePermissions_Registry.Folders_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.FoldersRolePermissions__.Roles_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.FoldersUserPermissions",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    ObjectId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.FoldersUserPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.FoldersUserPermissions_Registry.Folders_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.FoldersUserPermissions__.Users_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.Registries",
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
                    table.PrimaryKey("PK_Registry.Registries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registry.Registries__.Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registry.Registries_Registry.Folders_RootId",
                        column: x => x.RootId,
                        principalTable: "Registry.Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registry.FilesGroupPermissions",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    ObjectId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.FilesGroupPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.FilesGroupPermissions_Registry.Files_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.FilesGroupPermissions__.Groups_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.FilesRolePermissions",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    ObjectId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.FilesRolePermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.FilesRolePermissions_Registry.Files_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.FilesRolePermissions__.Roles_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.FilesUserPermissions",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    ObjectId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.FilesUserPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.FilesUserPermissions_Registry.Files_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.FilesUserPermissions__.Users_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.RegistriesGroupPermissions",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    ObjectId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.RegistriesGroupPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.RegistriesGroupPermissions_Registry.Registries_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Registries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.RegistriesGroupPermissions__.Groups_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.RegistriesRolePermissions",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    ObjectId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.RegistriesRolePermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.RegistriesRolePermissions_Registry.Registries_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Registries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.RegistriesRolePermissions__.Roles_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.RegistriesUserPermissions",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(nullable: false),
                    ObjectId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.RegistriesUserPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.RegistriesUserPermissions_Registry.Registries_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Registries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.RegistriesUserPermissions__.Users_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Integrations.TgRoles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("bc59f363-3d93-479c-97f6-8f9cc1fe3440"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "sa" },
                    { new Guid("3f83a69f-1fe3-4a10-b6a6-6ceb7e66367c"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "admin" },
                    { new Guid("c6682671-0238-492c-a871-db76d512a280"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user" },
                    { new Guid("0e7012ab-115a-48b2-9291-3bb97b3712e8"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "system" }
                });

            migrationBuilder.InsertData(
                table: "_.Groups",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "sa" },
                    { new Guid("81d73ef6-da15-43ab-8f6d-d9663d9e2822"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "all" },
                    { new Guid("92581db6-0e31-4669-a77d-1730f464b005"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user" },
                    { new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "system" }
                });

            migrationBuilder.InsertData(
                table: "_.Roles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("f22de7e3-aebb-4bde-845b-6702a4a92682"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "sa" },
                    { new Guid("9a2814f7-b6c9-481d-882b-f5f5be4a5a89"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user" },
                    { new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "system" }
                });

            migrationBuilder.InsertData(
                table: "_.Users",
                columns: new[] { "Id", "CreationDate", "Description", "IsClosed", "IsDeleted", "LastActivity", "LastLogon", "ModifiedDate", "PasswordHash", "Username", "WebTicket" },
                values: new object[,]
                {
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Супер-пользователь системы TL Engine", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "sa", new Guid("1a347b5d-332f-439b-81a8-e367db56b7a2") },
                    { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Шаблонный пользователь системы TL Engine", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "user", new Guid("3a6ef419-ae3a-4aff-ac4e-bc5cd68fe10f") },
                    { new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Автоматика системы TL Engine", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "system", new Guid("a6cf22c9-90d8-46ec-bb75-d2fd2e4ec45f") }
                });

            migrationBuilder.InsertData(
                table: "Account.Subscriptions",
                columns: new[] { "FromId", "ToId", "CreationDate", "IsDeleted", "ModifiedDate", "Quiet" },
                values: new object[,]
                {
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false },
                    { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false }
                });

            migrationBuilder.InsertData(
                table: "Registry.Folders",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name", "OwnerId", "ParantId" },
                values: new object[] { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Root Registry Folder", new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), null });

            migrationBuilder.InsertData(
                table: "_.UsersGroups",
                columns: new[] { "UserId", "GroupId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("81d73ef6-da15-43ab-8f6d-d9663d9e2822"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("92581db6-0e31-4669-a77d-1730f464b005"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new Guid("81d73ef6-da15-43ab-8f6d-d9663d9e2822"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new Guid("92581db6-0e31-4669-a77d-1730f464b005"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("81d73ef6-da15-43ab-8f6d-d9663d9e2822"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "_.UsersRoles",
                columns: new[] { "UserId", "RoleId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("f22de7e3-aebb-4bde-845b-6702a4a92682"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("9a2814f7-b6c9-481d-882b-f5f5be4a5a89"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new Guid("9a2814f7-b6c9-481d-882b-f5f5be4a5a89"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.Folders",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name", "OwnerId", "ParantId" },
                values: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Module Store Registry Folder", new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4") });

            migrationBuilder.InsertData(
                table: "Registry.FoldersGroupPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.FoldersRolePermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new Guid("f22de7e3-aebb-4bde-845b-6702a4a92682"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.FoldersUserPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.Registries",
                columns: new[] { "Id", "CreationDate", "Description", "IsDeleted", "ModifiedDate", "Name", "OwnerId", "RootId", "Type" },
                values: new object[] { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "System Root Registry", false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "<Root>", new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), 1 });

            migrationBuilder.InsertData(
                table: "Registry.FoldersGroupPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.FoldersUserPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.Registries",
                columns: new[] { "Id", "CreationDate", "Description", "IsDeleted", "ModifiedDate", "Name", "OwnerId", "RootId", "Type" },
                values: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Module Store Registry", false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "M-Store", new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), 1 });

            migrationBuilder.InsertData(
                table: "Registry.RegistriesGroupPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.RegistriesRolePermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new Guid("f22de7e3-aebb-4bde-845b-6702a4a92682"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.RegistriesUserPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.RegistriesGroupPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.RegistriesUserPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registry.Files_FileId",
                table: "Registry.Files",
                column: "FileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Registry.Files_FolderId",
                table: "Registry.Files",
                column: "FolderId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.Files_Id",
                table: "Registry.Files",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.Files_Name",
                table: "Registry.Files",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.Files_OwnerId",
                table: "Registry.Files",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FilesGroupPermissions_SubjectId",
                table: "Registry.FilesGroupPermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FilesRolePermissions_SubjectId",
                table: "Registry.FilesRolePermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FilesUserPermissions_SubjectId",
                table: "Registry.FilesUserPermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.Folders_Name",
                table: "Registry.Folders",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.Folders_OwnerId",
                table: "Registry.Folders",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.Folders_ParantId",
                table: "Registry.Folders",
                column: "ParantId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FoldersGroupPermissions_SubjectId",
                table: "Registry.FoldersGroupPermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FoldersRolePermissions_SubjectId",
                table: "Registry.FoldersRolePermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FoldersUserPermissions_SubjectId",
                table: "Registry.FoldersUserPermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.Registries_Name",
                table: "Registry.Registries",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.Registries_OwnerId",
                table: "Registry.Registries",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.Registries_RootId",
                table: "Registry.Registries",
                column: "RootId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.RegistriesGroupPermissions_SubjectId",
                table: "Registry.RegistriesGroupPermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.RegistriesRolePermissions_SubjectId",
                table: "Registry.RegistriesRolePermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.RegistriesUserPermissions_SubjectId",
                table: "Registry.RegistriesUserPermissions",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registry.FilesGroupPermissions");

            migrationBuilder.DropTable(
                name: "Registry.FilesRolePermissions");

            migrationBuilder.DropTable(
                name: "Registry.FilesUserPermissions");

            migrationBuilder.DropTable(
                name: "Registry.FoldersGroupPermissions");

            migrationBuilder.DropTable(
                name: "Registry.FoldersRolePermissions");

            migrationBuilder.DropTable(
                name: "Registry.FoldersUserPermissions");

            migrationBuilder.DropTable(
                name: "Registry.RegistriesGroupPermissions");

            migrationBuilder.DropTable(
                name: "Registry.RegistriesRolePermissions");

            migrationBuilder.DropTable(
                name: "Registry.RegistriesUserPermissions");

            migrationBuilder.DropTable(
                name: "Registry.Files");

            migrationBuilder.DropTable(
                name: "Registry.Registries");

            migrationBuilder.DropTable(
                name: "Registry.Folders");

            migrationBuilder.DeleteData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a") });

            migrationBuilder.DeleteData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a") });

            migrationBuilder.DeleteData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("0e7012ab-115a-48b2-9291-3bb97b3712e8"));

            migrationBuilder.DeleteData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("3f83a69f-1fe3-4a10-b6a6-6ceb7e66367c"));

            migrationBuilder.DeleteData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bc59f363-3d93-479c-97f6-8f9cc1fe3440"));

            migrationBuilder.DeleteData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("c6682671-0238-492c-a871-db76d512a280"));

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("81d73ef6-da15-43ab-8f6d-d9663d9e2822") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new Guid("81d73ef6-da15-43ab-8f6d-d9663d9e2822") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new Guid("92581db6-0e31-4669-a77d-1730f464b005") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("81d73ef6-da15-43ab-8f6d-d9663d9e2822") });

            migrationBuilder.DeleteData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("92581db6-0e31-4669-a77d-1730f464b005") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"), new Guid("9a2814f7-b6c9-481d-882b-f5f5be4a5a89") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("9a2814f7-b6c9-481d-882b-f5f5be4a5a89") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("f22de7e3-aebb-4bde-845b-6702a4a92682") });

            migrationBuilder.DeleteData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"));

            migrationBuilder.DeleteData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"));

            migrationBuilder.DeleteData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("81d73ef6-da15-43ab-8f6d-d9663d9e2822"));

            migrationBuilder.DeleteData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("92581db6-0e31-4669-a77d-1730f464b005"));

            migrationBuilder.DeleteData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798"));

            migrationBuilder.DeleteData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("9a2814f7-b6c9-481d-882b-f5f5be4a5a89"));

            migrationBuilder.DeleteData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("f22de7e3-aebb-4bde-845b-6702a4a92682"));

            migrationBuilder.DeleteData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"));

            migrationBuilder.DeleteData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"));

            migrationBuilder.DeleteData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"));

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "_.StringVariables",
                nullable: false,
                defaultValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"));

            migrationBuilder.InsertData(
                table: "Integrations.TgRoles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(3660), false, new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(3690), "sa" },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(6158), false, new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(6170), "admin" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(7153), false, new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(7161), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(8117), false, new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(8125), "system" }
                });

            migrationBuilder.InsertData(
                table: "_.Groups",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7587), false, new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7599), "sa" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7618), false, new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7620), "all" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7629), false, new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7631), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7637), false, new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7639), "system" }
                });

            migrationBuilder.InsertData(
                table: "_.Roles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 10, 23, 51, 52, 264, DateTimeKind.Utc).AddTicks(1602), false, new DateTime(2019, 7, 10, 23, 51, 52, 264, DateTimeKind.Utc).AddTicks(1618), "sa" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 7, 10, 23, 51, 52, 264, DateTimeKind.Utc).AddTicks(1645), false, new DateTime(2019, 7, 10, 23, 51, 52, 264, DateTimeKind.Utc).AddTicks(1647), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 10, 23, 51, 52, 264, DateTimeKind.Utc).AddTicks(1655), false, new DateTime(2019, 7, 10, 23, 51, 52, 264, DateTimeKind.Utc).AddTicks(1657), "system" }
                });

            migrationBuilder.InsertData(
                table: "_.Users",
                columns: new[] { "Id", "CreationDate", "Description", "IsClosed", "IsDeleted", "LastActivity", "LastLogon", "ModifiedDate", "PasswordHash", "Username", "WebTicket" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 10, 23, 51, 52, 253, DateTimeKind.Utc).AddTicks(2315), "Супер-пользователь системы TL Engine", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 10, 23, 51, 52, 253, DateTimeKind.Utc).AddTicks(2341), null, "sa", new Guid("767ffadc-3ced-41dc-97b7-c73a56ef0c92") },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 7, 10, 23, 51, 52, 253, DateTimeKind.Utc).AddTicks(3406), "Шаблонный пользователь системы TL Engine", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 10, 23, 51, 52, 253, DateTimeKind.Utc).AddTicks(3414), null, "user", new Guid("b59d8227-9a28-4898-b147-4a15ea68abd9") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 10, 23, 51, 52, 253, DateTimeKind.Utc).AddTicks(3447), "Автоматика системы TL Engine", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 10, 23, 51, 52, 253, DateTimeKind.Utc).AddTicks(3449), null, "system", new Guid("740bf8bf-6082-420b-995d-e4abeb745c68") }
                });

            migrationBuilder.InsertData(
                table: "Account.Subscriptions",
                columns: new[] { "FromId", "ToId", "CreationDate", "IsDeleted", "ModifiedDate", "Quiet" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 10, 23, 51, 52, 284, DateTimeKind.Utc).AddTicks(1507), false, new DateTime(2019, 7, 10, 23, 51, 52, 284, DateTimeKind.Utc).AddTicks(1536), false },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 10, 23, 51, 52, 284, DateTimeKind.Utc).AddTicks(3956), false, new DateTime(2019, 7, 10, 23, 51, 52, 284, DateTimeKind.Utc).AddTicks(3964), false }
                });

            migrationBuilder.InsertData(
                table: "_.UsersGroups",
                columns: new[] { "UserId", "GroupId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(827), false, new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(850) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(5040), false, new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(5050) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(6025), false, new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(6027) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(6914), false, new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(6916) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(9969), false, new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(9976) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 7, 10, 23, 51, 52, 262, DateTimeKind.Utc).AddTicks(47), false, new DateTime(2019, 7, 10, 23, 51, 52, 262, DateTimeKind.Utc).AddTicks(48) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2019, 7, 10, 23, 51, 52, 262, DateTimeKind.Utc).AddTicks(2413), false, new DateTime(2019, 7, 10, 23, 51, 52, 262, DateTimeKind.Utc).AddTicks(2421) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 10, 23, 51, 52, 262, DateTimeKind.Utc).AddTicks(2465), false, new DateTime(2019, 7, 10, 23, 51, 52, 262, DateTimeKind.Utc).AddTicks(2466) }
                });

            migrationBuilder.InsertData(
                table: "_.UsersRoles",
                columns: new[] { "UserId", "RoleId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(1462), false, new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(1483) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(5552), false, new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(5560) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(6544), false, new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(6546) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(8948), false, new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(8956) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 10, 23, 51, 52, 258, DateTimeKind.Utc).AddTicks(520), false, new DateTime(2019, 7, 10, 23, 51, 52, 258, DateTimeKind.Utc).AddTicks(527) }
                });
        }
    }
}
