using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergeticosAccelerator
{
    internal class Supermercado
    {
        public String Nome { get; set; }
        public double Valor  { get; set; }
        public int Unidade { get; set; }
        public double Total { get; set; }

        public Supermercado(string nome, int unidade)
        {
            Nome = nome;
            Unidade = unidade;
            Valor = (double)(unidade * 4.50);
            Total = total(Valor);
        }

        public double total(double valor)
        {
            double totalAux = valor + icms() + ipi() + pis() + cofins();
            totalAux = totalAux - (totalAux * desconto());
            return totalAux;
        }

        public double icms()
        {
            double aux = Valor;
            aux *= 0.18;
            return aux;
        }
        public double ipi()
        {
            double aux = Valor;
            return aux * 0.04;
        }
        public double pis()
        {
            double aux = Valor;
            return aux * 0.0186;
        }
        public double cofins()
        {
            double aux = Valor;
            return aux * 0.0854;
        }
        public double desconto()
        {
            double desc=0.0;
            if (Unidade>=50 && Unidade<=99)
            {
                desc = 0.05;
                return desc;
            }else if(Unidade>=100 && Unidade <= 199)
            {
                desc = 0.1;
                return desc;
            }
            else if(Unidade >=200)
            {
                desc = 0.2;
                return desc;
            }
            return desc;
        }

        public override string ToString()
        {
            return "Cliente: " + Nome
                + "\nICMS: R$" + icms() 
                + " IPI: R$" + ipi()
                +" PIS: R$"+pis()
                +" COFINS: R$"+cofins()
                +" Total: R$"+Total
                +" Desconto Aplicado: "+desconto()*100+"%";
        }
    }
}
