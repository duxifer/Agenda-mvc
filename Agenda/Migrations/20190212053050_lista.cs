﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Agenda.Migrations
{
    public partial class lista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Registro",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Tipo",
                table: "Registro",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
