using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcmePublishingDemo.EF.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUtcLocale = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    ModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUtcLocale = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerEntity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUtcLocale = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    ModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUtcLocale = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributionCompanyEntity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrintDistributionCompanyId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUtcLocale = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    ModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUtcLocale = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributionCompanyEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicationId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUtcLocale = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    ModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUtcLocale = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publications_DistributionCompanyEntity_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "DistributionCompanyEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerSubscriptionEntity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    PublicationId = table.Column<long>(type: "bigint", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUtcLocale = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    ModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUtcLocale = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSubscriptionEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerSubscriptionEntity_CustomerEntity_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerSubscriptionEntity_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryAddresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryAddressId = table.Column<long>(type: "bigint", nullable: false),
                    SubscriptionId = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUtcLocale = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    ModifiedUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUtcLocale = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryAddresses_CustomerSubscriptionEntity_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "CustomerSubscriptionEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSubscriptionEntity_CustomerId",
                table: "CustomerSubscriptionEntity",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSubscriptionEntity_PublicationId",
                table: "CustomerSubscriptionEntity",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryAddresses_SubscriptionId",
                table: "DeliveryAddresses",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_PublicationId",
                table: "Publications",
                column: "PublicationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "DeliveryAddresses");

            migrationBuilder.DropTable(
                name: "CustomerSubscriptionEntity");

            migrationBuilder.DropTable(
                name: "CustomerEntity");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "DistributionCompanyEntity");
        }
    }
}
