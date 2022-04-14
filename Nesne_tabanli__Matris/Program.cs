using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris
{
    class Program
    {
        static void Main(string[] args)
        {
            int sA, sB;
            Console.WriteLine("Çarpacağınız Matrislerin Boyutlarını Gir: ");
            sA = Convert.ToInt32(Console.ReadLine());
            sB = Convert.ToInt32(Console.ReadLine());

            int[,] matrisA = new int[sA, sB]; //First Matris
            int[,] matrisB = new int[sB, sA];  //Second Matris
            int[,] matrisC = new int[sA, sA];

            Console.WriteLine("<-- First Matris -->");
            for (int i = 0; i < sA; i++)
            {
                for (int k = 0; k < sB; k++)
                {

                    Console.Write(i + ". Satırın " + k + ". Elemanı: ");
                    matrisA[i, k] = Convert.ToInt32(Console.ReadLine());


                }
            }

            Console.WriteLine("<-- Second Matris -->");
            for (int i = 0; i < sB; i++)
            {
                for (int k = 0; k < sA; k++)
                {

                    Console.Write(i + ". Satırın " + k + ". Elemanı: ");
                    matrisB[i, k] = Convert.ToInt32(Console.ReadLine());


                }
            }

            Console.WriteLine("<---1. matris--->");
            for (int i = 0; i < sA; i++)
            {
                for (int k = 0; k < sB; k++)
                {
                    Console.Write(matrisA[i, k]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("<---2. matris--->");
            for (int i = 0; i < sB; i++)
            {
                for (int k = 0; k < sA; k++)
                {
                    Console.Write(matrisB[i, k]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            //Çarpma İşlemini Yapıyoruz.

            for (int i = 0; i < sA; i++)
            {
                for (int k = 0; k < sA; k++)
                {
                    for (int j = 0; j < sB; j++)
                    {
                        matrisC[i, k] += matrisA[i, j] * matrisB[j, k];
                    }
                }
            }

            Console.WriteLine("<---Matrislerin Çarpımlarının Sonucu--->");
            for (int i = 0; i < sA; i++)
            {
                for (int k = 0; k < sA; k++)
                {
                    Console.Write(matrisC[i, k]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
