

namespace projetoConsole.Model
{
    public class Produto
    {
        public int Codigo {get; set;}
        public string Nome {get; set;}
        public float Preco {get; set;}

        
        
        private const string PATH = "Database/Produto.csv";


public Produto()
{
    string pasta = PATH.Split("/")[0];

    if (!Directory.Exists(pasta))
    {
        Directory.CreateDirectory(pasta);
    }

    if (!File.Exists(PATH))
    {
        File.Create(PATH);
    }




}



public List<Produto> Ler()
{

List<Produto> produtos = new List<Produto>();

string[] linhas = File.ReadAllLines(PATH);

foreach (string item in linhas)
{
    string[] dados = item.Split(";");

Produto p = new Produto();


p.Codigo = int.Parse(dados[0]);
p.Nome = dados[1];
p.Preco = float.Parse(dados[2]);

produtos.Add(p);


}
return produtos;

}



public string PrepararLinhasCSV(Produto p)
{



    return $"{p.Codigo};{p.Nome};{p.Preco}";
}


public void Inserir(Produto p)
{

string[] linhas = {PrepararLinhasCSV(p)};


File.AppendAllLines(PATH, linhas);

}


    }
}