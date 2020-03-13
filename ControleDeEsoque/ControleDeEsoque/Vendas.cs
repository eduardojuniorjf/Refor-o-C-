using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    class Vendas
    {
        /// <summary>
        /// Não pode ser acessada por outras classes, por isso e private
        /// </summary>
        public int Carro { get; set; } //prop + tab 2x - Variavel Global sempre com primeira maiuscula

        /// <summary>
        /// Metodo Construtor
        /// Semre iniciado com 10
        /// </summary>
        public Vendas() {
            this.Carro = 10;
        }

        /// <summary>
        /// Vende Carro
        /// </summary>
        /// <returns>
        /// A função retorna se o carro foi vendido
        /// </returns>
        public Boolean VendaDeCarro(int quant) {
            this.Carro = Carro - quant;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void ImprimeCarros(){
            Console.WriteLine(Carro.ToString());
        }

    }
}
