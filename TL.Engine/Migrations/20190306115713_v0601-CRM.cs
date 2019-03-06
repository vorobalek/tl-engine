using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class v0601CRM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrmContractors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    OriginalId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmContractors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrmContractors_CrmContractors_OriginalId",
                        column: x => x.OriginalId,
                        principalTable: "CrmContractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrmLeads",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Middlename = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    ContractorId = table.Column<Guid>(nullable: true),
                    OriginalId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmLeads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrmLeads_CrmContractors_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "CrmContractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrmLeads_CrmLeads_OriginalId",
                        column: x => x.OriginalId,
                        principalTable: "CrmLeads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrmLeads_AccountUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AccountUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrmInvites",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ReferrerId = table.Column<Guid>(nullable: false),
                    ReferralId = table.Column<Guid>(nullable: true),
                    IsActivated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmInvites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrmInvites_CrmLeads_ReferralId",
                        column: x => x.ReferralId,
                        principalTable: "CrmLeads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrmInvites_CrmContractors_ReferrerId",
                        column: x => x.ReferrerId,
                        principalTable: "CrmContractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrmLeadsPhones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    LeadId = table.Column<Guid>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmLeadsPhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrmLeadsPhones_CrmLeads_LeadId",
                        column: x => x.LeadId,
                        principalTable: "CrmLeads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CrmContractors",
                columns: new[] { "Id", "CreationDate", "IsDeleted", "ModifiedDate", "OriginalId" },
                values: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "CrmLeads",
                columns: new[] { "Id", "ContractorId", "CreationDate", "Firstname", "IsDeleted", "Lastname", "Middlename", "ModifiedDate", "OriginalId", "UserId" },
                values: new object[] { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Автоматика", false, "Системы", "TL Engine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") });

            migrationBuilder.CreateIndex(
                name: "IX_CrmContractors_OriginalId",
                table: "CrmContractors",
                column: "OriginalId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmInvites_ReferralId",
                table: "CrmInvites",
                column: "ReferralId",
                unique: true,
                filter: "[ReferralId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CrmInvites_ReferrerId",
                table: "CrmInvites",
                column: "ReferrerId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmLeads_ContractorId",
                table: "CrmLeads",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmLeads_OriginalId",
                table: "CrmLeads",
                column: "OriginalId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmLeads_UserId",
                table: "CrmLeads",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmLeadsPhones_LeadId",
                table: "CrmLeadsPhones",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmLeadsPhones_PhoneNumber",
                table: "CrmLeadsPhones",
                column: "PhoneNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrmInvites");

            migrationBuilder.DropTable(
                name: "CrmLeadsPhones");

            migrationBuilder.DropTable(
                name: "CrmLeads");

            migrationBuilder.DropTable(
                name: "CrmContractors");
        }
    }
}
