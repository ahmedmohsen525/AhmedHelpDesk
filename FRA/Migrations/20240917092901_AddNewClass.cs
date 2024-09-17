using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FRA.Migrations
{
    /// <inheritdoc />
    public partial class AddNewClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoties",
                columns: table => new
                {
                    Cat_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoties", x => x.Cat_ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Emp_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone_Num = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Emp_ID);
                });

            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    Service_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Service_levels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent_ID = table.Column<int>(type: "int", nullable: false),
                    Start_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.Service_ID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Agent_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End_Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Agent_ID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Status_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Str_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Status_ID);
                });

            migrationBuilder.CreateTable(
                name: "Technicals",
                columns: table => new
                {
                    Group_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceProviderAgent_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicals", x => x.Group_ID);
                    table.ForeignKey(
                        name: "FK_Technicals_Services_ServiceProviderAgent_ID",
                        column: x => x.ServiceProviderAgent_ID,
                        principalTable: "Services",
                        principalColumn: "Agent_ID");
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Ticket_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Resolved_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Service_ID = table.Column<int>(type: "int", nullable: false),
                    EmployeeEmp_ID = table.Column<int>(type: "int", nullable: true),
                    ServiceProviderAgent_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Ticket_ID);
                    table.ForeignKey(
                        name: "FK_Tickets_Employees_EmployeeEmp_ID",
                        column: x => x.EmployeeEmp_ID,
                        principalTable: "Employees",
                        principalColumn: "Emp_ID");
                    table.ForeignKey(
                        name: "FK_Tickets_Services_ServiceProviderAgent_ID",
                        column: x => x.ServiceProviderAgent_ID,
                        principalTable: "Services",
                        principalColumn: "Agent_ID");
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Service_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_ID = table.Column<int>(type: "int", nullable: false),
                    Agent_ID = table.Column<int>(type: "int", nullable: false),
                    Service_nam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Request_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Start_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prioity = table.Column<int>(type: "int", nullable: false),
                    Service_levels = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryCat_ID = table.Column<int>(type: "int", nullable: true),
                    ServiceProviderAgent_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Service_ID);
                    table.ForeignKey(
                        name: "FK_Types_Categoties_CategoryCat_ID",
                        column: x => x.CategoryCat_ID,
                        principalTable: "Categoties",
                        principalColumn: "Cat_ID");
                    table.ForeignKey(
                        name: "FK_Types_Services_ServiceProviderAgent_ID",
                        column: x => x.ServiceProviderAgent_ID,
                        principalTable: "Services",
                        principalColumn: "Agent_ID");
                });

            migrationBuilder.CreateTable(
                name: "Ticket_cases",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_ID = table.Column<int>(type: "int", nullable: false),
                    Status_ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResolvedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hardwere_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hardwere_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddProblemResnt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    select = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddProblemNew = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Knoledg_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hosting_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inside = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    outside = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Insidecon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outsidecon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket_cases", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ticket_cases_Categoties_Cat_ID",
                        column: x => x.Cat_ID,
                        principalTable: "Categoties",
                        principalColumn: "Cat_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_cases_Statuses_Status_ID",
                        column: x => x.Status_ID,
                        principalTable: "Statuses",
                        principalColumn: "Status_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Technicals_ServiceProviderAgent_ID",
                table: "Technicals",
                column: "ServiceProviderAgent_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_cases_Cat_ID",
                table: "Ticket_cases",
                column: "Cat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_cases_Status_ID",
                table: "Ticket_cases",
                column: "Status_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EmployeeEmp_ID",
                table: "Tickets",
                column: "EmployeeEmp_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ServiceProviderAgent_ID",
                table: "Tickets",
                column: "ServiceProviderAgent_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Types_CategoryCat_ID",
                table: "Types",
                column: "CategoryCat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Types_ServiceProviderAgent_ID",
                table: "Types",
                column: "ServiceProviderAgent_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "Technicals");

            migrationBuilder.DropTable(
                name: "Ticket_cases");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Categoties");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
