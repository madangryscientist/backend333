﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend333.Migrations
{
    public partial class faqNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "questionAsked",
                table: "Faqs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "questionAsked",
                table: "Faqs");
        }
    }
}
