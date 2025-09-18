using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Construction_ERP.Migrations
{
    public partial class Construction_ERP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank_Table",
                columns: table => new
                {
                    Bank_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bank_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Updated_By = table.Column<int>(type: "int", nullable: true),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Acflag = table.Column<int>(type: "int", nullable: true),
                    Saas_Id = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank_Table", x => x.Bank_Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Table",
                columns: table => new
                {
                    Emp_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Pan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Bank_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Account = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Table", x => x.Emp_id);
                });

            migrationBuilder.CreateTable(
                name: "Roll_Table",
                columns: table => new
                {
                    Roll_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Roll_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Updated_By = table.Column<int>(type: "int", nullable: true),
                    Created_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Acflag = table.Column<int>(type: "int", nullable: true),
                    Saas_Id = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roll_Table", x => x.Roll_Id);
                });

            migrationBuilder.CreateTable(
                name: "User_Registration_Table",
                columns: table => new
                {
                    User_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_id = table.Column<int>(type: "int", nullable: true),
                    Roll_Id = table.Column<int>(type: "int", nullable: true),
                    User_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token_key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_by = table.Column<int>(type: "int", nullable: true),
                    Created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_by = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ac_flag = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Registration_Table", x => x.User_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bank_Table");

            migrationBuilder.DropTable(
                name: "Employee_Table");

            migrationBuilder.DropTable(
                name: "Roll_Table");

            migrationBuilder.DropTable(
                name: "User_Registration_Table");
        }
    }
}
