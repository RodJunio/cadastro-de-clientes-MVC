using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc_entity.Migrations
{
    public partial class Modelocliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    DataNascimento = table.Column<DateTime>(name: "Data/Nascimento", type: "Datetime", nullable: false),
                    telefone = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true),
                    rua = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    numero = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: true),
                    bairro = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    cidade = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    estado = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
