using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v1015 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LinkerLinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkerLinks");

            migrationBuilder.UpdateData(
                table: "AccountSubscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 851, DateTimeKind.Utc).AddTicks(6032), new DateTime(2019, 4, 5, 23, 1, 2, 851, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "AccountSubscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 849, DateTimeKind.Utc).AddTicks(3180), new DateTime(2019, 4, 5, 23, 1, 2, 850, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 926, DateTimeKind.Utc).AddTicks(9450), new DateTime(2019, 4, 5, 23, 1, 2, 926, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 926, DateTimeKind.Utc).AddTicks(8570), new DateTime(2019, 4, 5, 23, 1, 2, 926, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 927, DateTimeKind.Utc).AddTicks(272), new DateTime(2019, 4, 5, 23, 1, 2, 927, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "IntegrationsTgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 926, DateTimeKind.Utc).AddTicks(6061), new DateTime(2019, 4, 5, 23, 1, 2, 926, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9636), new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9645), new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9653), new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "_Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9609), new DateTime(2019, 4, 5, 23, 1, 2, 890, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "_Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 889, DateTimeKind.Utc).AddTicks(4342), new DateTime(2019, 4, 5, 23, 1, 2, 889, DateTimeKind.Utc).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "_Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 889, DateTimeKind.Utc).AddTicks(4352), new DateTime(2019, 4, 5, 23, 1, 2, 889, DateTimeKind.Utc).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "_Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 889, DateTimeKind.Utc).AddTicks(4313), new DateTime(2019, 4, 5, 23, 1, 2, 889, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "_Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 880, DateTimeKind.Utc).AddTicks(2330), new DateTime(2019, 4, 5, 23, 1, 2, 880, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "_Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 880, DateTimeKind.Utc).AddTicks(2340), new DateTime(2019, 4, 5, 23, 1, 2, 880, DateTimeKind.Utc).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "_Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 880, DateTimeKind.Utc).AddTicks(2268), new DateTime(2019, 4, 5, 23, 1, 2, 880, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(5086), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(5184), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(7392), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(7432), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 886, DateTimeKind.Utc).AddTicks(6674), new DateTime(2019, 4, 5, 23, 1, 2, 886, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(1587), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(2442), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "_UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(590), new DateTime(2019, 4, 5, 23, 1, 2, 887, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(7350), new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(9000), new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(3914), new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(5030), new DateTime(2019, 4, 5, 23, 1, 2, 883, DateTimeKind.Utc).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "_UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 4, 5, 23, 1, 2, 882, DateTimeKind.Utc).AddTicks(7765), new DateTime(2019, 4, 5, 23, 1, 2, 882, DateTimeKind.Utc).AddTicks(7785) });
        }
    }
}
