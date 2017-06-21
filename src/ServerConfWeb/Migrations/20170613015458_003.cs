using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerConfWeb.Migrations
{
    public partial class _003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Configuracoes");

            migrationBuilder.CreateTable(
                name: "Monitoramentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false),
                    PacketsIn = table.Column<long>(nullable: false),
                    PacketsOut = table.Column<long>(nullable: false),
                    PercentualUsoCPU = table.Column<string>(nullable: true),
                    ServidorId = table.Column<Guid>(nullable: false),
                    TamanhoDisco = table.Column<string>(nullable: true),
                    TotalDiscoEmUso = table.Column<string>(nullable: true),
                    TotalMemoria = table.Column<string>(nullable: true),
                    TotalMemoriaEmUso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitoramentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitoramentos_Servidores_ServidorId",
                        column: x => x.ServidorId,
                        principalTable: "Servidores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddColumn<string>(
                name: "AlgoritmoAutenticacao",
                table: "Servidores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlgoritmoCriptografia",
                table: "Servidores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Oids",
                table: "Servidores",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Periodicidade",
                table: "Servidores",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "SecurityLevel",
                table: "Servidores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SecurityName",
                table: "Servidores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenhaAutenticacao",
                table: "Servidores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenhaCriptografia",
                table: "Servidores",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Timeout",
                table: "Servidores",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Servidores",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VersionSnmp",
                table: "Servidores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataHora",
                table: "Configuracoes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Monitoramentos_ServidorId",
                table: "Monitoramentos",
                column: "ServidorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlgoritmoAutenticacao",
                table: "Servidores");

            migrationBuilder.DropColumn(
                name: "AlgoritmoCriptografia",
                table: "Servidores");

            migrationBuilder.DropColumn(
                name: "Oids",
                table: "Servidores");

            migrationBuilder.DropColumn(
                name: "Periodicidade",
                table: "Servidores");

            migrationBuilder.DropColumn(
                name: "SecurityLevel",
                table: "Servidores");

            migrationBuilder.DropColumn(
                name: "SecurityName",
                table: "Servidores");

            migrationBuilder.DropColumn(
                name: "SenhaAutenticacao",
                table: "Servidores");

            migrationBuilder.DropColumn(
                name: "SenhaCriptografia",
                table: "Servidores");

            migrationBuilder.DropColumn(
                name: "Timeout",
                table: "Servidores");

            migrationBuilder.DropColumn(
                name: "User",
                table: "Servidores");

            migrationBuilder.DropColumn(
                name: "VersionSnmp",
                table: "Servidores");

            migrationBuilder.DropColumn(
                name: "DataHora",
                table: "Configuracoes");

            migrationBuilder.DropTable(
                name: "Monitoramentos");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Configuracoes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
