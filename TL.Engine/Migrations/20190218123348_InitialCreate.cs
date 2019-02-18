using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TL.Engine.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    IsClosed = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ReferrerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountUsers_AccountUsers_ReferrerId",
                        column: x => x.ReferrerId,
                        principalTable: "AccountUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrmContractors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
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
                name: "IntegrationsTgBots",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Token = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    NativeName = table.Column<string>(nullable: true),
                    TypeName = table.Column<string>(nullable: true),
                    SkipUpdates = table.Column<bool>(nullable: false),
                    AutoStart = table.Column<bool>(nullable: false),
                    IsRelevant = table.Column<bool>(nullable: false),
                    LastStartDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegrationsTgBots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntegrationsTgRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegrationsTgRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountSubscriptions",
                columns: table => new
                {
                    FromId = table.Column<Guid>(nullable: false),
                    ToId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Quiet = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountSubscriptions", x => new { x.FromId, x.ToId });
                    table.ForeignKey(
                        name: "FK_AccountSubscriptions_AccountUsers_FromId",
                        column: x => x.FromId,
                        principalTable: "AccountUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountUsersRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountUsersRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AccountUsersRoles_AccountRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AccountRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountUsersRoles_AccountUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AccountUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EngineReports",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    StackTrace = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EngineReports_AccountUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AccountUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "EngineStringVariables",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    AuthorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineStringVariables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EngineStringVariables_AccountUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AccountUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IntegrationsTgUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    TgId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegrationsTgUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IntegrationsTgUsers_AccountUsers_UserId",
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
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ReferrerId = table.Column<Guid>(nullable: false),
                    RefferalId = table.Column<Guid>(nullable: true),
                    IsActivated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmInvites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrmInvites_CrmContractors_ReferrerId",
                        column: x => x.ReferrerId,
                        principalTable: "CrmContractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IntegrationsTgConnections",
                columns: table => new
                {
                    BotId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegrationsTgConnections", x => new { x.BotId, x.UserId });
                    table.ForeignKey(
                        name: "FK_IntegrationsTgConnections_IntegrationsTgBots_BotId",
                        column: x => x.BotId,
                        principalTable: "IntegrationsTgBots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IntegrationsTgConnections_IntegrationsTgUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "IntegrationsTgUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IntegrationsTgUsersRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegrationsTgUsersRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_IntegrationsTgUsersRoles_IntegrationsTgRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "IntegrationsTgRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IntegrationsTgUsersRoles_IntegrationsTgUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "IntegrationsTgUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrmLeads",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Middlename = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    ContractorId = table.Column<Guid>(nullable: true),
                    OriginalId = table.Column<Guid>(nullable: true),
                    InviteId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrmLeads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrmLeads_CrmContractors_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "CrmContractors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrmLeads_CrmInvites_InviteId",
                        column: x => x.InviteId,
                        principalTable: "CrmInvites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "CrmLeadsPhones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
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
                table: "AccountRoles",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sa" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system" }
                });

            migrationBuilder.InsertData(
                table: "AccountUsers",
                columns: new[] { "Id", "CreationDate", "Description", "IsClosed", "IsDeleted", "ModifiedDate", "PasswordHash", "ReferrerId", "Username" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Супер-пользователь системы TL Engine", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "sa" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Автоматика системы TL Engine", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "system" }
                });

            migrationBuilder.InsertData(
                table: "IntegrationsTgRoles",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sa" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "system" }
                });

            migrationBuilder.InsertData(
                table: "AccountSubscriptions",
                columns: new[] { "FromId", "ToId", "CreationDate", "ModifiedDate", "Quiet" },
                values: new object[] { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "AccountUsersRoles",
                columns: new[] { "UserId", "RoleId", "CreationDate", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountRoles_Name",
                table: "AccountRoles",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUsers_ReferrerId",
                table: "AccountUsers",
                column: "ReferrerId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUsers_Username",
                table: "AccountUsers",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AccountUsersRoles_RoleId",
                table: "AccountUsersRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmContractors_OriginalId",
                table: "CrmContractors",
                column: "OriginalId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmInvites_ReferrerId",
                table: "CrmInvites",
                column: "ReferrerId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmLeads_ContractorId",
                table: "CrmLeads",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_CrmLeads_InviteId",
                table: "CrmLeads",
                column: "InviteId",
                unique: true,
                filter: "[InviteId] IS NOT NULL");

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

            migrationBuilder.CreateIndex(
                name: "IX_EngineReports_CreationDate",
                table: "EngineReports",
                column: "CreationDate");

            migrationBuilder.CreateIndex(
                name: "IX_EngineReports_Message",
                table: "EngineReports",
                column: "Message");

            migrationBuilder.CreateIndex(
                name: "IX_EngineReports_ModifiedDate",
                table: "EngineReports",
                column: "ModifiedDate");

            migrationBuilder.CreateIndex(
                name: "IX_EngineReports_UserId",
                table: "EngineReports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineStringVariables_AuthorId",
                table: "EngineStringVariables",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineStringVariables_Name",
                table: "EngineStringVariables",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_IntegrationsTgBots_Token_TypeName",
                table: "IntegrationsTgBots",
                columns: new[] { "Token", "TypeName" },
                unique: true,
                filter: "[Token] IS NOT NULL AND [TypeName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IntegrationsTgConnections_UserId",
                table: "IntegrationsTgConnections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IntegrationsTgRoles_Name",
                table: "IntegrationsTgRoles",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IntegrationsTgUsers_UserId",
                table: "IntegrationsTgUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IntegrationsTgUsersRoles_RoleId",
                table: "IntegrationsTgUsersRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountSubscriptions");

            migrationBuilder.DropTable(
                name: "AccountUsersRoles");

            migrationBuilder.DropTable(
                name: "CrmLeadsPhones");

            migrationBuilder.DropTable(
                name: "EngineReports");

            migrationBuilder.DropTable(
                name: "EngineStringVariables");

            migrationBuilder.DropTable(
                name: "IntegrationsTgConnections");

            migrationBuilder.DropTable(
                name: "IntegrationsTgUsersRoles");

            migrationBuilder.DropTable(
                name: "AccountRoles");

            migrationBuilder.DropTable(
                name: "CrmLeads");

            migrationBuilder.DropTable(
                name: "IntegrationsTgBots");

            migrationBuilder.DropTable(
                name: "IntegrationsTgRoles");

            migrationBuilder.DropTable(
                name: "IntegrationsTgUsers");

            migrationBuilder.DropTable(
                name: "CrmInvites");

            migrationBuilder.DropTable(
                name: "AccountUsers");

            migrationBuilder.DropTable(
                name: "CrmContractors");
        }
    }
}
