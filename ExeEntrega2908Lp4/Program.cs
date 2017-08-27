using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEntrega2908Lp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1° Exercício - Soma de 0 a 100
            Exercicio1 exe1 = new Exercicio1();
            exe1.calcula();
            proximoExercicio();

            //2° Exercício - Multiplos e 7 menores que 200
            Exercicio2 exe2 = new Exercicio2();
            exe2.calcula();
            proximoExercicio();

            //3° Exercício - Soma dos números divisiveis por 4, menores que 100.
            Exercicio3 exe3 = new Exercicio3();
            exe3.calcula();
            proximoExercicio();

            /*4° Exercício - Calcular o valor de S, usando os 20 primeiros termos da série abaixo:
                 x     x     x     x
            S = --- - --- + --- - ---
                 1     2     3     4    */
            Exercicio4 exe4 = new Exercicio4();
            exe4.calcula();
            proximoExercicio();

            //5° Exercício - tabuada do numero 5 com for e while
            Exercicio5 exe5 = new Exercicio5();
            exe5.calcula();
            proximoExercicio();

            //6° Exercício - tabuada do numero 5 com for e while
            Exercicio6 exe6 = new Exercicio6();
            exe6.calcula();
            proximoExercicio();

            //7° Exercício - Compras a prazo ou à Vista
            Exercicio7 exe7 = new Exercicio7();
            exe7.calcula();
            proximoExercicio(); 

            //8° Exercício - Notas Calculadas Media, acima e abaixo
            Exercicio8 exe8 = new Exercicio8();
            exe8.calcula();
            proximoExercicio();

            //9° Exercício - Alunos acima da média
            Exercicio9 exe9 = new Exercicio9();
            exe9.calcula();
            proximoExercicio();

            //10° Exercício - Alunos acima da média
            Exercicio10 exe10 = new Exercicio10();
            exe10.calcula();
            proximoExercicio();

            /* Tentativa de uma só chamada para 10 classes diferentes que possuem o mesmo metodo
            int qtdeExercicio = 10;
            for (int i = 0; i < ++qtdeExercicio; i++)
            {
                string classe = "Exercicio" + i;
                Exercicio+i exe = new classe();
            }
            */


        }

        public static void proximoExercicio()
        {
            Console.WriteLine();
            Console.Write("Tecle enter para ir ao próximo exercício...");
            Console.ReadKey();
            Console.WriteLine();
        } 

        

        
            
        
        
    }
}
