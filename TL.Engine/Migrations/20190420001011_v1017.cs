using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v1017 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LinkerLinks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Identifier = table.Column<decimal>(nullable: false),
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
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 357, DateTimeKind.Utc).AddTicks(7255), new DateTime(2019, 4, 20, 0, 10, 11, 357, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "AccountSubscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 357, DateTimeKind.Utc).AddTicks(4961), new DateTime(2019, 4, 20, 0, 10, 11, 357, DateTimeKind.Utc).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 393, DateTimeKind.Utc).AddTicks(2959), new DateTime(2019, 4, 20, 0, 10, 11, 393, DateTimeKind.Utc).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 393, DateTimeKind.Utc).AddTicks(2072), new DateTime(2019, 4, 20, 0, 10, 11, 393, DateTimeKind.Utc).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 393, DateTimeKind.Utc).AddTicks(3795), new DateTime(2019, 4, 20, 0, 10, 11, 393, DateTimeKind.Utc).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 392, DateTimeKind.Utc).AddTicks(9472), new DateTime(2019, 4, 20, 0, 10, 11, 392, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 341, DateTimeKind.Utc).AddTicks(2683), new DateTime(2019, 4, 20, 0, 10, 11, 341, DateTimeKind.Utc).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 341, DateTimeKind.Utc).AddTicks(2692), new DateTime(2019, 4, 20, 0, 10, 11, 341, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 341, DateTimeKind.Utc).AddTicks(2699), new DateTime(2019, 4, 20, 0, 10, 11, 341, DateTimeKind.Utc).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 341, DateTimeKind.Utc).AddTicks(2643), new DateTime(2019, 4, 20, 0, 10, 11, 341, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "_Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 339, DateTimeKind.Utc).AddTicks(5704), new DateTime(2019, 4, 20, 0, 10, 11, 339, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "_Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 339, DateTimeKind.Utc).AddTicks(5712), new DateTime(2019, 4, 20, 0, 10, 11, 339, DateTimeKind.Utc).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "_Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 339, DateTimeKind.Utc).AddTicks(5656), new DateTime(2019, 4, 20, 0, 10, 11, 339, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "_Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 329, DateTimeKind.Utc).AddTicks(89), new DateTime(2019, 4, 20, 0, 10, 11, 329, DateTimeKind.Utc).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "_Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 329, DateTimeKind.Utc).AddTicks(129), new DateTime(2019, 4, 20, 0, 10, 11, 329, DateTimeKind.Utc).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "_Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 328, DateTimeKind.Utc).AddTicks(9001), new DateTime(2019, 4, 20, 0, 10, 11, 328, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 337, DateTimeKind.Utc).AddTicks(3813), new DateTime(2019, 4, 20, 0, 10, 11, 337, DateTimeKind.Utc).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 337, DateTimeKind.Utc).AddTicks(3869), new DateTime(2019, 4, 20, 0, 10, 11, 337, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 337, DateTimeKind.Utc).AddTicks(6153), new DateTime(2019, 4, 20, 0, 10, 11, 337, DateTimeKind.Utc).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 337, DateTimeKind.Utc).AddTicks(6195), new DateTime(2019, 4, 20, 0, 10, 11, 337, DateTimeKind.Utc).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 336, DateTimeKind.Utc).AddTicks(4930), new DateTime(2019, 4, 20, 0, 10, 11, 336, DateTimeKind.Utc).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 337, DateTimeKind.Utc).AddTicks(134), new DateTime(2019, 4, 20, 0, 10, 11, 337, DateTimeKind.Utc).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 337, DateTimeKind.Utc).AddTicks(1006), new DateTime(2019, 4, 20, 0, 10, 11, 337, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 336, DateTimeKind.Utc).AddTicks(9159), new DateTime(2019, 4, 20, 0, 10, 11, 336, DateTimeKind.Utc).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 333, DateTimeKind.Utc).AddTicks(3969), new DateTime(2019, 4, 20, 0, 10, 11, 333, DateTimeKind.Utc).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 333, DateTimeKind.Utc).AddTicks(5518), new DateTime(2019, 4, 20, 0, 10, 11, 333, DateTimeKind.Utc).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 333, DateTimeKind.Utc).AddTicks(939), new DateTime(2019, 4, 20, 0, 10, 11, 333, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 333, DateTimeKind.Utc).AddTicks(1898), new DateTime(2019, 4, 20, 0, 10, 11, 333, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 20, 0, 10, 11, 332, DateTimeKind.Utc).AddTicks(6770), new DateTime(2019, 4, 20, 0, 10, 11, 332, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.CreateIndex(
                name: "IX_LinkerLinks_Identifier",
                table: "LinkerLinks",
                column: "Identifier",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LinkerLinks_Url",
                table: "LinkerLinks",
                column: "Url",
                unique: true,
                filter: "[Url] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
