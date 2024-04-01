using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    internal class Produto
    {
        public string Nome;
        public double Valor;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Valor * Quantidade;
        }

        public double AdicionarProduto(int quant)
        {
            Quantidade += quant;
            return Quantidade;
        }

        public double RemoverProduto(int quant)
        {
            return Quantidade -= quant;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} |" +
                $" Preço: {Valor.ToString("c")} |" +
                $" Quantidade: {Quantidade} |" +
                $" Valor total: {ValorTotalEstoque().ToString("c")}";
        }
    }
}
