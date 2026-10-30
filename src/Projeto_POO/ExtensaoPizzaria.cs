using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public static class ExtensaoPizzaria
    {
        public static double Valor(this EBorda borda)
        {
            return borda switch
            {
                EBorda.Chocolate => 8,
                EBorda.Cheddar => 10,
                EBorda.Requeijao => 7,
                _ => 0
            };
        }

        public static ETaxaEntrega DefinirEntrega(this double distancia)
        {
            return distancia switch
            {
                (<= 4) => ETaxaEntrega.Curta,
                (> 4 and <= 8) => ETaxaEntrega.Media,
                (> 8) => ETaxaEntrega.Longa
            };
        }
        public static double ValorTaxa(this ETaxaEntrega distancia)
        {
            return distancia switch
            {
                ETaxaEntrega.Curta => 0,
                ETaxaEntrega.Media => 5,
                ETaxaEntrega.Longa => 8,
                _ => 0
            };
        }

        public static double Valor(this ESobremesa sobremesa)
        {
            switch (sobremesa)
            {
                case ESobremesa.Brigadeiro:
                    return 8d;
                case ESobremesa.Pudim:
                    return 10d;
                case ESobremesa.DoceDeLeite:
                    return 9d;
                default:
                    return 0d;
            }
        }

        public static string Descricao(this ESobremesa sobremesa)
        {
            switch (sobremesa)
            {
                case ESobremesa.Brigadeiro:
                    return "Brigadeiro na colher";
                case ESobremesa.Pudim:
                    return "Pudim de leite condensado";
                case ESobremesa.DoceDeLeite:
                    return "Doce de leite no pires";
                default:
                    return sobremesa.ToString();
            }
        }
    }
}
