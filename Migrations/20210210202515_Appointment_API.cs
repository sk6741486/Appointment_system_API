using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appointment_system_API.Migrations
{
    public partial class Appointment_API : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doctor_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patient_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clinic_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Appointment_date_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "table");
        }
    }
}
