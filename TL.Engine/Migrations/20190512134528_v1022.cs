using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v1022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastActivity",
                table: "_.Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 825, DateTimeKind.Utc).AddTicks(3646), new DateTime(2019, 5, 12, 13, 45, 26, 825, DateTimeKind.Utc).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 825, DateTimeKind.Utc).AddTicks(1260), new DateTime(2019, 5, 12, 13, 45, 26, 825, DateTimeKind.Utc).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 859, DateTimeKind.Utc).AddTicks(6749), new DateTime(2019, 5, 12, 13, 45, 26, 859, DateTimeKind.Utc).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 859, DateTimeKind.Utc).AddTicks(5857), new DateTime(2019, 5, 12, 13, 45, 26, 859, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 859, DateTimeKind.Utc).AddTicks(7585), new DateTime(2019, 5, 12, 13, 45, 26, 859, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 859, DateTimeKind.Utc).AddTicks(3421), new DateTime(2019, 5, 12, 13, 45, 26, 859, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 805, DateTimeKind.Utc).AddTicks(1582), new DateTime(2019, 5, 12, 13, 45, 26, 805, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 805, DateTimeKind.Utc).AddTicks(1596), new DateTime(2019, 5, 12, 13, 45, 26, 805, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 805, DateTimeKind.Utc).AddTicks(1606), new DateTime(2019, 5, 12, 13, 45, 26, 805, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 805, DateTimeKind.Utc).AddTicks(1532), new DateTime(2019, 5, 12, 13, 45, 26, 805, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 803, DateTimeKind.Utc).AddTicks(4767), new DateTime(2019, 5, 12, 13, 45, 26, 803, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 803, DateTimeKind.Utc).AddTicks(4777), new DateTime(2019, 5, 12, 13, 45, 26, 803, DateTimeKind.Utc).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 803, DateTimeKind.Utc).AddTicks(4712), new DateTime(2019, 5, 12, 13, 45, 26, 803, DateTimeKind.Utc).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 792, DateTimeKind.Utc).AddTicks(8894), new DateTime(2019, 5, 12, 13, 45, 26, 792, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 792, DateTimeKind.Utc).AddTicks(8935), new DateTime(2019, 5, 12, 13, 45, 26, 792, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 792, DateTimeKind.Utc).AddTicks(7795), new DateTime(2019, 5, 12, 13, 45, 26, 792, DateTimeKind.Utc).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 801, DateTimeKind.Utc).AddTicks(2588), new DateTime(2019, 5, 12, 13, 45, 26, 801, DateTimeKind.Utc).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 801, DateTimeKind.Utc).AddTicks(2646), new DateTime(2019, 5, 12, 13, 45, 26, 801, DateTimeKind.Utc).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 801, DateTimeKind.Utc).AddTicks(5001), new DateTime(2019, 5, 12, 13, 45, 26, 801, DateTimeKind.Utc).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 801, DateTimeKind.Utc).AddTicks(5044), new DateTime(2019, 5, 12, 13, 45, 26, 801, DateTimeKind.Utc).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 800, DateTimeKind.Utc).AddTicks(3450), new DateTime(2019, 5, 12, 13, 45, 26, 800, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 800, DateTimeKind.Utc).AddTicks(8575), new DateTime(2019, 5, 12, 13, 45, 26, 800, DateTimeKind.Utc).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 800, DateTimeKind.Utc).AddTicks(9449), new DateTime(2019, 5, 12, 13, 45, 26, 800, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 800, DateTimeKind.Utc).AddTicks(7601), new DateTime(2019, 5, 12, 13, 45, 26, 800, DateTimeKind.Utc).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 797, DateTimeKind.Utc).AddTicks(980), new DateTime(2019, 5, 12, 13, 45, 26, 797, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 797, DateTimeKind.Utc).AddTicks(2787), new DateTime(2019, 5, 12, 13, 45, 26, 797, DateTimeKind.Utc).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 796, DateTimeKind.Utc).AddTicks(8010), new DateTime(2019, 5, 12, 13, 45, 26, 796, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 796, DateTimeKind.Utc).AddTicks(8967), new DateTime(2019, 5, 12, 13, 45, 26, 796, DateTimeKind.Utc).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 12, 13, 45, 26, 796, DateTimeKind.Utc).AddTicks(3964), new DateTime(2019, 5, 12, 13, 45, 26, 796, DateTimeKind.Utc).AddTicks(3987) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastActivity",
                table: "_.Users");

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
    }
}
