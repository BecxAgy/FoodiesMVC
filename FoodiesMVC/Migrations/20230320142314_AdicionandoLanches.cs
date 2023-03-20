using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiesMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
                "VALUES('Drink Blackberry', 'Drink alcoólico (Vodka ou Gin) feito com blackberries frescas', 19.99 , 1, 0, 6,'../images/img/cauliflower-vegan.jpg','../images/img/cauliflower-vegan.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
                "VALUES('Suco de Laranja', 'Suco da fruta laranja natural, com toques cítricos e doces', 7.50, 1, 0, 6,'../images/img/suco-laranja.jpg','../images/img/suco-laranja.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
                "VALUES('Suco de Morango', 'Suco de morango fresco com frutas selecionadas', 9.99, 1, 0, 6,'../images/img/suco-morango.jpg','../images/img/suco-morango.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
                "VALUES('Suco de Kiwi', 'Suco de kiwi fresco com frutas selecionadas', 9.99, 1, 0, 6,'../images/img/suco-kiwi.jpg','../images/img/suco-kiwi.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
                "VALUES('Limonada', 'Limonada especial da casa bem gelado', 9.99, 1, 0, 6,'../images/img/limonada.jpg','../images/img/limonada.jpg')");


            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
                "VALUES('Taco de Couve-Flor', 'Tacos veganos especiais de couve-flor gratinado na chapa', 25.99, 1, 0, 1,'../images/img/cauliflower-vegan.jpg','../images/img/cauliflower-vegan.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
               "VALUES('Sanduíche Natural', 'Sanduíche da casa com alface, tomate, cenoura e repolho refogado', 6.99, 1, 0, 1,'../images/img/img-3.jpg','../images/img/img-3.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
               "VALUES('Tortilha', 'Tortilha recheada com cenoura e frango grelhado', 12.99, 1, 0, 1,'../images/img/img-4.jpg','../images/img/img-4.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
               "VALUES('Salada de Ricota', 'Salada temperada com queijo ricota feito pela casa', 15.50, 1, 0, 1,'../images/img/salada-queijo.jpg','../images/img/salada-queijo.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
               "VALUES('Ratatouille', 'O prato mais desejado da casa! O Ratatouille é um prato francês que causa diversas sensações pois é feito sempre pelo chefe da casa',45.99, 1, 0, 1,'../images/img/ratatouille.jpg','../images/img/ratatouille.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
               "VALUES('Salada de legumes', 'Salada com deliciosos e grelhados bróclis, cenouras, laranja, pepino e frango', 25.99, 1, 0, 1,'../images/img/vegetais-frango.png','../images/img/vegetais-frango.png')");

            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
               "VALUES('Panqueca de Morango e Nutella', 'Panqueca de chocolate recheada com morangos e nutella', 19.99, 1, 0, 2,'../images/img/panqueca-morango.jpg','../images/img/panqueca-morango.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
              "VALUES('Milkshake de Oreo', 'Delicioso milkshake de oreo', 19.99, 1, 0, 2,'../images/img/milkshake-oreo.jpg','../images/img/milkshake-oreo.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
              "VALUES('Torta de Morango', 'Torta de morango com creme de baunilha', 19.99, 1, 0, 2,'../images/img/img-5.jpg','../images/img/img-5.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
              "VALUES('Geleia de Morango', 'Pote de geleia de morango com creme de frutas vermelhas', 12.99, 1, 0, 2,'../images/img/geleia-morango.jpg','../images/img/geleia-morango.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
              "VALUES('Brownie de Nutella', 'Brownie de cacau com recheio de nutella', 14.50, 1, 0, 2,'../images/img/brownie.jpg','../images/img/brownie.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
              "VALUES('Bolinhos de Oreo', 'Bolinhos deliciosos recheados com um especial creme de oreo', 17.50, 1, 0, 2,'../images/img/bolinhos-oreo.jpg','../images/img/bolinhos-oreo.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
             "VALUES('Bolinhos de Oreo', 'Bolinhos deliciosos recheados com um especial creme de oreo', 17.50, 1, 0, 2,'../images/img/bolinhos-oreo.jpg','../images/img/bolinhos-oreo.jpg')");


            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
             "VALUES('Massa Alfredo', 'Massa italiana ao molho alfredo', 37.50, 1, 0, 3,'../images/img/massa-alfredo','../images/img/massa-alfredo.png')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
             "VALUES('Massa Camarão', 'Massa italiana ao molho cremoso com porções de camarão', 52.50, 1, 0, 3,'../images/img/massa-camarao','../images/img/massa-camarao.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
             "VALUES('Massa de Espinafre', 'Massa de espinafre com toques cítricos e suaves', 47.50, 1, 0, 3,'../images/img/massa-espinafre','../images/img/massa-espinafre.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
             "VALUES('Massa Italiana', 'Massa italiana tradicional ao molho bolonhesa', 32.90, 1, 0, 3,'../images/img/massa-italiana','../images/img/massa-italiana.jpg')");

            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
             "VALUES('Porção de Frango com Batatas', 'Frango frito com batatas suculentas e pepitos', 33.50, 1, 0, 4,'../images/img/frango-frito.jpg','../images/img/frango-frito.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
             "VALUES('Cheeseburguer', 'Cheeseburguer com cebolas fritas, blend de carne de 180g, queijo mussarela, alface tomate e pão batata', 19.50, 1, 0, 4,'../images/img/cheeseburguer.jpg','../images/img/cheeseburguer.jpg')");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, EmEstoque, IsFavorito, CategoriaId, ImagemUrl, ImagemThumbnailUrl)" +
             "VALUES('Combo Hamburguer MAX', 'Combo! Hamburguer com blend de 180g, alface tomate, molho da casa e cebola + porção de batata frita + refrigerante gelado', 30.50, 1, 0, 4,'../images/img/combo-hamburguer.jpg','../images/img/combo-hamburguer.jpg')");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
