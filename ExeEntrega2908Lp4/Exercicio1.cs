using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEntrega2908Lp4
{
    class Exercicio1
    {        
        internal void calcula()
        {
            int soma = 0;
        
            for (int i = 0; i <= 100; i++)
            {                
                soma += i;
            }
            Console.WriteLine("\n*******           1° Exercício - Soma de 0 a 100.           *******");
            Console.WriteLine("\nA soma dos números é: "+soma);
        }
    }
}
