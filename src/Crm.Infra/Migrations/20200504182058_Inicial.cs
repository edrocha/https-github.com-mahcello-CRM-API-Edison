using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Crm.Infra.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    cliID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliNome = table.Column<string>(nullable: true),
                    cliEmail = table.Column<string>(nullable: true),
                    cliData = table.Column<DateTime>(nullable: false),
                    cliSexo = table.Column<int>(nullable: false),
                    cliAtivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.cliID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
