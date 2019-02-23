using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v0502 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrmLeads_CrmContractors_ContractorId",
                table: "CrmLeads");

            migrationBuilder.DropForeignKey(
                name: "FK_CrmLeads_CrmInvites_InviteId",
                table: "CrmLeads");

            migrationBuilder.DropIndex(
                name: "IX_CrmLeads_InviteId",
                table: "CrmLeads");

            migrationBuilder.DropColumn(
                name: "InviteId",
                table: "CrmLeads");

            migrationBuilder.RenameColumn(
                name: "RefferalId",
                table: "CrmInvites",
                newName: "ReferralId");

            migrationBuilder.InsertData(
                table: "CrmContractors",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "OriginalId" },
                values: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "CrmLeads",
                columns: new[] { "Id", "ContractorId", "CreationDate", "Firstname", "Lastname", "Middlename", "ModifiedDate", "OriginalId", "UserId" },
                values: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Автоматика", "Системы", "TL Engine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

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

            migrationBuilder.AddForeignKey(
                name: "FK_CrmLeads_CrmContractors_ContractorId",
                table: "CrmLeads",
                column: "ContractorId",
                principalTable: "CrmContractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrmInvites_CrmLeads_ReferralId",
                table: "CrmInvites");

            migrationBuilder.DropForeignKey(
                name: "FK_CrmLeads_CrmContractors_ContractorId",
                table: "CrmLeads");

            migrationBuilder.DropIndex(
                name: "IX_CrmInvites_ReferralId",
                table: "CrmInvites");

            migrationBuilder.DeleteData(
                table: "CrmLeads",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "CrmContractors",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.RenameColumn(
                name: "ReferralId",
                table: "CrmInvites",
                newName: "RefferalId");

            migrationBuilder.AddColumn<Guid>(
                name: "InviteId",
                table: "CrmLeads",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CrmLeads_InviteId",
                table: "CrmLeads",
                column: "InviteId",
                unique: true,
                filter: "[InviteId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CrmLeads_CrmContractors_ContractorId",
                table: "CrmLeads",
                column: "ContractorId",
                principalTable: "CrmContractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CrmLeads_CrmInvites_InviteId",
                table: "CrmLeads",
                column: "InviteId",
                principalTable: "CrmInvites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
