using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEntrega2908Lp4
{
    class Exercicio6
    {
        public void calcula()
        {
            Console.WriteLine("\n********  6º Exercicio - Tabuada escolhida pelo usuario   **********\n");
            int numero = leDeNovo();
            while (numero != -1)
            {
                
                for (int i = 1; i < 11; i++)
                {
                    Console.Write(i * numero);

                    if (i != 10)
                    {
                        Console.Write(" - ");
                    }
                }
                numero = leDeNovo();
            }
            Console.WriteLine();
        }
        public int leDeNovo()
        {
            Console.Write("\nEntre com um numero para saber a taboada ou -1 para sair: ");
            return Convert.ToInt16(Console.ReadLine());
        }
    }
}
