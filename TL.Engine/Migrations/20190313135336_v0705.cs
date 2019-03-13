using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v0705 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeOut",
                table: "CrmInvites",
                nullable: false,
                defaultValue: new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "MaxMembersCount",
                table: "CrmInvites",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeOut",
                table: "CrmInvites",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999));

            migrationBuilder.AlterColumn<int>(
                name: "MaxMembersCount",
                table: "CrmInvites",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 1);
        }
    }
}
