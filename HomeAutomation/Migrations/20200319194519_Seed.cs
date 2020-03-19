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
                    { 1L, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Możesz zarówno sterować oświetleniem jak również uruchomić schematy automatycznego włączania lub wyłączania poszczególnych punktów oświetlenia w zależności detekcji określonego zjawiska.", "Oświetlenie", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TV, Audio", "Rozrywka", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kamerki, sensory", "Bezpieczeństwo", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oczyszczacze, nawilżacze, odkurzacze", "Komfort", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "HA",
                table: "Producer",
                columns: new[] { "Id", "CreateDate", "Description", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Najlepsze", "Xiaomi", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Najlepsze", "Xiaomi Aqara", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xiaomi Najlepsze", "Xiaomi Mija", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SONOFF was founded out of a simple need: make your lives easier, smart and better. we’ve the ambition to design and create the most innovative smart products with a simple and affordable way to give you a smarter home.", "Sonoff", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
