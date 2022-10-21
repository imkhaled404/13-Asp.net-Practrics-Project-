using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpenseTracker.Migrations
{
    public partial class khaled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpenseDate",
                table: "Expenses",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Expenses",
                type: "Expense Category",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemNO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IfsCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GWTPC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HsCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LengthCtn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SbGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackSUdom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeightCtn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ifscode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeightCtn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PcsPerCtn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemNO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpenseDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Expense Category");
        }
    }
}
