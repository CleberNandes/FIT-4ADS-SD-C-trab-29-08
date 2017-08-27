using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEntrega2908Lp4
{
    class Exercicio4
    {
        public void calcula()
        {
            Console.WriteLine("\n********* 4º Exercicio - Valor de S - 20 Termos da série abaixo  **********\n");
            Console.WriteLine("     X       X       X       X         X");
            Console.WriteLine("S = ---  -  ---  +  ---  -  ---  ...  ---");
            Console.WriteLine("     1       2       3       4         N");
            Console.Write("\nDigite o valor de X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double soma = 0;
            for (int i = 1; i <= 20; i++)
            {
                double resultado = x / i;
                if(i % 2 == 1)
                {
                    soma += resultado;
                } else {
                    soma -= resultado;
                }
                Console.WriteLine("\nSoma = "+soma +"     -     Resultado "+resultado+" = "+x+" / "+i);
                    
            }
            
        }
        
       
    }
}
