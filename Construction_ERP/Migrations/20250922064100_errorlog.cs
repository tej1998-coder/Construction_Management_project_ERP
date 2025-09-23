using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Construction_ERP.Migrations
{
    public partial class errorlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErrorLog_Table",
                columns: table => new
                {
                    ErrorLog_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErrorLog_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    controller_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ActionMethodName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flag = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLog_Table", x => x.ErrorLog_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErrorLog_Table");
        }
    }
}
