using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação.Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota_trabalho, media;
            string aluno;

            Console.Write("Digite a nota do aluno: ");
            aluno = Console.ReadLine();
            Console.WriteLine(aluno);

            Console.Write("\nDigite a nota do trabalho: ");
            nota_trabalho = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota_trabalho + nota1 + nota2 ) / 3;

            if (media >= 8.5)
            {
                Console.WriteLine("Média " + media + "\nConceito é A ");
            }
            else if (media >= 7.0 || media <= 8.4)
            {
                Console.WriteLine("Média " + media + "\nConceito é B ");
            }
            else if (media >= 6.0 || media <= 6.9)
            {
                Console.WriteLine("Média " + media + "\nConceito é C ");
            }
            else if (media >= 0.1 || media <= 5.9)
            {
                Console.WriteLine("Média " + media + "\nConceito é D ");
            }
            else
            {
                Console.WriteLine("Média " + media + "\nConceito é E ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
