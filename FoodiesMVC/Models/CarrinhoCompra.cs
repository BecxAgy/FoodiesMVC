using FoodiesMVC.Context;
using Microsoft.EntityFrameworkCore;

namespace FoodiesMVC.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _context;
        public  string CarrinhoCompraId { get; set; }
        public  List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;      
        }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            //Definição de uma sessão
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //Obtendo um gerando um tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            //Obtendo ou gerando um id para o carrinho de compra
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            //Atribui o id do carrinho na sessão
            session.SetString("CarrinhoId", carrinhoId);

            return new CarrinhoCompra(context) { CarrinhoCompraId = carrinhoId };
        }

        public void AdicionarItem(Lanche lanche)
        {
            //Primeiro devemos achar no carrinhoCompras do banco um lanche igual ao que está sendo passad por parâmetro e verificar
            //também se está no mesmo carrinhho de compra. Faremos essa lógicapara saber se iremos criar um carrinhocompraitem ou
            //se vamos apenas setar a quantidade daquele item no carrinho
            var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(item => item.Lanche.LancheId == lanche.LancheId 
            && item.CarrinhoCompraId == CarrinhoCompraId);

            if(carrinhoCompraItem == null)
            {
                var item = new CarrinhoCompraItem()
                {
                    CarrinhoCompraId = CarrinhoCompraId,//definido pela session
                    Lanche = lanche,//passado por parâmetro
                    Quantidade = 1 //valor inicial
                };

                CarrinhoCompraItens.Add(item);
            }
            else
            {
                carrinhoCompraItem.Quantidade++;
            }

            _context.SaveChanges();
        }

        public void RemoverItem(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(item => item.Lanche.LancheId == lanche.LancheId
            && item.CarrinhoCompraId == CarrinhoCompraId);

            if(carrinhoCompraItem != null)
            {
                if(carrinhoCompraItem.Quantidade > 1)
                {
                    carrinhoCompraItem.Quantidade--;
                }
                else
                {
                    CarrinhoCompraItens.Remove(carrinhoCompraItem);
                }
            }
        }


        public List<CarrinhoCompraItem> GetCarrinhoCompraItens()
        {
            return CarrinhoCompraItens ?? (CarrinhoCompraItens = _context.CarrinhoCompraItens.
                Where(c => c.CarrinhoCompraId == CarrinhoCompraId).
                Include(s => s.Lanche).
                ToList());
        }


        public void LimparCarrinho()
        {
            var carrinho = _context.CarrinhoCompraItens.Where(c => c.CarrinhoCompraId == CarrinhoCompraId);

            _context.CarrinhoCompraItens.RemoveRange(carrinho);

            _context.SaveChanges();
        }


        public decimal GetValorTotal()
        {
            //obtenho a lista e vou somando os valores selecionados
            var total =  _context.CarrinhoCompraItens.
                Where(c => c.CarrinhoCompraId == CarrinhoCompraId).
                Select(item => item.Quantidade * item.Lanche.Preco).Sum();

            return total;
        }
    }
}
