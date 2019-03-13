using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v0702 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrmInvites_CrmLeads_ReferralId",
                table: "CrmInvites");

            migrationBuilder.DropIndex(
                name: "IX_CrmInvites_ReferralId",
                table: "CrmInvites");

            migrationBuilder.DropColumn(
                name: "ReferralId",
                table: "CrmInvites");

            migrationBuilder.AddColumn<Guid>(
                name: "InviteId",
                table: "CrmLeads",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxMembersCount",
                table: "CrmInvites",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeOut",
                table: "CrmInvites",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_CrmLeads_InviteId",
                table: "CrmLeads",
                column: "InviteId");

            migrationBuilder.AddForeignKey(
                name: "FK_CrmLeads_CrmInvites_InviteId",
                table: "CrmLeads",
                column: "InviteId",
                principalTable: "CrmInvites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrmLeads_CrmInvites_InviteId",
                table: "CrmLeads");

            migrationBuilder.DropIndex(
                name: "IX_CrmLeads_InviteId",
                table: "CrmLeads");

            migrationBuilder.DropColumn(
                name: "InviteId",
                table: "CrmLeads");

            migrationBuilder.DropColumn(
                name: "MaxMembersCount",
                table: "CrmInvites");

            migrationBuilder.DropColumn(
                name: "TimeOut",
                table: "CrmInvites");

            migrationBuilder.AddColumn<Guid>(
                name: "ReferralId",
                table: "CrmInvites",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CrmInvites_ReferralId",
                table: "CrmInvites",
                column: "ReferralId",
                unique: true,
                filter: "[ReferralId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CrmInvites_CrmLeads_ReferralId",
                table: "CrmInvites",
                column: "ReferralId",
                principalTable: "CrmLeads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
