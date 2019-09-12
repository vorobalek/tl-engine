using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v110672 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JustBot.History",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    AuthorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JustBot.History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JustBot.History_JustBot.Person_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "JustBot.Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"),
                column: "WebTicket",
                value: new Guid("defca097-f6b7-4a58-9687-77d874609002"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"),
                column: "WebTicket",
                value: new Guid("87142f1b-16a6-46fb-8f2e-cd12f054ed9c"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"),
                column: "WebTicket",
                value: new Guid("d747c6eb-a55c-4138-a64e-177cbcb65d9c"));

            migrationBuilder.CreateIndex(
                name: "IX_JustBot.History_AuthorId",
                table: "JustBot.History",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JustBot.History");

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
        }
    }
}
