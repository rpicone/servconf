using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerConfWeb.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servidores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EnderecoIP = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    SistemaOperacional = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servidores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Configuracoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Conteudo = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    ServicoNome = table.Column<string>(nullable: true),
                    ServidorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuracoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Configuracoes_Servidores_ServidorId",
                        column: x => x.ServidorId,
                        principalTable: "Servidores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Configuracoes_ServidorId",
                table: "Configuracoes",
                column: "ServidorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuracoes");

            migrationBuilder.DropTable(
                name: "Servidores");
        }
    }
}
