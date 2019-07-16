using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v11064 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Registry.GroupPermissions",
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
                    table.PrimaryKey("PK_Registry.GroupPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.GroupPermissions_Registry.Registries_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Registries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.GroupPermissions__.Groups_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.UserPermissions",
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
                    table.PrimaryKey("PK_Registry.UserPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.UserPermissions_Registry.Registries_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Registries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.UserPermissions__.Users_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 570, DateTimeKind.Utc).AddTicks(7400), new DateTime(2019, 7, 16, 22, 30, 48, 570, DateTimeKind.Utc).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 570, DateTimeKind.Utc).AddTicks(5551), new DateTime(2019, 7, 16, 22, 30, 48, 570, DateTimeKind.Utc).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 607, DateTimeKind.Utc).AddTicks(9998), new DateTime(2019, 7, 16, 22, 30, 48, 608, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 607, DateTimeKind.Utc).AddTicks(8450), new DateTime(2019, 7, 16, 22, 30, 48, 607, DateTimeKind.Utc).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 608, DateTimeKind.Utc).AddTicks(1424), new DateTime(2019, 7, 16, 22, 30, 48, 608, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 607, DateTimeKind.Utc).AddTicks(5868), new DateTime(2019, 7, 16, 22, 30, 48, 607, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 538, DateTimeKind.Utc).AddTicks(9700), new DateTime(2019, 7, 16, 22, 30, 48, 538, DateTimeKind.Utc).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 538, DateTimeKind.Utc).AddTicks(9708), new DateTime(2019, 7, 16, 22, 30, 48, 538, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 538, DateTimeKind.Utc).AddTicks(9716), new DateTime(2019, 7, 16, 22, 30, 48, 538, DateTimeKind.Utc).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 538, DateTimeKind.Utc).AddTicks(9667), new DateTime(2019, 7, 16, 22, 30, 48, 538, DateTimeKind.Utc).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 536, DateTimeKind.Utc).AddTicks(9277), new DateTime(2019, 7, 16, 22, 30, 48, 536, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 536, DateTimeKind.Utc).AddTicks(9286), new DateTime(2019, 7, 16, 22, 30, 48, 536, DateTimeKind.Utc).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 536, DateTimeKind.Utc).AddTicks(9209), new DateTime(2019, 7, 16, 22, 30, 48, 536, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 517, DateTimeKind.Utc).AddTicks(6050), new DateTime(2019, 7, 16, 22, 30, 48, 517, DateTimeKind.Utc).AddTicks(6060), new Guid("e7ca0006-2c1e-4bd6-907d-120842210124") });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 517, DateTimeKind.Utc).AddTicks(6092), new DateTime(2019, 7, 16, 22, 30, 48, 517, DateTimeKind.Utc).AddTicks(6093), new Guid("0ac89176-869e-477a-bde1-edea8ad98851") });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 517, DateTimeKind.Utc).AddTicks(4258), new DateTime(2019, 7, 16, 22, 30, 48, 517, DateTimeKind.Utc).AddTicks(4280), new Guid("b8132dbd-301e-4e55-b2a2-f33c90b1988a") });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 533, DateTimeKind.Utc).AddTicks(9992), new DateTime(2019, 7, 16, 22, 30, 48, 534, DateTimeKind.Utc).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 534, DateTimeKind.Utc).AddTicks(63), new DateTime(2019, 7, 16, 22, 30, 48, 534, DateTimeKind.Utc).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 534, DateTimeKind.Utc).AddTicks(4254), new DateTime(2019, 7, 16, 22, 30, 48, 534, DateTimeKind.Utc).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 534, DateTimeKind.Utc).AddTicks(4318), new DateTime(2019, 7, 16, 22, 30, 48, 534, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 532, DateTimeKind.Utc).AddTicks(7524), new DateTime(2019, 7, 16, 22, 30, 48, 532, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 533, DateTimeKind.Utc).AddTicks(3246), new DateTime(2019, 7, 16, 22, 30, 48, 533, DateTimeKind.Utc).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 533, DateTimeKind.Utc).AddTicks(4759), new DateTime(2019, 7, 16, 22, 30, 48, 533, DateTimeKind.Utc).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 533, DateTimeKind.Utc).AddTicks(1582), new DateTime(2019, 7, 16, 22, 30, 48, 533, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 528, DateTimeKind.Utc).AddTicks(7068), new DateTime(2019, 7, 16, 22, 30, 48, 528, DateTimeKind.Utc).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 528, DateTimeKind.Utc).AddTicks(9487), new DateTime(2019, 7, 16, 22, 30, 48, 528, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 528, DateTimeKind.Utc).AddTicks(2064), new DateTime(2019, 7, 16, 22, 30, 48, 528, DateTimeKind.Utc).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 528, DateTimeKind.Utc).AddTicks(3658), new DateTime(2019, 7, 16, 22, 30, 48, 528, DateTimeKind.Utc).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 22, 30, 48, 527, DateTimeKind.Utc).AddTicks(8121), new DateTime(2019, 7, 16, 22, 30, 48, 527, DateTimeKind.Utc).AddTicks(8143) });

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
                name: "IX_Registry.FoldersUserPermissions_SubjectId",
                table: "Registry.FoldersUserPermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.GroupPermissions_SubjectId",
                table: "Registry.GroupPermissions",
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
                name: "IX_Registry.UserPermissions_SubjectId",
                table: "Registry.UserPermissions",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registry.FilesGroupPermissions");

            migrationBuilder.DropTable(
                name: "Registry.FilesUserPermissions");

            migrationBuilder.DropTable(
                name: "Registry.FoldersGroupPermissions");

            migrationBuilder.DropTable(
                name: "Registry.FoldersUserPermissions");

            migrationBuilder.DropTable(
                name: "Registry.GroupPermissions");

            migrationBuilder.DropTable(
                name: "Registry.UserPermissions");

            migrationBuilder.DropTable(
                name: "Registry.Files");

            migrationBuilder.DropTable(
                name: "Registry.Registries");

            migrationBuilder.DropTable(
                name: "Registry.Folders");

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 284, DateTimeKind.Utc).AddTicks(3956), new DateTime(2019, 7, 10, 23, 51, 52, 284, DateTimeKind.Utc).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 284, DateTimeKind.Utc).AddTicks(1507), new DateTime(2019, 7, 10, 23, 51, 52, 284, DateTimeKind.Utc).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(7153), new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(6158), new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(8117), new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(3660), new DateTime(2019, 7, 10, 23, 51, 52, 322, DateTimeKind.Utc).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7618), new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7629), new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7637), new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7587), new DateTime(2019, 7, 10, 23, 51, 52, 265, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 264, DateTimeKind.Utc).AddTicks(1645), new DateTime(2019, 7, 10, 23, 51, 52, 264, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 264, DateTimeKind.Utc).AddTicks(1655), new DateTime(2019, 7, 10, 23, 51, 52, 264, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 264, DateTimeKind.Utc).AddTicks(1602), new DateTime(2019, 7, 10, 23, 51, 52, 264, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 253, DateTimeKind.Utc).AddTicks(3406), new DateTime(2019, 7, 10, 23, 51, 52, 253, DateTimeKind.Utc).AddTicks(3414), new Guid("b59d8227-9a28-4898-b147-4a15ea68abd9") });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 253, DateTimeKind.Utc).AddTicks(3447), new DateTime(2019, 7, 10, 23, 51, 52, 253, DateTimeKind.Utc).AddTicks(3449), new Guid("740bf8bf-6082-420b-995d-e4abeb745c68") });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 253, DateTimeKind.Utc).AddTicks(2315), new DateTime(2019, 7, 10, 23, 51, 52, 253, DateTimeKind.Utc).AddTicks(2341), new Guid("767ffadc-3ced-41dc-97b7-c73a56ef0c92") });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(9969), new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 262, DateTimeKind.Utc).AddTicks(47), new DateTime(2019, 7, 10, 23, 51, 52, 262, DateTimeKind.Utc).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 262, DateTimeKind.Utc).AddTicks(2413), new DateTime(2019, 7, 10, 23, 51, 52, 262, DateTimeKind.Utc).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 262, DateTimeKind.Utc).AddTicks(2465), new DateTime(2019, 7, 10, 23, 51, 52, 262, DateTimeKind.Utc).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(827), new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(6025), new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(6914), new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(5040), new DateTime(2019, 7, 10, 23, 51, 52, 261, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(8948), new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 258, DateTimeKind.Utc).AddTicks(520), new DateTime(2019, 7, 10, 23, 51, 52, 258, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(5552), new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(6544), new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(1462), new DateTime(2019, 7, 10, 23, 51, 52, 257, DateTimeKind.Utc).AddTicks(1483) });
        }
    }
}
