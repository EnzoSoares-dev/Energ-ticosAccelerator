using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticosAccelerator
{
    internal class Program
    {
        static void Main()
        {
            List<Supermercado> clientes = new List<Supermercado>();
            char resp='s';
            while (resp != 'n')
            {
                string cliente;
                int unidade;
                Console.WriteLine("Qual o nome do cliente?");
                cliente = Console.ReadLine();
                Console.WriteLine("Quantas unidades serão?");
                unidade = int.Parse(Console.ReadLine());
                clientes.Add(new Supermercado(cliente, unidade));
                Console.WriteLine("Irá adicionar mais um cliente?");
                resp = char.Parse(Console.ReadLine());
                Console.Clear();
            }
            foreach(Supermercado super  in clientes)
            {
                Console.WriteLine(super);
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
        static void TotalGeral(List<Supermercado> super) 
        {
            double impostos, geral, mercadorias;
            foreach(Supermercado mercados in super)
            {
                impostos += mercados.icms();
            }
        }
    }
}
