using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class Edit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Products");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsHome",
                table: "Products",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "148ab2ac-5d03-481b-8b89-f9f70d8cc914", "eb77a35b-ba61-42e9-823c-232d1a310998", "Admin", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsHome", "Name", "ParentId", "SortOrder" },
                values: new object[] { 2, true, "Dilmah", null, 1 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsHome", "Name", "ParentId", "SortOrder" },
                values: new object[] { 1, true, "Ahmad", null, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Description", "Frame", "IsHome", "Name", "Price" },
                values: new object[] { 1, 1, new DateTime(2021, 11, 4, 7, 23, 44, 861, DateTimeKind.Local).AddTicks(4972), "Trà Anh Quốc", "Image/1.jpg", true, "English Breakfast", 1000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Description", "Frame", "IsHome", "Name", "Price" },
                values: new object[] { 2, 1, new DateTime(2021, 11, 4, 7, 23, 44, 862, DateTimeKind.Local).AddTicks(4090), "Trà Bá Tước", "Image/1.jpg", true, "EarlGrey", 1000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Description", "Frame", "IsHome", "Name", "Price" },
                values: new object[] { 3, 2, new DateTime(2021, 11, 4, 7, 23, 44, 862, DateTimeKind.Local).AddTicks(4114), "Trà Bạc Hà", "Image/1.jpg", true, "Mint", 1000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "148ab2ac-5d03-481b-8b89-f9f70d8cc914");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsHome",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId1",
                table: "Products",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId1",
                table: "Products",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
