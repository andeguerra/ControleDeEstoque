using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto i = new Produto();
            Console.WriteLine("Entre com os dados do estoque:");
            Console.Write("Nome do produto: ");
            i.Nome = Console.ReadLine();

            Console.Write("Preço do produto: ");
            i.Valor = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            i.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"{i}");

            Console.Write("\nQuantos produtos gostaria de adicionar ao estoque? ");
            int quant = int.Parse(Console.ReadLine());

            i.AdicionarProduto(quant);

            Console.WriteLine($"Dados Atualizados: {i}");

            Console.Write("\nQuantos produtos gostaria de remover do estoque? ");
            quant = int.Parse(Console.ReadLine());

            i.RemoverProduto(quant);

            Console.WriteLine($"Dados Atualizados: {i}");

            Console.ReadKey();
            

        }
    }
}
