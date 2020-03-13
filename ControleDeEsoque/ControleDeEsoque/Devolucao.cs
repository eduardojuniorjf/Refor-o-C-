using ControleDeEstoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEsoque
{
    class Devolucao : Vendas {
        public bool DevolucaoCarro() {
            this.Carro = Carro - 1;
            return true;
            
        }

    }
}
