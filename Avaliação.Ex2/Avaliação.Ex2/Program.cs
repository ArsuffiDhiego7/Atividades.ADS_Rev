using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação.Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cidade = null;
            int op;

            Console.WriteLine("Escolha o número da cidade: \n1- Atibaia \n2- Bragança Paulista \n3- Mairiporã \n4- Nazaré \n5- Terra Preta \n6- Extrema \n7- Vargem \n");            
            op = Convert.ToInt32(Console.ReadLine());            


            switch (op)
            {
                case 1:
                    cidade = "\nAtibaia";
                    break;
                case 2:
                    cidade = "\nBragança Paulista";
                    break;
                case 3:
                    cidade = "\nMairiporã";
                    break;
                case 4:
                    cidade = "\nNazaré";
                    break;
                case 5:
                    cidade = "\nTerra Preta";
                    break;
                case 6:
                    cidade = "\nExtrema";
                    break;
                case 7:
                    cidade = "\nVargem";
                    break;
            }

            string dataconvert = converterdata();
            Console.WriteLine(cidade + ", " + dataconvert);
            Console.WriteLine();

            Console.ReadKey();
        }

        public static String converterdata()
        {
            string mesExtenso = null;
            int dia, mes, ano;

            Console.WriteLine("\nDigite a data no formato dd/mm/aaaa ");
            var dt = Convert.ToDateTime(Console.ReadLine());
            dia = dt.Day;
            mes = dt.Month;
            ano = dt.Year;

            switch (mes)
            {
                case 1:
                    mesExtenso = "Janeiro";
                    break;
                case 2:
                    mesExtenso = "Fevereiro";
                    break;
                case 3:
                    mesExtenso = "Março";
                    break;
                case 4:
                    mesExtenso = "Abril";
                    break;
                case 5:
                    mesExtenso = "Maio";
                    break;
                case 6:
                    mesExtenso = "Junho";
                    break;
                case 7:
                    mesExtenso = "Julho";
                    break;
                case 8:
                    mesExtenso = "Agosto";
                    break;
                case 9:
                    mesExtenso = "Setembro";
                    break;
                case 10:
                    mesExtenso = "Outubro";
                    break;
                case 11:
                    mesExtenso = "Novembro";
                    break;
                case 12:
                    mesExtenso = "Dezembro";
                    break;
            }
            string dataconvert = dia + " de " + mesExtenso + " de " + ano + ".";
            return dataconvert;
        }
               
    }
}
