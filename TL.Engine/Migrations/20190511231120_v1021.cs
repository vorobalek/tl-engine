using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v1021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogon",
                table: "_.Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 213, DateTimeKind.Utc).AddTicks(9506), new DateTime(2019, 5, 11, 23, 11, 18, 213, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 213, DateTimeKind.Utc).AddTicks(6995), new DateTime(2019, 5, 11, 23, 11, 18, 213, DateTimeKind.Utc).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 247, DateTimeKind.Utc).AddTicks(7014), new DateTime(2019, 5, 11, 23, 11, 18, 247, DateTimeKind.Utc).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 247, DateTimeKind.Utc).AddTicks(6118), new DateTime(2019, 5, 11, 23, 11, 18, 247, DateTimeKind.Utc).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 247, DateTimeKind.Utc).AddTicks(7852), new DateTime(2019, 5, 11, 23, 11, 18, 247, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 247, DateTimeKind.Utc).AddTicks(3657), new DateTime(2019, 5, 11, 23, 11, 18, 247, DateTimeKind.Utc).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 197, DateTimeKind.Utc).AddTicks(232), new DateTime(2019, 5, 11, 23, 11, 18, 197, DateTimeKind.Utc).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 197, DateTimeKind.Utc).AddTicks(241), new DateTime(2019, 5, 11, 23, 11, 18, 197, DateTimeKind.Utc).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 197, DateTimeKind.Utc).AddTicks(249), new DateTime(2019, 5, 11, 23, 11, 18, 197, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 197, DateTimeKind.Utc).AddTicks(202), new DateTime(2019, 5, 11, 23, 11, 18, 197, DateTimeKind.Utc).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 195, DateTimeKind.Utc).AddTicks(4730), new DateTime(2019, 5, 11, 23, 11, 18, 195, DateTimeKind.Utc).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 195, DateTimeKind.Utc).AddTicks(4739), new DateTime(2019, 5, 11, 23, 11, 18, 195, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 195, DateTimeKind.Utc).AddTicks(4696), new DateTime(2019, 5, 11, 23, 11, 18, 195, DateTimeKind.Utc).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 184, DateTimeKind.Utc).AddTicks(4391), new DateTime(2019, 5, 11, 23, 11, 18, 184, DateTimeKind.Utc).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 184, DateTimeKind.Utc).AddTicks(4439), new DateTime(2019, 5, 11, 23, 11, 18, 184, DateTimeKind.Utc).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 184, DateTimeKind.Utc).AddTicks(3013), new DateTime(2019, 5, 11, 23, 11, 18, 184, DateTimeKind.Utc).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(5615), new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(5674), new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(7914), new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(7958), new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 192, DateTimeKind.Utc).AddTicks(6822), new DateTime(2019, 5, 11, 23, 11, 18, 192, DateTimeKind.Utc).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(2028), new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(2901), new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(1059), new DateTime(2019, 5, 11, 23, 11, 18, 193, DateTimeKind.Utc).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 189, DateTimeKind.Utc).AddTicks(9382), new DateTime(2019, 5, 11, 23, 11, 18, 189, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 190, DateTimeKind.Utc).AddTicks(922), new DateTime(2019, 5, 11, 23, 11, 18, 190, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 189, DateTimeKind.Utc).AddTicks(6287), new DateTime(2019, 5, 11, 23, 11, 18, 189, DateTimeKind.Utc).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 189, DateTimeKind.Utc).AddTicks(7235), new DateTime(2019, 5, 11, 23, 11, 18, 189, DateTimeKind.Utc).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 23, 11, 18, 189, DateTimeKind.Utc).AddTicks(2216), new DateTime(2019, 5, 11, 23, 11, 18, 189, DateTimeKind.Utc).AddTicks(2242) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastLogon",
                table: "_.Users");

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 86, DateTimeKind.Utc).AddTicks(2633), new DateTime(2019, 5, 11, 10, 54, 45, 86, DateTimeKind.Utc).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 86, DateTimeKind.Utc).AddTicks(172), new DateTime(2019, 5, 11, 10, 54, 45, 86, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(5819), new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(4916), new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(6671), new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(2367), new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(9022), new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(9031), new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(9039), new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(8979), new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 67, DateTimeKind.Utc).AddTicks(939), new DateTime(2019, 5, 11, 10, 54, 45, 67, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 67, DateTimeKind.Utc).AddTicks(948), new DateTime(2019, 5, 11, 10, 54, 45, 67, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 67, DateTimeKind.Utc).AddTicks(885), new DateTime(2019, 5, 11, 10, 54, 45, 67, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 55, DateTimeKind.Utc).AddTicks(7886), new DateTime(2019, 5, 11, 10, 54, 45, 55, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 55, DateTimeKind.Utc).AddTicks(7927), new DateTime(2019, 5, 11, 10, 54, 45, 55, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 55, DateTimeKind.Utc).AddTicks(6816), new DateTime(2019, 5, 11, 10, 54, 45, 55, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(8878), new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(8939), new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 65, DateTimeKind.Utc).AddTicks(1443), new DateTime(2019, 5, 11, 10, 54, 45, 65, DateTimeKind.Utc).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 65, DateTimeKind.Utc).AddTicks(1487), new DateTime(2019, 5, 11, 10, 54, 45, 65, DateTimeKind.Utc).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(87), new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(5279), new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(6146), new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(4302), new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 60, DateTimeKind.Utc).AddTicks(3100), new DateTime(2019, 5, 11, 10, 54, 45, 60, DateTimeKind.Utc).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 60, DateTimeKind.Utc).AddTicks(5058), new DateTime(2019, 5, 11, 10, 54, 45, 60, DateTimeKind.Utc).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 59, DateTimeKind.Utc).AddTicks(8748), new DateTime(2019, 5, 11, 10, 54, 45, 59, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 60, DateTimeKind.Utc).AddTicks(174), new DateTime(2019, 5, 11, 10, 54, 45, 60, DateTimeKind.Utc).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 59, DateTimeKind.Utc).AddTicks(3390), new DateTime(2019, 5, 11, 10, 54, 45, 59, DateTimeKind.Utc).AddTicks(3416) });
        }
    }
}
