using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v1020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Reports__Users_UserId",
                table: "_Reports");

            migrationBuilder.DropForeignKey(
                name: "FK__StaticFiles__Users_AuthorId",
                table: "_StaticFiles");

            migrationBuilder.DropForeignKey(
                name: "FK__StaticFiles__StaticFiles_OriginalId",
                table: "_StaticFiles");

            migrationBuilder.DropForeignKey(
                name: "FK__StringVariables__Users_AuthorId",
                table: "_StringVariables");

            migrationBuilder.DropForeignKey(
                name: "FK__UsersGroups__Groups_GroupId",
                table: "_UsersGroups");

            migrationBuilder.DropForeignKey(
                name: "FK__UsersGroups__Users_UserId",
                table: "_UsersGroups");

            migrationBuilder.DropForeignKey(
                name: "FK__UsersRoles__Roles_RoleId",
                table: "_UsersRoles");

            migrationBuilder.DropForeignKey(
                name: "FK__UsersRoles__Users_UserId",
                table: "_UsersRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountSubscriptions__Users_FromId",
                table: "AccountSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiTokens__Users_OwnerId",
                table: "ApiTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiTokensLogs_ApiTokens_TokenId",
                table: "ApiTokensLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiTokensLogs__Users_UserId",
                table: "ApiTokensLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegrationsTgConnections_IntegrationsTgBots_BotId",
                table: "IntegrationsTgConnections");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegrationsTgConnections_IntegrationsTgUsers_UserId",
                table: "IntegrationsTgConnections");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegrationsTgUsers__Users_UserId",
                table: "IntegrationsTgUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegrationsTgUsersRoles_IntegrationsTgRoles_RoleId",
                table: "IntegrationsTgUsersRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_IntegrationsTgUsersRoles_IntegrationsTgUsers_UserId",
                table: "IntegrationsTgUsersRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LinkerLinks",
                table: "LinkerLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IntegrationsTgUsersRoles",
                table: "IntegrationsTgUsersRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IntegrationsTgUsers",
                table: "IntegrationsTgUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IntegrationsTgRoles",
                table: "IntegrationsTgRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IntegrationsTgConnections",
                table: "IntegrationsTgConnections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IntegrationsTgBots",
                table: "IntegrationsTgBots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiTokensLogs",
                table: "ApiTokensLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiTokens",
                table: "ApiTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountSubscriptions",
                table: "AccountSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK__UsersRoles",
                table: "_UsersRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__UsersGroups",
                table: "_UsersGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Users",
                table: "_Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK__StringVariables",
                table: "_StringVariables");

            migrationBuilder.DropPrimaryKey(
                name: "PK__StaticFiles",
                table: "_StaticFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Roles",
                table: "_Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Reports",
                table: "_Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Groups",
                table: "_Groups");

            migrationBuilder.RenameTable(
                name: "LinkerLinks",
                newName: "Linker.Links");

            migrationBuilder.RenameTable(
                name: "IntegrationsTgUsersRoles",
                newName: "Integrations.TgUsersRoles");

            migrationBuilder.RenameTable(
                name: "IntegrationsTgUsers",
                newName: "Integrations.TgUsers");

            migrationBuilder.RenameTable(
                name: "IntegrationsTgRoles",
                newName: "Integrations.TgRoles");

            migrationBuilder.RenameTable(
                name: "IntegrationsTgConnections",
                newName: "Integrations.TgConnections");

            migrationBuilder.RenameTable(
                name: "IntegrationsTgBots",
                newName: "Integrations.TgBots");

            migrationBuilder.RenameTable(
                name: "ApiTokensLogs",
                newName: "Api.TokensLogs");

            migrationBuilder.RenameTable(
                name: "ApiTokens",
                newName: "Api.Tokens");

            migrationBuilder.RenameTable(
                name: "AccountSubscriptions",
                newName: "Account.Subscriptions");

            migrationBuilder.RenameTable(
                name: "_UsersRoles",
                newName: "_.UsersRoles");

            migrationBuilder.RenameTable(
                name: "_UsersGroups",
                newName: "_.UsersGroups");

            migrationBuilder.RenameTable(
                name: "_Users",
                newName: "_.Users");

            migrationBuilder.RenameTable(
                name: "_StringVariables",
                newName: "_.StringVariables");

            migrationBuilder.RenameTable(
                name: "_StaticFiles",
                newName: "_.StaticFiles");

            migrationBuilder.RenameTable(
                name: "_Roles",
                newName: "_.Roles");

            migrationBuilder.RenameTable(
                name: "_Reports",
                newName: "_.Reports");

            migrationBuilder.RenameTable(
                name: "_Groups",
                newName: "_.Groups");

            migrationBuilder.RenameIndex(
                name: "IX_LinkerLinks_Url",
                table: "Linker.Links",
                newName: "IX_Linker.Links_Url");

            migrationBuilder.RenameIndex(
                name: "IX_LinkerLinks_Identifier",
                table: "Linker.Links",
                newName: "IX_Linker.Links_Identifier");

            migrationBuilder.RenameIndex(
                name: "IX_IntegrationsTgUsersRoles_RoleId",
                table: "Integrations.TgUsersRoles",
                newName: "IX_Integrations.TgUsersRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_IntegrationsTgUsers_UserId",
                table: "Integrations.TgUsers",
                newName: "IX_Integrations.TgUsers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_IntegrationsTgRoles_Name",
                table: "Integrations.TgRoles",
                newName: "IX_Integrations.TgRoles_Name");

            migrationBuilder.RenameIndex(
                name: "IX_IntegrationsTgConnections_UserId",
                table: "Integrations.TgConnections",
                newName: "IX_Integrations.TgConnections_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_IntegrationsTgBots_Token_TypeName",
                table: "Integrations.TgBots",
                newName: "IX_Integrations.TgBots_Token_TypeName");

            migrationBuilder.RenameIndex(
                name: "IX_ApiTokensLogs_UserId",
                table: "Api.TokensLogs",
                newName: "IX_Api.TokensLogs_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ApiTokensLogs_TokenId",
                table: "Api.TokensLogs",
                newName: "IX_Api.TokensLogs_TokenId");

            migrationBuilder.RenameIndex(
                name: "IX_ApiTokens_OwnerId",
                table: "Api.Tokens",
                newName: "IX_Api.Tokens_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX__UsersRoles_RoleId",
                table: "_.UsersRoles",
                newName: "IX__.UsersRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX__UsersGroups_GroupId",
                table: "_.UsersGroups",
                newName: "IX__.UsersGroups_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX__Users_Username",
                table: "_.Users",
                newName: "IX__.Users_Username");

            migrationBuilder.RenameIndex(
                name: "IX__StringVariables_Name",
                table: "_.StringVariables",
                newName: "IX__.StringVariables_Name");

            migrationBuilder.RenameIndex(
                name: "IX__StringVariables_AuthorId",
                table: "_.StringVariables",
                newName: "IX__.StringVariables_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX__StaticFiles_OriginalId",
                table: "_.StaticFiles",
                newName: "IX__.StaticFiles_OriginalId");

            migrationBuilder.RenameIndex(
                name: "IX__StaticFiles_AuthorId",
                table: "_.StaticFiles",
                newName: "IX__.StaticFiles_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX__Roles_Name",
                table: "_.Roles",
                newName: "IX__.Roles_Name");

            migrationBuilder.RenameIndex(
                name: "IX__Reports_UserId",
                table: "_.Reports",
                newName: "IX__.Reports_UserId");

            migrationBuilder.RenameIndex(
                name: "IX__Reports_ModifiedDate",
                table: "_.Reports",
                newName: "IX__.Reports_ModifiedDate");

            migrationBuilder.RenameIndex(
                name: "IX__Reports_Message",
                table: "_.Reports",
                newName: "IX__.Reports_Message");

            migrationBuilder.RenameIndex(
                name: "IX__Reports_CreationDate",
                table: "_.Reports",
                newName: "IX__.Reports_CreationDate");

            migrationBuilder.RenameIndex(
                name: "IX__Groups_Name",
                table: "_.Groups",
                newName: "IX__.Groups_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Linker.Links",
                table: "Linker.Links",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Integrations.TgUsersRoles",
                table: "Integrations.TgUsersRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Integrations.TgUsers",
                table: "Integrations.TgUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Integrations.TgRoles",
                table: "Integrations.TgRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Integrations.TgConnections",
                table: "Integrations.TgConnections",
                columns: new[] { "BotId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Integrations.TgBots",
                table: "Integrations.TgBots",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Api.TokensLogs",
                table: "Api.TokensLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Api.Tokens",
                table: "Api.Tokens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account.Subscriptions",
                table: "Account.Subscriptions",
                columns: new[] { "FromId", "ToId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__.UsersRoles",
                table: "_.UsersRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__.UsersGroups",
                table: "_.UsersGroups",
                columns: new[] { "UserId", "GroupId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__.Users",
                table: "_.Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__.StringVariables",
                table: "_.StringVariables",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__.StaticFiles",
                table: "_.StaticFiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__.Roles",
                table: "_.Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__.Reports",
                table: "_.Reports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__.Groups",
                table: "_.Groups",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 86, DateTimeKind.Utc).AddTicks(2633), new DateTime(2019, 5, 11, 10, 54, 45, 86, DateTimeKind.Utc).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Account.Subscriptions",
                keyColumns: new[] { "FromId", "ToId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 86, DateTimeKind.Utc).AddTicks(172), new DateTime(2019, 5, 11, 10, 54, 45, 86, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(5819), new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(4916), new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(6671), new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Integrations.TgRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(2367), new DateTime(2019, 5, 11, 10, 54, 45, 123, DateTimeKind.Utc).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(9022), new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(9031), new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(9039), new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "_.Groups",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(8979), new DateTime(2019, 5, 11, 10, 54, 45, 68, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 67, DateTimeKind.Utc).AddTicks(939), new DateTime(2019, 5, 11, 10, 54, 45, 67, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 67, DateTimeKind.Utc).AddTicks(948), new DateTime(2019, 5, 11, 10, 54, 45, 67, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "_.Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 67, DateTimeKind.Utc).AddTicks(885), new DateTime(2019, 5, 11, 10, 54, 45, 67, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 55, DateTimeKind.Utc).AddTicks(7886), new DateTime(2019, 5, 11, 10, 54, 45, 55, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 55, DateTimeKind.Utc).AddTicks(7927), new DateTime(2019, 5, 11, 10, 54, 45, 55, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "_.Users",
                keyColumn: "Id",
                keyValue: new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 55, DateTimeKind.Utc).AddTicks(6816), new DateTime(2019, 5, 11, 10, 54, 45, 55, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(8878), new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(8939), new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 65, DateTimeKind.Utc).AddTicks(1443), new DateTime(2019, 5, 11, 10, 54, 45, 65, DateTimeKind.Utc).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 65, DateTimeKind.Utc).AddTicks(1487), new DateTime(2019, 5, 11, 10, 54, 45, 65, DateTimeKind.Utc).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(87), new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(5279), new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(6146), new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "_.UsersGroups",
                keyColumns: new[] { "UserId", "GroupId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(4302), new DateTime(2019, 5, 11, 10, 54, 45, 64, DateTimeKind.Utc).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 60, DateTimeKind.Utc).AddTicks(3100), new DateTime(2019, 5, 11, 10, 54, 45, 60, DateTimeKind.Utc).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 60, DateTimeKind.Utc).AddTicks(5058), new DateTime(2019, 5, 11, 10, 54, 45, 60, DateTimeKind.Utc).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 59, DateTimeKind.Utc).AddTicks(8748), new DateTime(2019, 5, 11, 10, 54, 45, 59, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 60, DateTimeKind.Utc).AddTicks(174), new DateTime(2019, 5, 11, 10, 54, 45, 60, DateTimeKind.Utc).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "_.UsersRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff") },
                columns: new[] { "CreationDate", "ModifiedDate" },
                values: new object[] { new DateTime(2019, 5, 11, 10, 54, 45, 59, DateTimeKind.Utc).AddTicks(3390), new DateTime(2019, 5, 11, 10, 54, 45, 59, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.AddForeignKey(
                name: "FK__.Reports__.Users_UserId",
                table: "_.Reports",
                column: "UserId",
                principalTable: "_.Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK__.StaticFiles__.Users_AuthorId",
                table: "_.StaticFiles",
                column: "AuthorId",
                principalTable: "_.Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__.StaticFiles__.StaticFiles_OriginalId",
                table: "_.StaticFiles",
                column: "OriginalId",
                principalTable: "_.StaticFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__.StringVariables__.Users_AuthorId",
                table: "_.StringVariables",
                column: "AuthorId",
                principalTable: "_.Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__.UsersGroups__.Groups_GroupId",
                table: "_.UsersGroups",
                column: "GroupId",
                principalTable: "_.Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__.UsersGroups__.Users_UserId",
                table: "_.UsersGroups",
                column: "UserId",
                principalTable: "_.Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__.UsersRoles__.Roles_RoleId",
                table: "_.UsersRoles",
                column: "RoleId",
                principalTable: "_.Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__.UsersRoles__.Users_UserId",
                table: "_.UsersRoles",
                column: "UserId",
                principalTable: "_.Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account.Subscriptions__.Users_FromId",
                table: "Account.Subscriptions",
                column: "FromId",
                principalTable: "_.Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Api.Tokens__.Users_OwnerId",
                table: "Api.Tokens",
                column: "OwnerId",
                principalTable: "_.Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Api.TokensLogs_Api.Tokens_TokenId",
                table: "Api.TokensLogs",
                column: "TokenId",
                principalTable: "Api.Tokens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Api.TokensLogs__.Users_UserId",
                table: "Api.TokensLogs",
                column: "UserId",
                principalTable: "_.Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Integrations.TgConnections_Integrations.TgBots_BotId",
                table: "Integrations.TgConnections",
                column: "BotId",
                principalTable: "Integrations.TgBots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Integrations.TgConnections_Integrations.TgUsers_UserId",
                table: "Integrations.TgConnections",
                column: "UserId",
                principalTable: "Integrations.TgUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Integrations.TgUsers__.Users_UserId",
                table: "Integrations.TgUsers",
                column: "UserId",
                principalTable: "_.Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Integrations.TgUsersRoles_Integrations.TgRoles_RoleId",
                table: "Integrations.TgUsersRoles",
                column: "RoleId",
                principalTable: "Integrations.TgRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Integrations.TgUsersRoles_Integrations.TgUsers_UserId",
                table: "Integrations.TgUsersRoles",
                column: "UserId",
                principalTable: "Integrations.TgUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__.Reports__.Users_UserId",
                table: "_.Reports");

            migrationBuilder.DropForeignKey(
                name: "FK__.StaticFiles__.Users_AuthorId",
                table: "_.StaticFiles");

            migrationBuilder.DropForeignKey(
                name: "FK__.StaticFiles__.StaticFiles_OriginalId",
                table: "_.StaticFiles");

            migrationBuilder.DropForeignKey(
                name: "FK__.StringVariables__.Users_AuthorId",
                table: "_.StringVariables");

            migrationBuilder.DropForeignKey(
                name: "FK__.UsersGroups__.Groups_GroupId",
                table: "_.UsersGroups");

            migrationBuilder.DropForeignKey(
                name: "FK__.UsersGroups__.Users_UserId",
                table: "_.UsersGroups");

            migrationBuilder.DropForeignKey(
                name: "FK__.UsersRoles__.Roles_RoleId",
                table: "_.UsersRoles");

            migrationBuilder.DropForeignKey(
                name: "FK__.UsersRoles__.Users_UserId",
                table: "_.UsersRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Account.Subscriptions__.Users_FromId",
                table: "Account.Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Api.Tokens__.Users_OwnerId",
                table: "Api.Tokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Api.TokensLogs_Api.Tokens_TokenId",
                table: "Api.TokensLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Api.TokensLogs__.Users_UserId",
                table: "Api.TokensLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Integrations.TgConnections_Integrations.TgBots_BotId",
                table: "Integrations.TgConnections");

            migrationBuilder.DropForeignKey(
                name: "FK_Integrations.TgConnections_Integrations.TgUsers_UserId",
                table: "Integrations.TgConnections");

            migrationBuilder.DropForeignKey(
                name: "FK_Integrations.TgUsers__.Users_UserId",
                table: "Integrations.TgUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Integrations.TgUsersRoles_Integrations.TgRoles_RoleId",
                table: "Integrations.TgUsersRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Integrations.TgUsersRoles_Integrations.TgUsers_UserId",
                table: "Integrations.TgUsersRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Linker.Links",
                table: "Linker.Links");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Integrations.TgUsersRoles",
                table: "Integrations.TgUsersRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Integrations.TgUsers",
                table: "Integrations.TgUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Integrations.TgRoles",
                table: "Integrations.TgRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Integrations.TgConnections",
                table: "Integrations.TgConnections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Integrations.TgBots",
                table: "Integrations.TgBots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Api.TokensLogs",
                table: "Api.TokensLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Api.Tokens",
                table: "Api.Tokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account.Subscriptions",
                table: "Account.Subscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK__.UsersRoles",
                table: "_.UsersRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__.UsersGroups",
                table: "_.UsersGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK__.Users",
                table: "_.Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK__.StringVariables",
                table: "_.StringVariables");

            migrationBuilder.DropPrimaryKey(
                name: "PK__.StaticFiles",
                table: "_.StaticFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__.Roles",
                table: "_.Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__.Reports",
                table: "_.Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK__.Groups",
                table: "_.Groups");

            migrationBuilder.RenameTable(
                name: "Linker.Links",
                newName: "LinkerLinks");

            migrationBuilder.RenameTable(
                name: "Integrations.TgUsersRoles",
                newName: "IntegrationsTgUsersRoles");

            migrationBuilder.RenameTable(
                name: "Integrations.TgUsers",
                newName: "IntegrationsTgUsers");

            migrationBuilder.RenameTable(
                name: "Integrations.TgRoles",
                newName: "IntegrationsTgRoles");

            migrationBuilder.RenameTable(
                name: "Integrations.TgConnections",
                newName: "IntegrationsTgConnections");

            migrationBuilder.RenameTable(
                name: "Integrations.TgBots",
                newName: "IntegrationsTgBots");

            migrationBuilder.RenameTable(
                name: "Api.TokensLogs",
                newName: "ApiTokensLogs");

            migrationBuilder.RenameTable(
                name: "Api.Tokens",
                newName: "ApiTokens");

            migrationBuilder.RenameTable(
                name: "Account.Subscriptions",
                newName: "AccountSubscriptions");

            migrationBuilder.RenameTable(
                name: "_.UsersRoles",
                newName: "_UsersRoles");

            migrationBuilder.RenameTable(
                name: "_.UsersGroups",
                newName: "_UsersGroups");

            migrationBuilder.RenameTable(
                name: "_.Users",
                newName: "_Users");

            migrationBuilder.RenameTable(
                name: "_.StringVariables",
                newName: "_StringVariables");

            migrationBuilder.RenameTable(
                name: "_.StaticFiles",
                newName: "_StaticFiles");

            migrationBuilder.RenameTable(
                name: "_.Roles",
                newName: "_Roles");

            migrationBuilder.RenameTable(
                name: "_.Reports",
                newName: "_Reports");

            migrationBuilder.RenameTable(
                name: "_.Groups",
                newName: "_Groups");

            migrationBuilder.RenameIndex(
                name: "IX_Linker.Links_Url",
                table: "LinkerLinks",
                newName: "IX_LinkerLinks_Url");

            migrationBuilder.RenameIndex(
                name: "IX_Linker.Links_Identifier",
                table: "LinkerLinks",
                newName: "IX_LinkerLinks_Identifier");

            migrationBuilder.RenameIndex(
                name: "IX_Integrations.TgUsersRoles_RoleId",
                table: "IntegrationsTgUsersRoles",
                newName: "IX_IntegrationsTgUsersRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Integrations.TgUsers_UserId",
                table: "IntegrationsTgUsers",
                newName: "IX_IntegrationsTgUsers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Integrations.TgRoles_Name",
                table: "IntegrationsTgRoles",
                newName: "IX_IntegrationsTgRoles_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Integrations.TgConnections_UserId",
                table: "IntegrationsTgConnections",
                newName: "IX_IntegrationsTgConnections_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Integrations.TgBots_Token_TypeName",
                table: "IntegrationsTgBots",
                newName: "IX_IntegrationsTgBots_Token_TypeName");

            migrationBuilder.RenameIndex(
                name: "IX_Api.TokensLogs_UserId",
                table: "ApiTokensLogs",
                newName: "IX_ApiTokensLogs_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Api.TokensLogs_TokenId",
                table: "ApiTokensLogs",
                newName: "IX_ApiTokensLogs_TokenId");

            migrationBuilder.RenameIndex(
                name: "IX_Api.Tokens_OwnerId",
                table: "ApiTokens",
                newName: "IX_ApiTokens_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX__.UsersRoles_RoleId",
                table: "_UsersRoles",
                newName: "IX__UsersRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX__.UsersGroups_GroupId",
                table: "_UsersGroups",
                newName: "IX__UsersGroups_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX__.Users_Username",
                table: "_Users",
                newName: "IX__Users_Username");

            migrationBuilder.RenameIndex(
                name: "IX__.StringVariables_Name",
                table: "_StringVariables",
                newName: "IX__StringVariables_Name");

            migrationBuilder.RenameIndex(
                name: "IX__.StringVariables_AuthorId",
                table: "_StringVariables",
                newName: "IX__StringVariables_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX__.StaticFiles_OriginalId",
                table: "_StaticFiles",
                newName: "IX__StaticFiles_OriginalId");

            migrationBuilder.RenameIndex(
                name: "IX__.StaticFiles_AuthorId",
                table: "_StaticFiles",
                newName: "IX__StaticFiles_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX__.Roles_Name",
                table: "_Roles",
                newName: "IX__Roles_Name");

            migrationBuilder.RenameIndex(
                name: "IX__.Reports_UserId",
                table: "_Reports",
                newName: "IX__Reports_UserId");

            migrationBuilder.RenameIndex(
                name: "IX__.Reports_ModifiedDate",
                table: "_Reports",
                newName: "IX__Reports_ModifiedDate");

            migrationBuilder.RenameIndex(
                name: "IX__.Reports_Message",
                table: "_Reports",
                newName: "IX__Reports_Message");

            migrationBuilder.RenameIndex(
                name: "IX__.Reports_CreationDate",
                table: "_Reports",
                newName: "IX__Reports_CreationDate");

            migrationBuilder.RenameIndex(
                name: "IX__.Groups_Name",
                table: "_Groups",
                newName: "IX__Groups_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LinkerLinks",
                table: "LinkerLinks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IntegrationsTgUsersRoles",
                table: "IntegrationsTgUsersRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IntegrationsTgUsers",
                table: "IntegrationsTgUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IntegrationsTgRoles",
                table: "IntegrationsTgRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IntegrationsTgConnections",
                table: "IntegrationsTgConnections",
                columns: new[] { "BotId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IntegrationsTgBots",
                table: "IntegrationsTgBots",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiTokensLogs",
                table: "ApiTokensLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiTokens",
                table: "ApiTokens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountSubscriptions",
                table: "AccountSubscriptions",
                columns: new[] { "FromId", "ToId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__UsersRoles",
                table: "_UsersRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__UsersGroups",
                table: "_UsersGroups",
                columns: new[] { "UserId", "GroupId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__Users",
                table: "_Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__StringVariables",
                table: "_StringVariables",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__StaticFiles",
                table: "_StaticFiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Roles",
                table: "_Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Reports",
                table: "_Reports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Groups",
                table: "_Groups",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK__Reports__Users_UserId",
                table: "_Reports",
                column: "UserId",
                principalTable: "_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK__StaticFiles__Users_AuthorId",
                table: "_StaticFiles",
                column: "AuthorId",
                principalTable: "_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__StaticFiles__StaticFiles_OriginalId",
                table: "_StaticFiles",
                column: "OriginalId",
                principalTable: "_StaticFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__StringVariables__Users_AuthorId",
                table: "_StringVariables",
                column: "AuthorId",
                principalTable: "_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__UsersGroups__Groups_GroupId",
                table: "_UsersGroups",
                column: "GroupId",
                principalTable: "_Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__UsersGroups__Users_UserId",
                table: "_UsersGroups",
                column: "UserId",
                principalTable: "_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__UsersRoles__Roles_RoleId",
                table: "_UsersRoles",
                column: "RoleId",
                principalTable: "_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__UsersRoles__Users_UserId",
                table: "_UsersRoles",
                column: "UserId",
                principalTable: "_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountSubscriptions__Users_FromId",
                table: "AccountSubscriptions",
                column: "FromId",
                principalTable: "_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiTokens__Users_OwnerId",
                table: "ApiTokens",
                column: "OwnerId",
                principalTable: "_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiTokensLogs_ApiTokens_TokenId",
                table: "ApiTokensLogs",
                column: "TokenId",
                principalTable: "ApiTokens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiTokensLogs__Users_UserId",
                table: "ApiTokensLogs",
                column: "UserId",
                principalTable: "_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IntegrationsTgConnections_IntegrationsTgBots_BotId",
                table: "IntegrationsTgConnections",
                column: "BotId",
                principalTable: "IntegrationsTgBots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IntegrationsTgConnections_IntegrationsTgUsers_UserId",
                table: "IntegrationsTgConnections",
                column: "UserId",
                principalTable: "IntegrationsTgUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IntegrationsTgUsers__Users_UserId",
                table: "IntegrationsTgUsers",
                column: "UserId",
                principalTable: "_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IntegrationsTgUsersRoles_IntegrationsTgRoles_RoleId",
                table: "IntegrationsTgUsersRoles",
                column: "RoleId",
                principalTable: "IntegrationsTgRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IntegrationsTgUsersRoles_IntegrationsTgUsers_UserId",
                table: "IntegrationsTgUsersRoles",
                column: "UserId",
                principalTable: "IntegrationsTgUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
