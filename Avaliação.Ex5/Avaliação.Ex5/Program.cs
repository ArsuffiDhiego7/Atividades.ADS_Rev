using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação.Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mostre os números pares entre 1 e 100\n");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}
