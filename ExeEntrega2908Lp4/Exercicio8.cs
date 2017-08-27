using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEntrega2908Lp4
{
    class Exercicio8
    {
        public void calcula()
        {
            Console.Write("\n********  8º Exercício - Notas *************");
            Console.Write("\nQuantas notas serão analisadas: ");
            int opcao = Convert.ToInt16(Console.ReadLine());
            double[] notas = new double[opcao];
            double somaNotas = 0;
            for (int i = 0; i < opcao; i++)
            {
                Console.Write("\nDigite a Nota: ");
                double value = Convert.ToDouble(Console.ReadLine());
                notas[i] = value;
                somaNotas += value;

            }
            double media = somaNotas / opcao;

            Console.WriteLine("\nA média das notas é: " + media);

            Console.WriteLine("\nNotas acima da Média: ");
            for (int i = 0; i < opcao; i++)
            {
                if(notas[i] > media)
                {
                    Console.WriteLine(notas[i]);
                }
            }

            Console.WriteLine("\nNotas abaixo da Média: ");
            for (int i = 0; i < opcao; i++)
            {
                if (notas[i] < media)
                {
                    Console.WriteLine(notas[i]);
                }
            }

        }
    }
}
