using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v110641 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Registry.Registries",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 94, DateTimeKind.Utc).AddTicks(368), new DateTime(2019, 7, 16, 23, 28, 43, 94, DateTimeKind.Utc).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 93, DateTimeKind.Utc).AddTicks(8402), new DateTime(2019, 7, 16, 23, 28, 43, 93, DateTimeKind.Utc).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 132, DateTimeKind.Utc).AddTicks(3803), new DateTime(2019, 7, 16, 23, 28, 43, 132, DateTimeKind.Utc).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 132, DateTimeKind.Utc).AddTicks(2367), new DateTime(2019, 7, 16, 23, 28, 43, 132, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 132, DateTimeKind.Utc).AddTicks(5319), new DateTime(2019, 7, 16, 23, 28, 43, 132, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 131, DateTimeKind.Utc).AddTicks(9883), new DateTime(2019, 7, 16, 23, 28, 43, 131, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.InsertData(
                table: "Registry.Folders",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name", "OwnerId", "ParantId" },
                values: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 16, 23, 28, 43, 218, DateTimeKind.Utc).AddTicks(1518), false, new DateTime(2019, 7, 16, 23, 28, 43, 218, DateTimeKind.Utc).AddTicks(1524), "System Root Registry Folder", new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), null });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 61, DateTimeKind.Utc).AddTicks(5041), new DateTime(2019, 7, 16, 23, 28, 43, 61, DateTimeKind.Utc).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 61, DateTimeKind.Utc).AddTicks(5050), new DateTime(2019, 7, 16, 23, 28, 43, 61, DateTimeKind.Utc).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 61, DateTimeKind.Utc).AddTicks(5059), new DateTime(2019, 7, 16, 23, 28, 43, 61, DateTimeKind.Utc).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 61, DateTimeKind.Utc).AddTicks(4997), new DateTime(2019, 7, 16, 23, 28, 43, 61, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 59, DateTimeKind.Utc).AddTicks(1025), new DateTime(2019, 7, 16, 23, 28, 43, 59, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 59, DateTimeKind.Utc).AddTicks(1034), new DateTime(2019, 7, 16, 23, 28, 43, 59, DateTimeKind.Utc).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 59, DateTimeKind.Utc).AddTicks(983), new DateTime(2019, 7, 16, 23, 28, 43, 59, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 39, DateTimeKind.Utc).AddTicks(4239), new DateTime(2019, 7, 16, 23, 28, 43, 39, DateTimeKind.Utc).AddTicks(4248), new Guid("6d11210a-5e4c-4ea2-b5df-fa2fbd731d3a") });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 39, DateTimeKind.Utc).AddTicks(4281), new DateTime(2019, 7, 16, 23, 28, 43, 39, DateTimeKind.Utc).AddTicks(4283), new Guid("535e4b0c-9854-4da9-852f-2c75a3170331") });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 39, DateTimeKind.Utc).AddTicks(2413), new DateTime(2019, 7, 16, 23, 28, 43, 39, DateTimeKind.Utc).AddTicks(2435), new Guid("71b6f42d-e2a0-417e-96a1-c5d296f6da29") });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 56, DateTimeKind.Utc).AddTicks(1661), new DateTime(2019, 7, 16, 23, 28, 43, 56, DateTimeKind.Utc).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 56, DateTimeKind.Utc).AddTicks(1724), new DateTime(2019, 7, 16, 23, 28, 43, 56, DateTimeKind.Utc).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 56, DateTimeKind.Utc).AddTicks(5087), new DateTime(2019, 7, 16, 23, 28, 43, 56, DateTimeKind.Utc).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 56, DateTimeKind.Utc).AddTicks(5146), new DateTime(2019, 7, 16, 23, 28, 43, 56, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 55, DateTimeKind.Utc).AddTicks(610), new DateTime(2019, 7, 16, 23, 28, 43, 55, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 55, DateTimeKind.Utc).AddTicks(6032), new DateTime(2019, 7, 16, 23, 28, 43, 55, DateTimeKind.Utc).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 55, DateTimeKind.Utc).AddTicks(7490), new DateTime(2019, 7, 16, 23, 28, 43, 55, DateTimeKind.Utc).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 55, DateTimeKind.Utc).AddTicks(4536), new DateTime(2019, 7, 16, 23, 28, 43, 55, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 50, DateTimeKind.Utc).AddTicks(7922), new DateTime(2019, 7, 16, 23, 28, 43, 50, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 51, DateTimeKind.Utc).AddTicks(328), new DateTime(2019, 7, 16, 23, 28, 43, 51, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 50, DateTimeKind.Utc).AddTicks(3079), new DateTime(2019, 7, 16, 23, 28, 43, 50, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 50, DateTimeKind.Utc).AddTicks(4613), new DateTime(2019, 7, 16, 23, 28, 43, 50, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 49, DateTimeKind.Utc).AddTicks(9280), new DateTime(2019, 7, 16, 23, 28, 43, 49, DateTimeKind.Utc).AddTicks(9301) });

            migrationBuilder.InsertData(
                table: "Registry.Folders",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name", "OwnerId", "ParantId" },
                values: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(3786), false, new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(3810), "Module Store Registry Folder", new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.InsertData(
                table: "Registry.FoldersGroupPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(7385), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(7394) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(8493), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(8501) }
                });

            migrationBuilder.InsertData(
                table: "Registry.FoldersUserPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(4142), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(4150) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(5422), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(5430) }
                });

            migrationBuilder.InsertData(
                table: "Registry.Registries",
                columns: new[] { "Id", "CreationDate", "Description", "IsDeleted", "ModifiedDate", "Name", "OwnerId", "RootId", "Type" },
                values: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 16, 23, 28, 43, 217, DateTimeKind.Utc).AddTicks(4771), "System Root Registry", false, new DateTime(2019, 7, 16, 23, 28, 43, 217, DateTimeKind.Utc).AddTicks(4793), "<Root>", new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), 1 });

            migrationBuilder.InsertData(
                table: "Registry.FoldersGroupPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(3102), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(3110) },
                    { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(4219), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(4226) }
                });

            migrationBuilder.InsertData(
                table: "Registry.FoldersUserPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(828), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(835) },
                    { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(1920), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(1928) }
                });

            migrationBuilder.InsertData(
                table: "Registry.GroupPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(912), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(921) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(2163), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(2171) }
                });

            migrationBuilder.InsertData(
                table: "Registry.Registries",
                columns: new[] { "Id", "CreationDate", "Description", "IsDeleted", "ModifiedDate", "Name", "OwnerId", "RootId", "Type" },
                values: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new DateTime(2019, 7, 16, 23, 28, 43, 220, DateTimeKind.Utc).AddTicks(5322), "Module Store Registry", false, new DateTime(2019, 7, 16, 23, 28, 43, 220, DateTimeKind.Utc).AddTicks(5333), "M-Store", new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), 1 });

            migrationBuilder.InsertData(
                table: "Registry.UserPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 16, 23, 28, 43, 218, DateTimeKind.Utc).AddTicks(4503), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 218, DateTimeKind.Utc).AddTicks(4512) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 16, 23, 28, 43, 218, DateTimeKind.Utc).AddTicks(8017), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 218, DateTimeKind.Utc).AddTicks(8024) }
                });

            migrationBuilder.InsertData(
                table: "Registry.GroupPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(8342), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(8349) },
                    { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(9493), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(9500) }
                });

            migrationBuilder.InsertData(
                table: "Registry.UserPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(5503), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(5510) },
                    { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(6870), false, 7, new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(6878) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") });

            migrationBuilder.DeleteData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") });

            migrationBuilder.DeleteData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") });

            migrationBuilder.DeleteData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") });

            migrationBuilder.DeleteData(
                table: "Registry.GroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "Registry.GroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") });

            migrationBuilder.DeleteData(
                table: "Registry.GroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "Registry.GroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") });

            migrationBuilder.DeleteData(
                table: "Registry.UserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "Registry.UserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") });

            migrationBuilder.DeleteData(
                table: "Registry.UserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.DeleteData(
                table: "Registry.UserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") });

            migrationBuilder.DeleteData(
                table: "Registry.Registries",
                keyColumn: "Id",
                keyValue: new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"));

            migrationBuilder.DeleteData(
                table: "Registry.Registries",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "Registry.Folders",
                keyColumn: "Id",
                keyValue: new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"));

            migrationBuilder.DeleteData(
                table: "Registry.Folders",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Registry.Registries");

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
        }
    }
}
