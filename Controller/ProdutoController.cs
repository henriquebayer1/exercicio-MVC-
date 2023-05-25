using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetoConsole.Model;
using projetoConsole.View;

namespace projetoConsole.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();


        public void Listar()
        {
           List<Produto> produtos = produto.Ler();

        produtoView.Listar(produtos);

        }

public void CadastrarProduto()
{
Produto novoProduto = produtoView.Cadastrar();


produto.Inserir(novoProduto);

}




    }
}