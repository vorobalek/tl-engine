using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v110643 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registry.GroupPermissions_Registry.Registries_ObjectId",
                table: "Registry.GroupPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Registry.GroupPermissions__.Groups_SubjectId",
                table: "Registry.GroupPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Registry.UserPermissions_Registry.Registries_ObjectId",
                table: "Registry.UserPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Registry.UserPermissions__.Users_SubjectId",
                table: "Registry.UserPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registry.UserPermissions",
                table: "Registry.UserPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registry.GroupPermissions",
                table: "Registry.GroupPermissions");

            migrationBuilder.RenameTable(
                name: "Registry.UserPermissions",
                newName: "Registry.RegistriesUserPermissions");

            migrationBuilder.RenameTable(
                name: "Registry.GroupPermissions",
                newName: "Registry.RegistriesGroupPermissions");

            migrationBuilder.RenameIndex(
                name: "IX_Registry.UserPermissions_SubjectId",
                table: "Registry.RegistriesUserPermissions",
                newName: "IX_Registry.RegistriesUserPermissions_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Registry.GroupPermissions_SubjectId",
                table: "Registry.RegistriesGroupPermissions",
                newName: "IX_Registry.RegistriesGroupPermissions_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registry.RegistriesUserPermissions",
                table: "Registry.RegistriesUserPermissions",
                columns: new[] { "ObjectId", "SubjectId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registry.RegistriesGroupPermissions",
                table: "Registry.RegistriesGroupPermissions",
                columns: new[] { "ObjectId", "SubjectId" });

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

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 310, DateTimeKind.Utc).AddTicks(5618), new DateTime(2019, 7, 17, 8, 34, 5, 310, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 310, DateTimeKind.Utc).AddTicks(3750), new DateTime(2019, 7, 17, 8, 34, 5, 310, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 339, DateTimeKind.Utc).AddTicks(1630), new DateTime(2019, 7, 17, 8, 34, 5, 339, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 339, DateTimeKind.Utc).AddTicks(916), new DateTime(2019, 7, 17, 8, 34, 5, 339, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 339, DateTimeKind.Utc).AddTicks(2261), new DateTime(2019, 7, 17, 8, 34, 5, 339, DateTimeKind.Utc).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 338, DateTimeKind.Utc).AddTicks(8811), new DateTime(2019, 7, 17, 8, 34, 5, 338, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Registry.Folders",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 420, DateTimeKind.Utc).AddTicks(5853), new DateTime(2019, 7, 17, 8, 34, 5, 420, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Registry.Folders",
                keyColumn: "Id",
                keyValue: new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(274), new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 422, DateTimeKind.Utc).AddTicks(1144), new DateTime(2019, 7, 17, 8, 34, 5, 422, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 422, DateTimeKind.Utc).AddTicks(302), new DateTime(2019, 7, 17, 8, 34, 5, 422, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(7688), new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(6871), new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.InsertData(
                table: "Registry.FoldersRolePermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 17, 8, 34, 5, 422, DateTimeKind.Utc).AddTicks(3342), false, 7, new DateTime(2019, 7, 17, 8, 34, 5, 422, DateTimeKind.Utc).AddTicks(3347) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 17, 8, 34, 5, 422, DateTimeKind.Utc).AddTicks(2525), false, 7, new DateTime(2019, 7, 17, 8, 34, 5, 422, DateTimeKind.Utc).AddTicks(2530) }
                });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(8790), new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(7920), new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(5936), new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(5103), new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Registry.Registries",
                keyColumn: "Id",
                keyValue: new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 422, DateTimeKind.Utc).AddTicks(8158), new DateTime(2019, 7, 17, 8, 34, 5, 422, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Registry.Registries",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 420, DateTimeKind.Utc).AddTicks(1417), new DateTime(2019, 7, 17, 8, 34, 5, 420, DateTimeKind.Utc).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Registry.RegistriesGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(4193), new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Registry.RegistriesGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(3310), new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Registry.RegistriesGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(3662), new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Registry.RegistriesGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(2733), new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.InsertData(
                table: "Registry.RegistriesRolePermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(6490), false, 7, new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(6495) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(5574), false, 7, new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(5580) }
                });

            migrationBuilder.UpdateData(
                table: "Registry.RegistriesUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(2274), new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Registry.RegistriesUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(1318), new DateTime(2019, 7, 17, 8, 34, 5, 423, DateTimeKind.Utc).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Registry.RegistriesUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(783), new DateTime(2019, 7, 17, 8, 34, 5, 421, DateTimeKind.Utc).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "Registry.RegistriesUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 420, DateTimeKind.Utc).AddTicks(8263), new DateTime(2019, 7, 17, 8, 34, 5, 420, DateTimeKind.Utc).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 286, DateTimeKind.Utc).AddTicks(1615), new DateTime(2019, 7, 17, 8, 34, 5, 286, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 286, DateTimeKind.Utc).AddTicks(1622), new DateTime(2019, 7, 17, 8, 34, 5, 286, DateTimeKind.Utc).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 286, DateTimeKind.Utc).AddTicks(1628), new DateTime(2019, 7, 17, 8, 34, 5, 286, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 286, DateTimeKind.Utc).AddTicks(1593), new DateTime(2019, 7, 17, 8, 34, 5, 286, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 284, DateTimeKind.Utc).AddTicks(9621), new DateTime(2019, 7, 17, 8, 34, 5, 284, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 284, DateTimeKind.Utc).AddTicks(9630), new DateTime(2019, 7, 17, 8, 34, 5, 284, DateTimeKind.Utc).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 284, DateTimeKind.Utc).AddTicks(9597), new DateTime(2019, 7, 17, 8, 34, 5, 284, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 264, DateTimeKind.Utc).AddTicks(8049), new DateTime(2019, 7, 17, 8, 34, 5, 264, DateTimeKind.Utc).AddTicks(8054), new Guid("2c8136a5-50f8-41d4-b6c7-a24d86f4ec16") });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 264, DateTimeKind.Utc).AddTicks(8079), new DateTime(2019, 7, 17, 8, 34, 5, 264, DateTimeKind.Utc).AddTicks(8080), new Guid("273d0126-ffdb-4a59-b62c-bfdc2e605c9b") });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 264, DateTimeKind.Utc).AddTicks(7197), new DateTime(2019, 7, 17, 8, 34, 5, 264, DateTimeKind.Utc).AddTicks(7215), new Guid("9943a4c2-3f09-4b25-8127-13f7cf1382a4") });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 283, DateTimeKind.Utc).AddTicks(2992), new DateTime(2019, 7, 17, 8, 34, 5, 283, DateTimeKind.Utc).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 283, DateTimeKind.Utc).AddTicks(3039), new DateTime(2019, 7, 17, 8, 34, 5, 283, DateTimeKind.Utc).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 283, DateTimeKind.Utc).AddTicks(4832), new DateTime(2019, 7, 17, 8, 34, 5, 283, DateTimeKind.Utc).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 283, DateTimeKind.Utc).AddTicks(4866), new DateTime(2019, 7, 17, 8, 34, 5, 283, DateTimeKind.Utc).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 282, DateTimeKind.Utc).AddTicks(6351), new DateTime(2019, 7, 17, 8, 34, 5, 282, DateTimeKind.Utc).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 283, DateTimeKind.Utc).AddTicks(157), new DateTime(2019, 7, 17, 8, 34, 5, 283, DateTimeKind.Utc).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 283, DateTimeKind.Utc).AddTicks(845), new DateTime(2019, 7, 17, 8, 34, 5, 283, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 282, DateTimeKind.Utc).AddTicks(9279), new DateTime(2019, 7, 17, 8, 34, 5, 282, DateTimeKind.Utc).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 280, DateTimeKind.Utc).AddTicks(757), new DateTime(2019, 7, 17, 8, 34, 5, 280, DateTimeKind.Utc).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 280, DateTimeKind.Utc).AddTicks(2000), new DateTime(2019, 7, 17, 8, 34, 5, 280, DateTimeKind.Utc).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 279, DateTimeKind.Utc).AddTicks(8436), new DateTime(2019, 7, 17, 8, 34, 5, 279, DateTimeKind.Utc).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 279, DateTimeKind.Utc).AddTicks(9168), new DateTime(2019, 7, 17, 8, 34, 5, 279, DateTimeKind.Utc).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 8, 34, 5, 279, DateTimeKind.Utc).AddTicks(5337), new DateTime(2019, 7, 17, 8, 34, 5, 279, DateTimeKind.Utc).AddTicks(5356) });

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FilesRolePermissions_SubjectId",
                table: "Registry.FilesRolePermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FoldersRolePermissions_SubjectId",
                table: "Registry.FoldersRolePermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.RegistriesRolePermissions_SubjectId",
                table: "Registry.RegistriesRolePermissions",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registry.RegistriesGroupPermissions_Registry.Registries_ObjectId",
                table: "Registry.RegistriesGroupPermissions",
                column: "ObjectId",
                principalTable: "Registry.Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registry.RegistriesGroupPermissions__.Groups_SubjectId",
                table: "Registry.RegistriesGroupPermissions",
                column: "SubjectId",
                principalTable: "_.Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Registry.RegistriesUserPermissions_Registry.Registries_ObjectId",
                table: "Registry.RegistriesUserPermissions",
                column: "ObjectId",
                principalTable: "Registry.Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registry.RegistriesUserPermissions__.Users_SubjectId",
                table: "Registry.RegistriesUserPermissions",
                column: "SubjectId",
                principalTable: "_.Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registry.RegistriesGroupPermissions_Registry.Registries_ObjectId",
                table: "Registry.RegistriesGroupPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Registry.RegistriesGroupPermissions__.Groups_SubjectId",
                table: "Registry.RegistriesGroupPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Registry.RegistriesUserPermissions_Registry.Registries_ObjectId",
                table: "Registry.RegistriesUserPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Registry.RegistriesUserPermissions__.Users_SubjectId",
                table: "Registry.RegistriesUserPermissions");

            migrationBuilder.DropTable(
                name: "Registry.FilesRolePermissions");

            migrationBuilder.DropTable(
                name: "Registry.FoldersRolePermissions");

            migrationBuilder.DropTable(
                name: "Registry.RegistriesRolePermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registry.RegistriesUserPermissions",
                table: "Registry.RegistriesUserPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registry.RegistriesGroupPermissions",
                table: "Registry.RegistriesGroupPermissions");

            migrationBuilder.RenameTable(
                name: "Registry.RegistriesUserPermissions",
                newName: "Registry.UserPermissions");

            migrationBuilder.RenameTable(
                name: "Registry.RegistriesGroupPermissions",
                newName: "Registry.GroupPermissions");

            migrationBuilder.RenameIndex(
                name: "IX_Registry.RegistriesUserPermissions_SubjectId",
                table: "Registry.UserPermissions",
                newName: "IX_Registry.UserPermissions_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Registry.RegistriesGroupPermissions_SubjectId",
                table: "Registry.GroupPermissions",
                newName: "IX_Registry.GroupPermissions_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registry.UserPermissions",
                table: "Registry.UserPermissions",
                columns: new[] { "ObjectId", "SubjectId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registry.GroupPermissions",
                table: "Registry.GroupPermissions",
                columns: new[] { "ObjectId", "SubjectId" });

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 126, DateTimeKind.Utc).AddTicks(5523), new DateTime(2019, 7, 17, 6, 49, 59, 126, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 126, DateTimeKind.Utc).AddTicks(3745), new DateTime(2019, 7, 17, 6, 49, 59, 126, DateTimeKind.Utc).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 154, DateTimeKind.Utc).AddTicks(4593), new DateTime(2019, 7, 17, 6, 49, 59, 154, DateTimeKind.Utc).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 154, DateTimeKind.Utc).AddTicks(3902), new DateTime(2019, 7, 17, 6, 49, 59, 154, DateTimeKind.Utc).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 154, DateTimeKind.Utc).AddTicks(5218), new DateTime(2019, 7, 17, 6, 49, 59, 154, DateTimeKind.Utc).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 154, DateTimeKind.Utc).AddTicks(1722), new DateTime(2019, 7, 17, 6, 49, 59, 154, DateTimeKind.Utc).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Registry.Folders",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 220, DateTimeKind.Utc).AddTicks(2545), new DateTime(2019, 7, 17, 6, 49, 59, 220, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Registry.Folders",
                keyColumn: "Id",
                keyValue: new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(2552), new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 221, DateTimeKind.Utc).AddTicks(5327), new DateTime(2019, 7, 17, 6, 49, 59, 221, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 221, DateTimeKind.Utc).AddTicks(4474), new DateTime(2019, 7, 17, 6, 49, 59, 221, DateTimeKind.Utc).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(9890), new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(9034), new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 221, DateTimeKind.Utc).AddTicks(2991), new DateTime(2019, 7, 17, 6, 49, 59, 221, DateTimeKind.Utc).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 221, DateTimeKind.Utc).AddTicks(2079), new DateTime(2019, 7, 17, 6, 49, 59, 221, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(8149), new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(7311), new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Registry.GroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(6386), new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Registry.GroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(5518), new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Registry.GroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 221, DateTimeKind.Utc).AddTicks(568), new DateTime(2019, 7, 17, 6, 49, 59, 221, DateTimeKind.Utc).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Registry.GroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 220, DateTimeKind.Utc).AddTicks(9624), new DateTime(2019, 7, 17, 6, 49, 59, 220, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Registry.Registries",
                keyColumn: "Id",
                keyValue: new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(342), new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Registry.Registries",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 219, DateTimeKind.Utc).AddTicks(8112), new DateTime(2019, 7, 17, 6, 49, 59, 219, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Registry.UserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(4524), new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Registry.UserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(3601), new DateTime(2019, 7, 17, 6, 49, 59, 222, DateTimeKind.Utc).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Registry.UserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 220, DateTimeKind.Utc).AddTicks(7623), new DateTime(2019, 7, 17, 6, 49, 59, 220, DateTimeKind.Utc).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "Registry.UserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 220, DateTimeKind.Utc).AddTicks(5011), new DateTime(2019, 7, 17, 6, 49, 59, 220, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 96, DateTimeKind.Utc).AddTicks(3357), new DateTime(2019, 7, 17, 6, 49, 59, 96, DateTimeKind.Utc).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 96, DateTimeKind.Utc).AddTicks(3365), new DateTime(2019, 7, 17, 6, 49, 59, 96, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 96, DateTimeKind.Utc).AddTicks(3372), new DateTime(2019, 7, 17, 6, 49, 59, 96, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 96, DateTimeKind.Utc).AddTicks(3329), new DateTime(2019, 7, 17, 6, 49, 59, 96, DateTimeKind.Utc).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 95, DateTimeKind.Utc).AddTicks(276), new DateTime(2019, 7, 17, 6, 49, 59, 95, DateTimeKind.Utc).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 95, DateTimeKind.Utc).AddTicks(284), new DateTime(2019, 7, 17, 6, 49, 59, 95, DateTimeKind.Utc).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 95, DateTimeKind.Utc).AddTicks(242), new DateTime(2019, 7, 17, 6, 49, 59, 95, DateTimeKind.Utc).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 82, DateTimeKind.Utc).AddTicks(210), new DateTime(2019, 7, 17, 6, 49, 59, 82, DateTimeKind.Utc).AddTicks(215), new Guid("03ca20ef-701b-4f57-a38d-9f7d41a8289b") });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 82, DateTimeKind.Utc).AddTicks(238), new DateTime(2019, 7, 17, 6, 49, 59, 82, DateTimeKind.Utc).AddTicks(240), new Guid("afb96b63-fa14-4bb8-b8b1-0f3106ec7c49") });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 81, DateTimeKind.Utc).AddTicks(9368), new DateTime(2019, 7, 17, 6, 49, 59, 81, DateTimeKind.Utc).AddTicks(9385), new Guid("9e91ecdb-241f-4f29-94fd-fcb801de27d9") });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 93, DateTimeKind.Utc).AddTicks(1987), new DateTime(2019, 7, 17, 6, 49, 59, 93, DateTimeKind.Utc).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 93, DateTimeKind.Utc).AddTicks(2037), new DateTime(2019, 7, 17, 6, 49, 59, 93, DateTimeKind.Utc).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 93, DateTimeKind.Utc).AddTicks(4072), new DateTime(2019, 7, 17, 6, 49, 59, 93, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 93, DateTimeKind.Utc).AddTicks(4108), new DateTime(2019, 7, 17, 6, 49, 59, 93, DateTimeKind.Utc).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 92, DateTimeKind.Utc).AddTicks(5181), new DateTime(2019, 7, 17, 6, 49, 59, 92, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 92, DateTimeKind.Utc).AddTicks(9067), new DateTime(2019, 7, 17, 6, 49, 59, 92, DateTimeKind.Utc).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 92, DateTimeKind.Utc).AddTicks(9723), new DateTime(2019, 7, 17, 6, 49, 59, 92, DateTimeKind.Utc).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 92, DateTimeKind.Utc).AddTicks(8339), new DateTime(2019, 7, 17, 6, 49, 59, 92, DateTimeKind.Utc).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 89, DateTimeKind.Utc).AddTicks(4627), new DateTime(2019, 7, 17, 6, 49, 59, 89, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 89, DateTimeKind.Utc).AddTicks(5919), new DateTime(2019, 7, 17, 6, 49, 59, 89, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 89, DateTimeKind.Utc).AddTicks(2322), new DateTime(2019, 7, 17, 6, 49, 59, 89, DateTimeKind.Utc).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 89, DateTimeKind.Utc).AddTicks(3078), new DateTime(2019, 7, 17, 6, 49, 59, 89, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 17, 6, 49, 59, 88, DateTimeKind.Utc).AddTicks(9288), new DateTime(2019, 7, 17, 6, 49, 59, 88, DateTimeKind.Utc).AddTicks(9303) });

            migrationBuilder.AddForeignKey(
                name: "FK_Registry.GroupPermissions_Registry.Registries_ObjectId",
                table: "Registry.GroupPermissions",
                column: "ObjectId",
                principalTable: "Registry.Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registry.GroupPermissions__.Groups_SubjectId",
                table: "Registry.GroupPermissions",
                column: "SubjectId",
                principalTable: "_.Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Registry.UserPermissions_Registry.Registries_ObjectId",
                table: "Registry.UserPermissions",
                column: "ObjectId",
                principalTable: "Registry.Registries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registry.UserPermissions__.Users_SubjectId",
                table: "Registry.UserPermissions",
                column: "SubjectId",
                principalTable: "_.Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
