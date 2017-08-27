using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEntrega2908Lp4
{
    class Exercicio7
    {
        public void calcula()
        {
            Console.WriteLine("\n********** 7º Exercicio - Valores de Compras diarios de uma Loja  *********\n");

            ListaCompras compras = new ListaCompras();
            double vista = 0, prazo = 0, todas = 0;

            foreach (Item item in compras.lista)
            {
                if (item.Codigo == "v")
                {
                    vista += item.Valor;
                } else if (item.Codigo == "p")
                {
                    prazo += item.Valor;
                }
                todas += item.Valor;
            }
            Console.WriteLine("\nCompras à vista: " + vista);
            Console.WriteLine("\nCompras a prazo: " + prazo);
            Console.WriteLine("\nTodas as Compras: " + todas);
            Console.WriteLine("\n1ª Parcela a prazo: " + prazo / 3);
        } 
    }

    class ListaCompras
    {
        public List<Item> lista = new List<Item>();
        public ListaCompras()
        {
            for (int i = 0; i < 25; i++)
            {
                lista.Add(new Item(sorteiaValor(), escolheAprazoAvista()));
            }
        }

        public string escolheAprazoAvista()
        {
            int qtdeLetra = 1;
            Random random = new Random();
            const string chars = "vp";
            return new string(Enumerable.Repeat(chars, qtdeLetra)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public double sorteiaValor()
        {
            Random rnd = new Random();
            return rnd.NextDouble() * rnd.Next(50, 1000);
        }
    }

    class Item
    {
        public double Valor { get; private set; }
        public string Codigo { get; private set; }

        public Item(double valor, string codigo)
        {
            this.Valor = valor;
            this.Codigo = codigo;
        }
    }
}
