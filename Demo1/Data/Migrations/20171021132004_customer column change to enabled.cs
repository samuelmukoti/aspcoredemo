using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Demo1.Data.Migrations
{
    public partial class customercolumnchangetoenabled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Customer");

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Customer",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Customer");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Customer",
                nullable: false,
                defaultValue: false);
        }
    }
}
