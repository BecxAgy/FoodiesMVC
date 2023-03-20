using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiesMVC.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" + 
                "VALUES('Saudáveis', 'Lanche feito com ingredientes orgânicos e que visam melhorar sua saúde')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Doces', 'Doces com o toque especial da casa - extremo carinho e boas pitadas de acúcar')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Massas', 'Pratos com toques italianos e permeados da experiência que as massas podem proporcionar')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
               "VALUES('Fast Food', 'Lanches rápidos e ótimos para descontrair durante os dias')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
