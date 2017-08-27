using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEntrega2908Lp4
{
    class Exercicio10
    {
        public void calcula()
        {
            Console.WriteLine("\n********* 10º Exercício - Reajustes de Salário *********\n");
            List<double> salarios = new List<double>();
            double salario = 0;
            do
            {
                Console.Write("\nEntre com o salario ou -1 para encerrar: ");
                salario = Convert.ToDouble(Console.ReadLine());
                salarios.Add(salario);

            } while (salario != -1);

            Console.Write("\nInforme o valor de reajuste: ");
            double reajuste = Convert.ToDouble(Console.ReadLine());
            int qtde = 1;
            Console.Write("\nSegue os salários reajustados: /n");
            foreach (double item in salarios)
            {
                Console.WriteLine("\nsalario numero " + qtde++ + " - valor: "+(item+reajuste));
            }
        }
    }
}
