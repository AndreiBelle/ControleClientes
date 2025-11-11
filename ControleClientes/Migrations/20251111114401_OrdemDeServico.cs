using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleClientes.Migrations
{
    /// <inheritdoc />
    public partial class OrdemDeServico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "OrdemServico",
                newName: "Quantidade");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "OrdemServico",
                newName: "quantidade");
        }
    }
}
