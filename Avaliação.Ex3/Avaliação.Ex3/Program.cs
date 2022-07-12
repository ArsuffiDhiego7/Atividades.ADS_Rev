using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação.Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fig_geo;

            Console.WriteLine("Escolha o número das figuras: \n1- Trapézio \n2- Círculo \n3- Losango");
            fig_geo = Console.ReadLine();

            switch (fig_geo)
            {
                case "1":
                    Console.WriteLine("\nTrapézio");
                    double bmaior, bmenor, baltura, xt;

                    Console.Write("Digite o valor da base maior: ");
                    bmaior = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da base menor: ");
                    bmenor = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da altura: ");
                    baltura = double.Parse(Console.ReadLine());

                    xt = ((bmaior + bmenor) / 2) * baltura;
                    Console.Write("A área do Trapézio é: " + xt);
                    break;
                case "2":
                    Console.WriteLine("\nCirculo");

                    double pi = 3.1416, r, xc;
                    Console.Write("Digite o valor do raio. ");
                    r = double.Parse(Console.ReadLine());

                    xc = pi * (r * r);
                    Console.Write("A area do Circulo é: " + xc);
                    break;
                case "3":
                    Console.WriteLine("\nLosango");

                    double d1, d2,xl;
                    Console.Write("Digite o valor da diagonal 1. ");
                    d1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da diagonal 2. ");
                    d2 = double.Parse(Console.ReadLine());

                    xl = (d1 * d2) / 2;
                    Console.Write("A área do Losango é: " + xl);
                    break;
            }
            Console.ReadKey();
        }

    }
}
