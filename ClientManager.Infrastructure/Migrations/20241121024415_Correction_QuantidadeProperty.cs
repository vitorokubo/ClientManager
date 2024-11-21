using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientManager.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Correction_QuantidadeProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuatidadeVendida",
                table: "ProdutoVendas",
                newName: "QuantidadeVendida");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuantidadeVendida",
                table: "ProdutoVendas",
                newName: "QuatidadeVendida");
        }
    }
}
