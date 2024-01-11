using ImpostosDeContribuintes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostosDeContribuintes
{
     class PessoaFisica : Contribuinte
    {

        const double RENDA = 20000.0;
        public double GastosSaude { get; set; }

        public PessoaFisica (string nome, double renda, double gastosSaude) : base(nome, renda)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalculoImposto()
        {
            if (RendaAnual < RENDA )
            {
                return RendaAnual * 0.15 - GastosSaude * 0.5;
            }
            else
            {
                return RendaAnual * 0.25 - GastosSaude * 0.5;
            }
        }

           public override string ToString()
        {
            return Nome +
                " : $ " +
                CalculoImposto().ToString("F2");
        }
    }
}
