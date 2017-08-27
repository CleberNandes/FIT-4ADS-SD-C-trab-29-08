using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEntrega2908Lp4
{
    class Exercicio3
    {
        public void calcula()
        {
            Console.WriteLine("\n******* 3° Exercício - Exibe divisiveis por 4, menores que 100. *******");
            Console.WriteLine();
            int soma=0;
            for (int i = 1; i < 100;i++)
            {
                if (i%4 == 0)
                {
                    soma += i;
                    Console.Write(i);
                    if (i != 100)
                    {
                        Console.Write(" - ");
                    }
                }

            }
            Console.WriteLine();
            Console.Write("\nA soma dos números divisiveis por 4 é : "+soma);
            Console.WriteLine();

        }
    }
}
