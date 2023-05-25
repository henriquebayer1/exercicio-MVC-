using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetoConsole.Model;

namespace projetoConsole.View
{
    public class ProdutoView
    {
        

public void Listar(List<Produto> produto)
{


foreach (var item in produto)
{


    Console.WriteLine($"\nCodigo: {item.Codigo}");
    Console.WriteLine($"Nome: {item.Nome}");
    Console.WriteLine($"Preco: {item.Preco:C}");
    
    
}

}





public Produto Cadastrar()
{

    Produto novoProduto = new Produto();

Console.WriteLine($"Digite o codigo do produto:");
novoProduto.Codigo = int.Parse(Console.ReadLine());


Console.WriteLine($"Digite o nome do produto:");
novoProduto.Nome = Console.ReadLine();


Console.WriteLine($"Digite o preco do produto:");
novoProduto.Preco = float.Parse(Console.ReadLine());


return novoProduto;


}

    }
}