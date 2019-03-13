using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v0706 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ReferrerId",
                table: "CrmInvites",
                nullable: false,
                defaultValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                oldClrType: typeof(Guid));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ReferrerId",
                table: "CrmInvites",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));
        }
    }
}
