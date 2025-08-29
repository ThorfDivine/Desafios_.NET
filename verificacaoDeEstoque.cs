using System;
using System.Collections.Generic;
using System.Linq;

class ECommerceAPI
{
    // Classe Produto para armazenar as informações de cada produto
    class Produto
    {
        public string Nome { get; }
        public double Preco { get; }
        public int QuantidadeEmEstoque { get; }

        // Construtor da classe Produto
        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }
    }

    static void Main()
    {
        // Lê a quantidade de produtos
        int n = int.Parse(Console.ReadLine());

        // Lê a linha com todos os produtos
        string linha = Console.ReadLine();

        // TODO: Crie a lista para armazenar os produtos
        List<Produto> produtos = new List<Produto>();

        // Divide a linha por vírgula para obter os dados de cada produto
        string[] partes = linha.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Processa os dados de produtos
        for (int i = 0; i < n * 3; i += 3)
        {
            string nome = partes[i].Trim();
            double preco = double.Parse(partes[i + 1].Trim());
            int quantidadeEmEstoque = int.Parse(partes[i + 2].Trim());
          
            Produto prod = new Produto(nome, preco, quantidadeEmEstoque);
          
            // TODO: Adicione o produto na lista
            produtos.Add(prod);
        }

        // TODO: Crie a lista para armazenar os produtos com mais de 50 unidades em estoque
        List<Produto> produtosMVP = new List<Produto>();

        // TODO: Filtre os produtos com mais de 50 unidades em estoque
        var nomesProdutosMVP = produtos
          .Where(x => x.QuantidadeEmEstoque > 50)
          .Select(x => x.Nome)  // pega apenas o nome
          .ToList();      
        
        // Exibe os nomes dos produtos com mais de 50 unidades em estoque
        
        Console.WriteLine(string.Join(", ", nomesProdutosMVP));
    }
}
