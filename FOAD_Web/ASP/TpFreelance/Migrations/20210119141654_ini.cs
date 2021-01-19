using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TpFreelancer.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers_cats",
                columns: table => new
                {
                    cats_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cat_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cat_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCatsModelCatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers_cats", x => x.cats_id);
                    table.ForeignKey(
                        name: "FK_customers_cats_customers_cats_CustomerCatsModelCatId",
                        column: x => x.CustomerCatsModelCatId,
                        principalTable: "customers_cats",
                        principalColumn: "cats_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    customer_email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    customer_registration_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false),
                    CustomersCatsCatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customer_id);
                    table.ForeignKey(
                        name: "FK_customers_customers_cats_CustomersCatsCatId",
                        column: x => x.CustomersCatsCatId,
                        principalTable: "customers_cats",
                        principalColumn: "cats_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    job_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_state = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    job_title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    job_start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    job_end = table.Column<DateTime>(type: "datetime2", nullable: false),
                    job_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    CustomersModelCustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.job_id);
                    table.ForeignKey(
                        name: "FK_jobs_customers_CustomersModelCustomerId",
                        column: x => x.CustomersModelCustomerId,
                        principalTable: "customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuotesModels",
                columns: table => new
                {
                    quote_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quote_state = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    quote_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quote_amount = table.Column<int>(type: "int", nullable: false),
                    quote_final_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quote_final_amount = table.Column<int>(type: "int", nullable: false),
                    job_id = table.Column<int>(type: "int", nullable: false),
                    JobsModelJobId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotesModels", x => x.quote_id);
                    table.ForeignKey(
                        name: "FK_QuotesModels_jobs_JobsModelJobId",
                        column: x => x.JobsModelJobId,
                        principalTable: "jobs",
                        principalColumn: "job_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_customer_name_customer_email",
                table: "customers",
                columns: new[] { "customer_name", "customer_email" },
                unique: true,
                filter: "[customer_name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_customers_CustomersCatsCatId",
                table: "customers",
                column: "CustomersCatsCatId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_cats_cat_name",
                table: "customers_cats",
                column: "cat_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_customers_cats_CustomerCatsModelCatId",
                table: "customers_cats",
                column: "CustomerCatsModelCatId");

            migrationBuilder.CreateIndex(
                name: "IX_jobs_CustomersModelCustomerId",
                table: "jobs",
                column: "CustomersModelCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_QuotesModels_JobsModelJobId",
                table: "QuotesModels",
                column: "JobsModelJobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuotesModels");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "customers_cats");
        }
    }
}
