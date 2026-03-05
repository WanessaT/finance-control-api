using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FinanceControl.API.Migrations
{
    /// <inheritdoc />
    public partial class Add_TabelaTransacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "transacoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    titulo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    descricao = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    quantia = table.Column<string>(type: "text", nullable: false),
                    tipoTransacao = table.Column<int>(type: "integer", nullable: false),
                    categoriaId = table.Column<int>(type: "integer", nullable: true),
                    usuarioId = table.Column<int>(type: "integer", nullable: true),
                    data = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    criadoEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    editadoEm = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transacoes", x => x.id);
                    table.ForeignKey(
                        name: "FK_transacoes_categorias_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "categorias",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_transacoes_usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "usuarios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_transacoes_categoriaId",
                table: "transacoes",
                column: "categoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_transacoes_usuarioId",
                table: "transacoes",
                column: "usuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transacoes");
        }
    }
}
