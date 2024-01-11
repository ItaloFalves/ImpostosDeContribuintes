using ImpostosDeContribuintes.Entities;
using System;

namespace ImpostosDeContribuintes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> listaContribuinte = new List<Contribuinte>();

            Console.Write("Informe o numero de contribuintes: ");
            int numContribuintes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numContribuintes; i++)
            {
                Console.Write("Pessoa Fisica ou Pessoa Juridica? (F/J)");
                char pessoa = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double renda = double.Parse(Console.ReadLine());

                if (pessoa == 'F')
                {
                    Console.Write("Gastos com saude: ");
                    double saude = double.Parse(Console.ReadLine());

                    listaContribuinte.Add(new PessoaFisica(nome, renda, saude));
                }
                else
                {
                    Console.Write("Quantidade de funcionarios: ");
                    int funcionario = int.Parse(Console.ReadLine());

                    listaContribuinte.Add(new PessoaJuridica(nome, renda, funcionario));
                }
            }

            Console.WriteLine();
            Console.WriteLine("IMPOSTOS PAGOS: ");

            foreach(Contribuinte list in listaContribuinte)
            {
                Console.WriteLine(list.ToString());
            }

            Console.WriteLine();
            double totalImpostos = 0.00;

            foreach(Contribuinte list in listaContribuinte)
            {
                totalImpostos += list.CalculoImposto();
            }

            Console.Write("Total de impostos: " + totalImpostos.ToString("F2"));
            Console.WriteLine();
        }
    }
}