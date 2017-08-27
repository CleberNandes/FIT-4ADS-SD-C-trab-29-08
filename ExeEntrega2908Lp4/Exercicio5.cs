using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEntrega2908Lp4
{
    class Exercicio5
    {
        public void calcula()
        {
            Console.WriteLine("\n********** 5º Exercicio - Tabuada do 5 com for     ***********\n");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i * 5);
            }

            Console.WriteLine("\n********** 5º Exercicio - Tabuadado 5 com while   ************\n");
            int j = 1;
            while (j < 11)
            {
                Console.WriteLine(j++ * 5);
            }
        }
    }
}
