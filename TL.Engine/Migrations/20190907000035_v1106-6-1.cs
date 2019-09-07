using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v110661 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registry.FilesGroupPermissions");

            migrationBuilder.DropTable(
                name: "Registry.FilesRolePermissions");

            migrationBuilder.DropTable(
                name: "Registry.FilesUserPermissions");

            migrationBuilder.DropTable(
                name: "Registry.FoldersGroupPermissions");

            migrationBuilder.DropTable(
                name: "Registry.FoldersRolePermissions");

            migrationBuilder.DropTable(
                name: "Registry.FoldersUserPermissions");

            migrationBuilder.DropTable(
                name: "Registry.RegistriesGroupPermissions");

            migrationBuilder.DropTable(
                name: "Registry.RegistriesRolePermissions");

            migrationBuilder.DropTable(
                name: "Registry.RegistriesUserPermissions");

            migrationBuilder.CreateTable(
                name: "_.Permissions",
                columns: table => new
                {
                    SubjectId = table.Column<byte[]>(nullable: false),
                    ObjectId = table.Column<byte[]>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__.Permissions", x => new { x.SubjectId, x.ObjectId });
                });

            migrationBuilder.InsertData(
                table: "_.Permissions",
                columns: new[] { "SubjectId", "ObjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 32, 120, 107, 4, 142, 132, 164, 74, 133, 105, 109, 46, 148, 201, 9, 179, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 254, 69, 198, 160, 57, 98, 6, 79, 133, 17, 174, 182, 218, 81, 134, 244, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 171, 236, 115, 44, 129, 186, 144, 70, 169, 110, 57, 152, 104, 80, 164, 122, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 62, 128, 68, 255, 152, 233, 31, 69, 133, 7, 209, 236, 191, 203, 207, 121, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 184, 7, 130, 153, 138, 241, 8, 69, 164, 21, 15, 182, 209, 110, 22, 21, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 62, 128, 68, 255, 152, 233, 31, 69, 133, 7, 209, 236, 191, 203, 207, 121, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 136, 21, 230, 23, 62, 50, 234, 73, 142, 223, 215, 122, 5, 157, 112, 235, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 193, 188, 74, 177, 167, 57, 32, 68, 172, 112, 43, 24, 237, 115, 225, 70, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 32, 120, 107, 4, 142, 132, 164, 74, 133, 105, 109, 46, 148, 201, 9, 179, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 193, 188, 74, 177, 167, 57, 32, 68, 172, 112, 43, 24, 237, 115, 225, 70, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 171, 236, 115, 44, 129, 186, 144, 70, 169, 110, 57, 152, 104, 80, 164, 122, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 193, 188, 74, 177, 167, 57, 32, 68, 172, 112, 43, 24, 237, 115, 225, 70, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 184, 7, 130, 153, 138, 241, 8, 69, 164, 21, 15, 182, 209, 110, 22, 21, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 193, 188, 74, 177, 167, 57, 32, 68, 172, 112, 43, 24, 237, 115, 225, 70, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 91, 128, 104, 107, 69, 18, 71, 79, 178, 233, 93, 58, 220, 104, 119, 152, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 254, 69, 198, 160, 57, 98, 6, 79, 133, 17, 174, 182, 218, 81, 134, 244, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 227, 231, 45, 242, 187, 174, 222, 75, 132, 91, 103, 2, 164, 169, 38, 130, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 254, 69, 198, 160, 57, 98, 6, 79, 133, 17, 174, 182, 218, 81, 134, 244, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 136, 21, 230, 23, 62, 50, 234, 73, 142, 223, 215, 122, 5, 157, 112, 235, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 254, 69, 198, 160, 57, 98, 6, 79, 133, 17, 174, 182, 218, 81, 134, 244, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 32, 120, 107, 4, 142, 132, 164, 74, 133, 105, 109, 46, 148, 201, 9, 179, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 62, 128, 68, 255, 152, 233, 31, 69, 133, 7, 209, 236, 191, 203, 207, 121, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 136, 21, 230, 23, 62, 50, 234, 73, 142, 223, 215, 122, 5, 157, 112, 235, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 62, 128, 68, 255, 152, 233, 31, 69, 133, 7, 209, 236, 191, 203, 207, 121, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 184, 7, 130, 153, 138, 241, 8, 69, 164, 21, 15, 182, 209, 110, 22, 21, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 254, 69, 198, 160, 57, 98, 6, 79, 133, 17, 174, 182, 218, 81, 134, 244, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 91, 128, 104, 107, 69, 18, 71, 79, 178, 233, 93, 58, 220, 104, 119, 152, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 207, 117, 12, 91, 165, 226, 40, 64, 175, 180, 242, 101, 178, 157, 27, 236, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 227, 231, 45, 242, 187, 174, 222, 75, 132, 91, 103, 2, 164, 169, 38, 130, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 207, 117, 12, 91, 165, 226, 40, 64, 175, 180, 242, 101, 178, 157, 27, 236, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 136, 21, 230, 23, 62, 50, 234, 73, 142, 223, 215, 122, 5, 157, 112, 235, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 207, 117, 12, 91, 165, 226, 40, 64, 175, 180, 242, 101, 178, 157, 27, 236, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 32, 120, 107, 4, 142, 132, 164, 74, 133, 105, 109, 46, 148, 201, 9, 179, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 207, 117, 12, 91, 165, 226, 40, 64, 175, 180, 242, 101, 178, 157, 27, 236, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 171, 236, 115, 44, 129, 186, 144, 70, 169, 110, 57, 152, 104, 80, 164, 122, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 207, 117, 12, 91, 165, 226, 40, 64, 175, 180, 242, 101, 178, 157, 27, 236, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 184, 7, 130, 153, 138, 241, 8, 69, 164, 21, 15, 182, 209, 110, 22, 21, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 207, 117, 12, 91, 165, 226, 40, 64, 175, 180, 242, 101, 178, 157, 27, 236, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 171, 236, 115, 44, 129, 186, 144, 70, 169, 110, 57, 152, 104, 80, 164, 122, 11 }, new byte[] { 0, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 4, 1, 0, 0, 0, 11, 83, 121, 115, 116, 101, 109, 46, 71, 117, 105, 100, 11, 0, 0, 0, 2, 95, 97, 2, 95, 98, 2, 95, 99, 2, 95, 100, 2, 95, 101, 2, 95, 102, 2, 95, 103, 2, 95, 104, 2, 95, 105, 2, 95, 106, 2, 95, 107, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 7, 7, 2, 2, 2, 2, 2, 2, 2, 2, 254, 69, 198, 160, 57, 98, 6, 79, 133, 17, 174, 182, 218, 81, 134, 244, 11 }, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"),
                column: "WebTicket",
                value: new Guid("6a51bd6d-3aa3-4bc2-aa5d-46ad66b4e9ca"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("544c8d71-91ba-44f4-81c6-63fee3c50b9f"),
                column: "WebTicket",
                value: new Guid("c420a6fb-e40d-41a1-b157-f414a1b61779"));

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"),
                column: "WebTicket",
                value: new Guid("ec2d67a4-1b41-4590-b75b-70c0fbe5e382"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_.Permissions");

            migrationBuilder.CreateTable(
                name: "Registry.FilesGroupPermissions",
                columns: table => new
                {
                    ObjectId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Mode = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.FilesGroupPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.FilesGroupPermissions_Registry.Files_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.FilesGroupPermissions__.Groups_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.FilesRolePermissions",
                columns: table => new
                {
                    ObjectId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Mode = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.FilesRolePermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.FilesRolePermissions_Registry.Files_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.FilesRolePermissions__.Roles_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.FilesUserPermissions",
                columns: table => new
                {
                    ObjectId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Mode = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.FilesUserPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.FilesUserPermissions_Registry.Files_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.FilesUserPermissions__.Users_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.FoldersGroupPermissions",
                columns: table => new
                {
                    ObjectId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Mode = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.FoldersGroupPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.FoldersGroupPermissions_Registry.Folders_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.FoldersGroupPermissions__.Groups_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.FoldersRolePermissions",
                columns: table => new
                {
                    ObjectId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Mode = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.FoldersRolePermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.FoldersRolePermissions_Registry.Folders_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.FoldersRolePermissions__.Roles_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.FoldersUserPermissions",
                columns: table => new
                {
                    ObjectId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Mode = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.FoldersUserPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.FoldersUserPermissions_Registry.Folders_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.FoldersUserPermissions__.Users_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.RegistriesGroupPermissions",
                columns: table => new
                {
                    ObjectId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Mode = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.RegistriesGroupPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.RegistriesGroupPermissions_Registry.Registries_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Registries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.RegistriesGroupPermissions__.Groups_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.RegistriesRolePermissions",
                columns: table => new
                {
                    ObjectId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Mode = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.RegistriesRolePermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.RegistriesRolePermissions_Registry.Registries_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Registries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.RegistriesRolePermissions__.Roles_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registry.RegistriesUserPermissions",
                columns: table => new
                {
                    ObjectId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Mode = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registry.RegistriesUserPermissions", x => new { x.ObjectId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Registry.RegistriesUserPermissions_Registry.Registries_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Registry.Registries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registry.RegistriesUserPermissions__.Users_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "_.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Registry.FoldersGroupPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.FoldersRolePermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new Guid("f22de7e3-aebb-4bde-845b-6702a4a92682"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.FoldersUserPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a0c645fe-6239-4f06-8511-aeb6da5186f4"), new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ff44803e-e998-451f-8507-d1ecbfcbcf79"), new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.RegistriesGroupPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("046b7820-848e-4aa4-8569-6d2e94c909b3"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("17e61588-323e-49ea-8edf-d77a059d70eb"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.RegistriesRolePermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new Guid("6b68805b-1245-4f47-b2e9-5d3adc687798"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new Guid("f22de7e3-aebb-4bde-845b-6702a4a92682"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Registry.RegistriesUserPermissions",
                columns: new[] { "ObjectId", "SubjectId", "CreationDate", "IsDeleted", "Mode", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("2c73ecab-ba81-4690-a96e-39986850a47a"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b14abcc1-39a7-4420-ac70-2b18ed73e146"), new Guid("998207b8-f18a-4508-a415-0fb6d16e1615"), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 7, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
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

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FilesGroupPermissions_SubjectId",
                table: "Registry.FilesGroupPermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FilesRolePermissions_SubjectId",
                table: "Registry.FilesRolePermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FilesUserPermissions_SubjectId",
                table: "Registry.FilesUserPermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FoldersGroupPermissions_SubjectId",
                table: "Registry.FoldersGroupPermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FoldersRolePermissions_SubjectId",
                table: "Registry.FoldersRolePermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.FoldersUserPermissions_SubjectId",
                table: "Registry.FoldersUserPermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.RegistriesGroupPermissions_SubjectId",
                table: "Registry.RegistriesGroupPermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.RegistriesRolePermissions_SubjectId",
                table: "Registry.RegistriesRolePermissions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Registry.RegistriesUserPermissions_SubjectId",
                table: "Registry.RegistriesUserPermissions",
                column: "SubjectId");
        }
    }
}
