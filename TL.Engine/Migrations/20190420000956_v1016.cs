using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v1016 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkerLinks");

            migrationBuilder.UpdateData(
                table: "AccountSubscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 699, DateTimeKind.Utc).AddTicks(9817), new DateTime(2019, 4, 20, 0, 9, 52, 699, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "AccountSubscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 699, DateTimeKind.Utc).AddTicks(7536), new DateTime(2019, 4, 20, 0, 9, 52, 699, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 737, DateTimeKind.Utc).AddTicks(2674), new DateTime(2019, 4, 20, 0, 9, 52, 737, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 737, DateTimeKind.Utc).AddTicks(1750), new DateTime(2019, 4, 20, 0, 9, 52, 737, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 737, DateTimeKind.Utc).AddTicks(3711), new DateTime(2019, 4, 20, 0, 9, 52, 737, DateTimeKind.Utc).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 736, DateTimeKind.Utc).AddTicks(9218), new DateTime(2019, 4, 20, 0, 9, 52, 736, DateTimeKind.Utc).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 683, DateTimeKind.Utc).AddTicks(9882), new DateTime(2019, 4, 20, 0, 9, 52, 683, DateTimeKind.Utc).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 683, DateTimeKind.Utc).AddTicks(9891), new DateTime(2019, 4, 20, 0, 9, 52, 683, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 683, DateTimeKind.Utc).AddTicks(9898), new DateTime(2019, 4, 20, 0, 9, 52, 683, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 683, DateTimeKind.Utc).AddTicks(9856), new DateTime(2019, 4, 20, 0, 9, 52, 683, DateTimeKind.Utc).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "_Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 682, DateTimeKind.Utc).AddTicks(4094), new DateTime(2019, 4, 20, 0, 9, 52, 682, DateTimeKind.Utc).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "_Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 682, DateTimeKind.Utc).AddTicks(4103), new DateTime(2019, 4, 20, 0, 9, 52, 682, DateTimeKind.Utc).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "_Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 682, DateTimeKind.Utc).AddTicks(4067), new DateTime(2019, 4, 20, 0, 9, 52, 682, DateTimeKind.Utc).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "_Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 672, DateTimeKind.Utc).AddTicks(6781), new DateTime(2019, 4, 20, 0, 9, 52, 672, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "_Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 672, DateTimeKind.Utc).AddTicks(6822), new DateTime(2019, 4, 20, 0, 9, 52, 672, DateTimeKind.Utc).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "_Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 672, DateTimeKind.Utc).AddTicks(5714), new DateTime(2019, 4, 20, 0, 9, 52, 672, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(4792), new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(4848), new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(7076), new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(7118), new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 679, DateTimeKind.Utc).AddTicks(6279), new DateTime(2019, 4, 20, 0, 9, 52, 679, DateTimeKind.Utc).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(1120), new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(1981), new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(176), new DateTime(2019, 4, 20, 0, 9, 52, 680, DateTimeKind.Utc).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 676, DateTimeKind.Utc).AddTicks(7105), new DateTime(2019, 4, 20, 0, 9, 52, 676, DateTimeKind.Utc).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 676, DateTimeKind.Utc).AddTicks(8601), new DateTime(2019, 4, 20, 0, 9, 52, 676, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 676, DateTimeKind.Utc).AddTicks(4150), new DateTime(2019, 4, 20, 0, 9, 52, 676, DateTimeKind.Utc).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 676, DateTimeKind.Utc).AddTicks(5113), new DateTime(2019, 4, 20, 0, 9, 52, 676, DateTimeKind.Utc).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 9, 52, 676, DateTimeKind.Utc).AddTicks(46), new DateTime(2019, 4, 20, 0, 9, 52, 676, DateTimeKind.Utc).AddTicks(60) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LinkerLinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkerLinks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AccountSubscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 705, DateTimeKind.Utc).AddTicks(795), new DateTime(2019, 4, 11, 16, 20, 6, 705, DateTimeKind.Utc).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "AccountSubscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 704, DateTimeKind.Utc).AddTicks(8526), new DateTime(2019, 4, 11, 16, 20, 6, 704, DateTimeKind.Utc).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 741, DateTimeKind.Utc).AddTicks(5713), new DateTime(2019, 4, 11, 16, 20, 6, 741, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 741, DateTimeKind.Utc).AddTicks(4800), new DateTime(2019, 4, 11, 16, 20, 6, 741, DateTimeKind.Utc).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 741, DateTimeKind.Utc).AddTicks(6711), new DateTime(2019, 4, 11, 16, 20, 6, 741, DateTimeKind.Utc).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 741, DateTimeKind.Utc).AddTicks(2263), new DateTime(2019, 4, 11, 16, 20, 6, 741, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 687, DateTimeKind.Utc).AddTicks(4435), new DateTime(2019, 4, 11, 16, 20, 6, 687, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 687, DateTimeKind.Utc).AddTicks(4447), new DateTime(2019, 4, 11, 16, 20, 6, 687, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 687, DateTimeKind.Utc).AddTicks(4456), new DateTime(2019, 4, 11, 16, 20, 6, 687, DateTimeKind.Utc).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 687, DateTimeKind.Utc).AddTicks(4384), new DateTime(2019, 4, 11, 16, 20, 6, 687, DateTimeKind.Utc).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "_Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 685, DateTimeKind.Utc).AddTicks(3479), new DateTime(2019, 4, 11, 16, 20, 6, 685, DateTimeKind.Utc).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "_Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 685, DateTimeKind.Utc).AddTicks(3489), new DateTime(2019, 4, 11, 16, 20, 6, 685, DateTimeKind.Utc).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "_Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 685, DateTimeKind.Utc).AddTicks(3425), new DateTime(2019, 4, 11, 16, 20, 6, 685, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "_Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 673, DateTimeKind.Utc).AddTicks(7802), new DateTime(2019, 4, 11, 16, 20, 6, 673, DateTimeKind.Utc).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "_Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 673, DateTimeKind.Utc).AddTicks(7845), new DateTime(2019, 4, 11, 16, 20, 6, 673, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "_Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 673, DateTimeKind.Utc).AddTicks(6606), new DateTime(2019, 4, 11, 16, 20, 6, 673, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 682, DateTimeKind.Utc).AddTicks(8553), new DateTime(2019, 4, 11, 16, 20, 6, 682, DateTimeKind.Utc).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 682, DateTimeKind.Utc).AddTicks(8748), new DateTime(2019, 4, 11, 16, 20, 6, 682, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 683, DateTimeKind.Utc).AddTicks(1820), new DateTime(2019, 4, 11, 16, 20, 6, 683, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 683, DateTimeKind.Utc).AddTicks(1871), new DateTime(2019, 4, 11, 16, 20, 6, 683, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 681, DateTimeKind.Utc).AddTicks(7563), new DateTime(2019, 4, 11, 16, 20, 6, 681, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 682, DateTimeKind.Utc).AddTicks(3117), new DateTime(2019, 4, 11, 16, 20, 6, 682, DateTimeKind.Utc).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 682, DateTimeKind.Utc).AddTicks(4169), new DateTime(2019, 4, 11, 16, 20, 6, 682, DateTimeKind.Utc).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 682, DateTimeKind.Utc).AddTicks(1924), new DateTime(2019, 4, 11, 16, 20, 6, 682, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 678, DateTimeKind.Utc).AddTicks(3890), new DateTime(2019, 4, 11, 16, 20, 6, 678, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 678, DateTimeKind.Utc).AddTicks(5737), new DateTime(2019, 4, 11, 16, 20, 6, 678, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 678, DateTimeKind.Utc).AddTicks(970), new DateTime(2019, 4, 11, 16, 20, 6, 678, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 678, DateTimeKind.Utc).AddTicks(1925), new DateTime(2019, 4, 11, 16, 20, 6, 678, DateTimeKind.Utc).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 11, 16, 20, 6, 677, DateTimeKind.Utc).AddTicks(6969), new DateTime(2019, 4, 11, 16, 20, 6, 677, DateTimeKind.Utc).AddTicks(6991) });

            migrationBuilder.CreateIndex(
                name: "IX_LinkerLinks_Url",
                table: "LinkerLinks",
                column: "Url",
                unique: true,
                filter: "[Url] IS NOT NULL");
        }
    }
}
