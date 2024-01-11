using ImpostosDeContribuintes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostosDeContribuintes
{
     class PessoaJuridica : Contribuinte
    {

        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double renda, int numeroFuncionarios) : base(nome, renda)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalculoImposto()
        {
            if (NumeroFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
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
