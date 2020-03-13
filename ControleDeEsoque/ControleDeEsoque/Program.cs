using ControleDeEsoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendas venda = new Vendas();

            var vendido = venda.VendaDeCarro(1); // passa o valor de quant por referencia, que será subtraido do numero de carros

            if (vendido)
                venda.ImprimeCarros();

            var devolve = new Devolucao();
            devolve.DevolucaoCarro();

            Console.ReadLine();


            devolve.ImprimeCarros();
        }
    }
}
