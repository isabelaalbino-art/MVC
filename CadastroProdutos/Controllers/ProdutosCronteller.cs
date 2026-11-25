using CadastroProdutos.Models;
using Microsoft.AspNetCore.Mvc;
// importa recursos do framework - 

namespace CadastroProdutos.Controllers;
// organiza as classes

public class ProdutosController : Controller
//          Nome do Crontroller   Herança da calsse controller
{
    public IActionResult Index()
    // IActionResult = Tipo de retorno da ação
    //Index =  Método responsável pela página inicial
    {
        var produtos = new List<Produto>
        {
            new Produto
            {
                Id=1,
                Nome="Teclado",
                Preco=129.90m,
                Estoque=15
        },
               new Produto
            {
                Id=2,
                Nome="Mouse",
                Preco=59.90m,
                Estoque=20
        },
               new Produto
            {
                Id=3,
                Nome="Monitor",
                Preco=399.90m,
                Estoque=5
        }
        };


        return View(produtos);
       // return Content("Página de produtos");
        //Content = retorna contúdo textual
    }
}
