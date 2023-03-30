using FoodiesMVC.Models;
using FoodiesMVC.Repositories.Interfaces;
using FoodiesMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FoodiesMVC.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _repository;
        private readonly CarrinhoCompra _carrinho;

        public CarrinhoCompraController(ILancheRepository repository, CarrinhoCompra carrinho)
        {
            _repository = repository;
            _carrinho = carrinho;
        }

        public IActionResult Index()
        {
            //variável que irá armazenar um novo carrinho ou o carrinho ja utilizado pela Session, isso depende de
            //como o método será utilizado
            var carrinhoCompras = _carrinho.GetCarrinhoCompraItens();

            //Atribuindo o carrinho de compras do usuário
            _carrinho.CarrinhoCompraItens = carrinhoCompras;

            CarrinhoCompraViewModel carrinhoVM = new CarrinhoCompraViewModel
            {
                Carrinho = _carrinho,
                ValorTotal = _carrinho.GetValorTotal(),

            };

            return View(carrinhoVM);
        }

        public RedirectToActionResult AdicionarItem(int lancheId)
        {
            var lanche = _repository.Lanches.FirstOrDefault(l => l.LancheId == lancheId);

            if (lanche!=null)
            {
                _carrinho.AdicionarItem(lanche);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoverItem(int lancheId)
        {
            var lanche = _repository.Lanches.FirstOrDefault(l => l.LancheId == lancheId);

            if (lanche != null)
            {
                _carrinho.RemoverItem(lanche);
            }

            return RedirectToAction("Index");
        }
    }
}
