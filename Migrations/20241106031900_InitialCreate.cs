using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORMCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Dnumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Mgr_SSN = table.Column<int>(type: "int", nullable: false),
                    Mgr_Start_Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Dnumber);
                });

            migrationBuilder.CreateTable(
                name: "Dept_Locations",
                columns: table => new
                {
                    Dnumber = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dept_Locations", x => new { x.Dnumber, x.Location });
                    table.ForeignKey(
                        name: "FK_Dept_Locations_Departments_Dnumber",
                        column: x => x.Dnumber,
                        principalTable: "Departments",
                        principalColumn: "Dnumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    SSN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Mname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Bdate = table.Column<DateOnly>(type: "date", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sex = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<float>(type: "real", maxLength: 100000, nullable: false),
                    SuperSSN = table.Column<int>(type: "int", nullable: false),
                    Dno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.SSN);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_Dno",
                        column: x => x.Dno,
                        principalTable: "Departments",
                        principalColumn: "Dnumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_SuperSSN",
                        column: x => x.SuperSSN,
                        principalTable: "Employees",
                        principalColumn: "SSN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Pnumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dnum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Pnumber);
                    table.ForeignKey(
                        name: "FK_Projects_Departments_Dnum",
                        column: x => x.Dnum,
                        principalTable: "Departments",
                        principalColumn: "Dnumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dependents",
                columns: table => new
                {
                    Essn = table.Column<int>(type: "int", nullable: false),
                    Dependent_Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sex = table.Column<int>(type: "int", nullable: false),
                    Bdate = table.Column<DateOnly>(type: "date", nullable: false),
                    relationship = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependents", x => new { x.Essn, x.Dependent_Name });
                    table.ForeignKey(
                        name: "FK_Dependents_Employees_Essn",
                        column: x => x.Essn,
                        principalTable: "Employees",
                        principalColumn: "SSN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Work_On",
                columns: table => new
                {
                    Essn = table.Column<int>(type: "int", nullable: false),
                    Pno = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Work_On", x => new { x.Essn, x.Pno });
                    table.ForeignKey(
                        name: "FK_Work_On_Employees_Essn",
                        column: x => x.Essn,
                        principalTable: "Employees",
                        principalColumn: "SSN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Work_On_Projects_Pno",
                        column: x => x.Pno,
                        principalTable: "Projects",
                        principalColumn: "Pnumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Dnumber",
                table: "Departments",
                column: "Dnumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Mgr_SSN",
                table: "Departments",
                column: "Mgr_SSN");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Dno",
                table: "Employees",
                column: "Dno");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SuperSSN",
                table: "Employees",
                column: "SuperSSN");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_Dnum",
                table: "Projects",
                column: "Dnum");

            migrationBuilder.CreateIndex(
                name: "IX_Work_On_Pno",
                table: "Work_On",
                column: "Pno");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_Mgr_SSN",
                table: "Departments",
                column: "Mgr_SSN",
                principalTable: "Employees",
                principalColumn: "SSN",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_Mgr_SSN",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "Dependents");

            migrationBuilder.DropTable(
                name: "Dept_Locations");

            migrationBuilder.DropTable(
                name: "Work_On");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
