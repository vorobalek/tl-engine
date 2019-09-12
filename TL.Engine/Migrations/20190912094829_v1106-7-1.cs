using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v110671 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JustBot.Person",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JustBot.Person", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"),
                column: "WebTicket",
                value: new Guid("76656e80-32fd-4bc1-a1fc-1a05370517c4"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"),
                column: "WebTicket",
                value: new Guid("9e7d9c19-5b87-4783-b612-be07be455b39"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"),
                column: "WebTicket",
                value: new Guid("de20e5f5-7f06-4d80-960d-7a44ef48915c"));

            migrationBuilder.CreateIndex(
                name: "IX_JustBot.Person_Token",
                table: "JustBot.Person",
                column: "Token",
                unique: true,
                filter: "[Token] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JustBot.Person");

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"),
                column: "WebTicket",
                value: new Guid("5d2c3ae8-316e-46f3-87ae-514c43289eb2"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"),
                column: "WebTicket",
                value: new Guid("6431c010-1aa0-4f90-acf5-9ab75611ea0d"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"),
                column: "WebTicket",
                value: new Guid("258e4316-b782-4df5-a3ea-fb39297f3715"));
        }
    }
}
