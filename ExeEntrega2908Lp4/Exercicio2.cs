using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEntrega2908Lp4
{
    class Exercicio2
    {
        public void calcula()
        {
            Console.WriteLine("\n******* 2° Exercício - Multiplos e 7 menores que 200 *******");
            Console.WriteLine();
            for (int i = 1; i <= 200; i++)
            {
                if (i % 7 == 0 || i ==1 )
                {
                    Console.Write(i);
                    if (i < 200)
                    {
                        Console.Write(" - ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
