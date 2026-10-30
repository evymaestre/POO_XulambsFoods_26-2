using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    internal class Bebida
    {
        private EBebida _tipo;

        public Bebida(ESobremesa tipo)
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
