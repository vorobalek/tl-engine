using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v0503 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "IntegrationsTgUsersRoles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "IntegrationsTgUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "IntegrationsTgRoles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "IntegrationsTgConnections",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "IntegrationsTgBots",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EngineStringVariables",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EngineReports",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CrmLeadsPhones",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CrmLeads",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CrmInvites",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CrmContractors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AccountUsersRoles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AccountSubscriptions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AccountRoles",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "IntegrationsTgUsersRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "IntegrationsTgUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "IntegrationsTgRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "IntegrationsTgConnections");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "IntegrationsTgBots");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EngineStringVariables");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EngineReports");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CrmLeadsPhones");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CrmLeads");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CrmInvites");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CrmContractors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AccountUsersRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AccountSubscriptions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AccountRoles");
        }
    }
}
