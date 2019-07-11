using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v11061 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LifetimeSeconds",
                table: "Linker.Links",
                nullable: false,
                defaultValue: 2147483647);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LifetimeSeconds",
                table: "Linker.Links");

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 29, DateTimeKind.Utc).AddTicks(9538), new DateTime(2019, 5, 15, 15, 55, 18, 29, DateTimeKind.Utc).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 29, DateTimeKind.Utc).AddTicks(7090), new DateTime(2019, 5, 15, 15, 55, 18, 29, DateTimeKind.Utc).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(5868), new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(4982), new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(6865), new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(2449), new DateTime(2019, 5, 15, 15, 55, 18, 66, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(5997), new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(6007), new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(6015), new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(5947), new DateTime(2019, 5, 15, 15, 55, 18, 12, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 10, DateTimeKind.Utc).AddTicks(7194), new DateTime(2019, 5, 15, 15, 55, 18, 10, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 10, DateTimeKind.Utc).AddTicks(7204), new DateTime(2019, 5, 15, 15, 55, 18, 10, DateTimeKind.Utc).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 10, DateTimeKind.Utc).AddTicks(7146), new DateTime(2019, 5, 15, 15, 55, 18, 10, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 17, 999, DateTimeKind.Utc).AddTicks(8558), new DateTime(2019, 5, 15, 15, 55, 17, 999, DateTimeKind.Utc).AddTicks(8565), new Guid("46a5e34b-60a0-4920-91d5-0c7e9c65d160") });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 17, 999, DateTimeKind.Utc).AddTicks(8599), new DateTime(2019, 5, 15, 15, 55, 17, 999, DateTimeKind.Utc).AddTicks(8601), new Guid("b03a1e11-5639-4a67-a343-6e118280ddc5") });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate", "WebTicket" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 17, 999, DateTimeKind.Utc).AddTicks(7448), new DateTime(2019, 5, 15, 15, 55, 17, 999, DateTimeKind.Utc).AddTicks(7469), new Guid("150913db-d129-4b02-b7b3-41e713d72630") });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(4436), new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(4503), new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(7091), new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(7157), new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 7, DateTimeKind.Utc).AddTicks(5425), new DateTime(2019, 5, 15, 15, 55, 18, 7, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(838), new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(1717), new DateTime(2019, 5, 15, 15, 55, 18, 8, DateTimeKind.Utc).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 7, DateTimeKind.Utc).AddTicks(9718), new DateTime(2019, 5, 15, 15, 55, 18, 7, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 4, DateTimeKind.Utc).AddTicks(1134), new DateTime(2019, 5, 15, 15, 55, 18, 4, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 4, DateTimeKind.Utc).AddTicks(3363), new DateTime(2019, 5, 15, 15, 55, 18, 4, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 3, DateTimeKind.Utc).AddTicks(7933), new DateTime(2019, 5, 15, 15, 55, 18, 3, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 3, DateTimeKind.Utc).AddTicks(8918), new DateTime(2019, 5, 15, 15, 55, 18, 3, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 15, 15, 55, 18, 3, DateTimeKind.Utc).AddTicks(3706), new DateTime(2019, 5, 15, 15, 55, 18, 3, DateTimeKind.Utc).AddTicks(3727) });
        }
    }
}
