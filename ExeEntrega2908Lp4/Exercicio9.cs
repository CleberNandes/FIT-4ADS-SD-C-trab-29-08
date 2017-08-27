using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeEntrega2908Lp4
{
    class Exercicio9
    {
        public List<Aluno> alunos = new List<Aluno>();
        public void calcula()
        {
            Console.WriteLine("\n********* 9º Exercício - Alunos acima da média **********\n");
            Console.Write("\nQuantos alunos participarão: ");
            int qtdeAlunos = Convert.ToInt16(Console.ReadLine());
            double notasTotal = 0;
            for (int i = 1; i <= qtdeAlunos; i++)
            {
                Console.Write("\nDigite o nome do  " + i + "º Aluno: ");
                string nome = Console.ReadLine();
                Console.Write("\nDigite a nota do  " + i + "º Aluno: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                Aluno aluno = new Aluno(nome, nota);
                alunos.Add(aluno);
                notasTotal += nota;
            }

            double media = notasTotal / qtdeAlunos;
            Console.WriteLine("\nAlunos acima da média: ");
            foreach (var item in alunos)
            {
                if (item.Nota > media)
                {
                    Console.WriteLine(item.Nome);
                }
            }
            

        }
    }
    class Aluno
    {
        public string Nome { get; private set; }
        public double Nota { get; private set; }

        public Aluno(string nome, double nota)
        {
            this.Nome = nome;
            this.Nota = nota;
        }
    }
}
