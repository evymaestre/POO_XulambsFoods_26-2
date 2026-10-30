using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    internal class Sobremesa : ItemPedido
    {
        private ESobremesa _tipo;

        public Sobremesa(ESobremesa tipo)
        {
            _tipo = tipo;
        }

        public override double CalcularValorFinal()
        {
            return _tipo.Valor();
        }

        public override string ToString()
        {
            return $"{_tipo.Descricao()} - {CalcularValorFinal():C2}";
        }
    }
}
