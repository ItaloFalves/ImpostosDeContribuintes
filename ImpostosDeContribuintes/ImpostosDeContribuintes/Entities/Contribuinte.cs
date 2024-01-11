using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostosDeContribuintes.Entities
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Contribuinte() { }

        protected Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalculoImposto();
    }
}
