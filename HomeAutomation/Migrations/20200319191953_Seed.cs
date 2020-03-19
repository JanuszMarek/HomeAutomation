using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeAutomation.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "HA",
                table: "Category",
                columns: new[] { "Id", "CreateDate", "Description", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 3, 19, 20, 19, 53, 324, DateTimeKind.Local).AddTicks(1022), "Możesz zarówno sterować oświetleniem jak również uruchomić schematy automatycznego włączania lub wyłączania poszczególnych punktów oświetlenia w zależności detekcji określonego zjawiska.", "Oświetlenie", new DateTime(2020, 3, 19, 20, 19, 53, 324, DateTimeKind.Local).AddTicks(1079) },
                    { 2L, new DateTime(2020, 3, 19, 20, 19, 53, 324, DateTimeKind.Local).AddTicks(1098), "TV, Audio", "Rozrywka", new DateTime(2020, 3, 19, 20, 19, 53, 324, DateTimeKind.Local).AddTicks(1101) },
                    { 3L, new DateTime(2020, 3, 19, 20, 19, 53, 324, DateTimeKind.Local).AddTicks(1105), "Kamerki, sensory", "Bezpieczeństwo", new DateTime(2020, 3, 19, 20, 19, 53, 324, DateTimeKind.Local).AddTicks(1108) },
                    { 4L, new DateTime(2020, 3, 19, 20, 19, 53, 324, DateTimeKind.Local).AddTicks(1111), "Oczyszczacze, nawilżacze, odkurzacze", "Komfort", new DateTime(2020, 3, 19, 20, 19, 53, 324, DateTimeKind.Local).AddTicks(1113) }
                });

            migrationBuilder.InsertData(
                schema: "HA",
                table: "Producer",
                columns: new[] { "Id", "CreateDate", "Description", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 3, 19, 20, 19, 53, 315, DateTimeKind.Local).AddTicks(9407), "Xiaomi Najlepsze", "Xiaomi", new DateTime(2020, 3, 19, 20, 19, 53, 321, DateTimeKind.Local).AddTicks(3826) },
                    { 2L, new DateTime(2020, 3, 19, 20, 19, 53, 321, DateTimeKind.Local).AddTicks(4726), "Xiaomi Najlepsze", "Xiaomi Aqara", new DateTime(2020, 3, 19, 20, 19, 53, 321, DateTimeKind.Local).AddTicks(4761) },
                    { 3L, new DateTime(2020, 3, 19, 20, 19, 53, 321, DateTimeKind.Local).AddTicks(4787), "Xiaomi Najlepsze", "Xiaomi Mija", new DateTime(2020, 3, 19, 20, 19, 53, 321, DateTimeKind.Local).AddTicks(4792) },
                    { 4L, new DateTime(2020, 3, 19, 20, 19, 53, 321, DateTimeKind.Local).AddTicks(4797), "SONOFF was founded out of a simple need: make your lives easier, smart and better. we’ve the ambition to design and create the most innovative smart products with a simple and affordable way to give you a smarter home.", "Sonoff", new DateTime(2020, 3, 19, 20, 19, 53, 321, DateTimeKind.Local).AddTicks(4800) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "HA",
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "HA",
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "HA",
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "HA",
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "HA",
                table: "Producer",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "HA",
                table: "Producer",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "HA",
                table: "Producer",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "HA",
                table: "Producer",
                keyColumn: "Id",
                keyValue: 4L);
        }
    }
}
