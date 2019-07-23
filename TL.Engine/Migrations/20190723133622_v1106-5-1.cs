using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v110651 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_.Roles",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("59fe43ef-245b-4222-bfba-6b1c9e92c726"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "user_creator" },
                    { new Guid("abaadf2c-137b-433a-87c8-33b437526bd4"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "role_creator" },
                    { new Guid("eaf895bc-9c09-47e3-b539-d8b389323416"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "group_creator" },
                    { new Guid("49b185ee-070d-4831-a614-fe9d6bf509d4"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "registry_folder_creator" },
                    { new Guid("dbd2c97b-db84-4fc3-a3ca-ad0c3953ca35"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "registry_file_creator" }
                });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"),
                column: "WebTicket",
                value: new Guid("3c9f712e-4651-4a92-b73b-038975f32cc6"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"),
                column: "WebTicket",
                value: new Guid("46bbd329-e616-4556-b27f-6ecd35d8c977"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"),
                column: "WebTicket",
                value: new Guid("5527d3fd-3bdd-42c2-aa46-892d1b756f06"));

            migrationBuilder.InsertData(
                table: "_.UsersRoles",
                columns: new[] { "UserId", "RoleId", "CreationDate", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("59fe43ef-245b-4222-bfba-6b1c9e92c726"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("abaadf2c-137b-433a-87c8-33b437526bd4"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("eaf895bc-9c09-47e3-b539-d8b389323416"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("49b185ee-070d-4831-a614-fe9d6bf509d4"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("dbd2c97b-db84-4fc3-a3ca-ad0c3953ca35"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("49b185ee-070d-4831-a614-fe9d6bf509d4") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("59fe43ef-245b-4222-bfba-6b1c9e92c726") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("abaadf2c-137b-433a-87c8-33b437526bd4") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("dbd2c97b-db84-4fc3-a3ca-ad0c3953ca35") });

            migrationBuilder.DeleteData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new Guid("eaf895bc-9c09-47e3-b539-d8b389323416") });

            migrationBuilder.DeleteData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("49b185ee-070d-4831-a614-fe9d6bf509d4"));

            migrationBuilder.DeleteData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("59fe43ef-245b-4222-bfba-6b1c9e92c726"));

            migrationBuilder.DeleteData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("abaadf2c-137b-433a-87c8-33b437526bd4"));

            migrationBuilder.DeleteData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("dbd2c97b-db84-4fc3-a3ca-ad0c3953ca35"));

            migrationBuilder.DeleteData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("eaf895bc-9c09-47e3-b539-d8b389323416"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"),
                column: "WebTicket",
                value: new Guid("9ece7698-85c5-480c-a429-a524040d0a2e"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"),
                column: "WebTicket",
                value: new Guid("ca74fd68-aefb-4139-b7ec-0039901aa0eb"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"),
                column: "WebTicket",
                value: new Guid("83dec367-b296-4734-9609-3c59cb7be6b6"));
        }
    }
}
