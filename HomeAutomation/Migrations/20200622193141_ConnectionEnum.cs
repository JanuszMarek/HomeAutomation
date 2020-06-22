using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeAutomation.Migrations
{
    public partial class ConnectionEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Connection",
                schema: "HA",
                table: "Device",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Connection",
                schema: "HA",
                table: "Device");
        }
    }
}
