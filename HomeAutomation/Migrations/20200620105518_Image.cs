using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeAutomation.Migrations
{
    public partial class Image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ImageId",
                schema: "HA",
                table: "Producer",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ImageId",
                schema: "HA",
                table: "DeviceType",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ImageId",
                schema: "HA",
                table: "Device",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ImageId",
                schema: "HA",
                table: "Category",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Image",
                schema: "HA",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    FilePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Producer_ImageId",
                schema: "HA",
                table: "Producer",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceType_ImageId",
                schema: "HA",
                table: "DeviceType",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Device_ImageId",
                schema: "HA",
                table: "Device",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ImageId",
                schema: "HA",
                table: "Category",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Image_ImageId",
                schema: "HA",
                table: "Category",
                column: "ImageId",
                principalSchema: "HA",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Device_Image_ImageId",
                schema: "HA",
                table: "Device",
                column: "ImageId",
                principalSchema: "HA",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeviceType_Image_ImageId",
                schema: "HA",
                table: "DeviceType",
                column: "ImageId",
                principalSchema: "HA",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producer_Image_ImageId",
                schema: "HA",
                table: "Producer",
                column: "ImageId",
                principalSchema: "HA",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Image_ImageId",
                schema: "HA",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Device_Image_ImageId",
                schema: "HA",
                table: "Device");

            migrationBuilder.DropForeignKey(
                name: "FK_DeviceType_Image_ImageId",
                schema: "HA",
                table: "DeviceType");

            migrationBuilder.DropForeignKey(
                name: "FK_Producer_Image_ImageId",
                schema: "HA",
                table: "Producer");

            migrationBuilder.DropTable(
                name: "Image",
                schema: "HA");

            migrationBuilder.DropIndex(
                name: "IX_Producer_ImageId",
                schema: "HA",
                table: "Producer");

            migrationBuilder.DropIndex(
                name: "IX_DeviceType_ImageId",
                schema: "HA",
                table: "DeviceType");

            migrationBuilder.DropIndex(
                name: "IX_Device_ImageId",
                schema: "HA",
                table: "Device");

            migrationBuilder.DropIndex(
                name: "IX_Category_ImageId",
                schema: "HA",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ImageId",
                schema: "HA",
                table: "Producer");

            migrationBuilder.DropColumn(
                name: "ImageId",
                schema: "HA",
                table: "DeviceType");

            migrationBuilder.DropColumn(
                name: "ImageId",
                schema: "HA",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "ImageId",
                schema: "HA",
                table: "Category");
        }
    }
}
