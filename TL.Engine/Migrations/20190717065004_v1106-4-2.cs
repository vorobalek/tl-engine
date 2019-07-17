using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v110642 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Registry.Folders",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 218, DateTimeKind.Utc).AddTicks(1518), new DateTime(2019, 7, 16, 23, 28, 43, 218, DateTimeKind.Utc).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Registry.Folders",
                keyColumn: "Id",
                keyValue: new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(3786), new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(8493), new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(7385), new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(4219), new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersGroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(3102), new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(5422), new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(4142), new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(1920), new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Registry.FoldersUserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(828), new DateTime(2019, 7, 16, 23, 28, 43, 230, DateTimeKind.Utc).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "Registry.GroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(9493), new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Registry.GroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(8342), new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Registry.GroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(2163), new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Registry.GroupPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(912), new DateTime(2019, 7, 16, 23, 28, 43, 219, DateTimeKind.Utc).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Registry.Registries",
                keyColumn: "Id",
                keyValue: new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 220, DateTimeKind.Utc).AddTicks(5322), new DateTime(2019, 7, 16, 23, 28, 43, 220, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Registry.Registries",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 217, DateTimeKind.Utc).AddTicks(4771), new DateTime(2019, 7, 16, 23, 28, 43, 217, DateTimeKind.Utc).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Registry.UserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(6870), new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "Registry.UserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(5503), new DateTime(2019, 7, 16, 23, 28, 43, 229, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Registry.UserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 218, DateTimeKind.Utc).AddTicks(8017), new DateTime(2019, 7, 16, 23, 28, 43, 218, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Registry.UserPermissions",
                keyColumns: new[] { "ObjectId", "SubjectId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 7, 16, 23, 28, 43, 218, DateTimeKind.Utc).AddTicks(4503), new DateTime(2019, 7, 16, 23, 28, 43, 218, DateTimeKind.Utc).AddTicks(4512) });

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
        }
    }
}
