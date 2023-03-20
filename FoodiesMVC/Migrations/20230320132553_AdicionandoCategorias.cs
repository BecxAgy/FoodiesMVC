using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiesMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome, Descricao)" +
                "VALUES('Pizzas', 'Pizzas de todos os sabores, com bordas recheadas da sua preferência')");
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome, Descricao)" +
                "VALUES('Bebidas', 'Bebidas geladas para acompanhar ou não o seu prato')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
