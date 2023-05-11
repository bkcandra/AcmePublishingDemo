using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcmePublishingDemo.EF.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publications_DistributionCompanyEntity_PublicationId",
                table: "Publications");

            migrationBuilder.DropIndex(
                name: "IX_Publications_PublicationId",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "PublicationId",
                table: "Publications");

            migrationBuilder.DropColumn(
                name: "PrintDistributionCompanyId",
                table: "DistributionCompanyEntity");

            migrationBuilder.DropColumn(
                name: "DeliveryAddressId",
                table: "DeliveryAddresses");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "CustomerSubscriptionEntity");

            migrationBuilder.CreateTable(
                name: "DistributionCompanyEntityPublicationEntity",
                columns: table => new
                {
                    DistributionCompaniesId = table.Column<long>(type: "bigint", nullable: false),
                    PublicationsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionCompanyEntityPublicationEntity", x => new { x.DistributionCompaniesId, x.PublicationsId });
                    table.ForeignKey(
                        name: "FK_DistributionCompanyEntityPublicationEntity_DistributionCompanyEntity_DistributionCompaniesId",
                        column: x => x.DistributionCompaniesId,
                        principalTable: "DistributionCompanyEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistributionCompanyEntityPublicationEntity_Publications_PublicationsId",
                        column: x => x.PublicationsId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DistributionCompanyEntityPublicationEntity_PublicationsId",
                table: "DistributionCompanyEntityPublicationEntity",
                column: "PublicationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistributionCompanyEntityPublicationEntity");

            migrationBuilder.AddColumn<long>(
                name: "PublicationId",
                table: "Publications",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "PrintDistributionCompanyId",
                table: "DistributionCompanyEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "DeliveryAddressId",
                table: "DeliveryAddresses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SubscriptionId",
                table: "CustomerSubscriptionEntity",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Publications_PublicationId",
                table: "Publications",
                column: "PublicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_DistributionCompanyEntity_PublicationId",
                table: "Publications",
                column: "PublicationId",
                principalTable: "DistributionCompanyEntity",
                principalColumn: "Id");
        }
    }
}
