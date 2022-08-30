using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace Praca_Krzyska
{
    public class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\Piotrek\Desktop\proba1.txt";

            var fft = new fft(file);


            Console.WriteLine("elo");




            //int j=0, k=0, N = 1024;
            //int N2 = N / 2;

            //for (int i = 1; i < N-1; i++)
            //{
            //    k = N2;
            //    while (k <= j)
            //    {
            //        j = j - k;
            //        k = k / 2;

            //    }
            //    j = j + k;
            //    if (i<j)
            //    {
            //        Console.WriteLine($"Runda {i}");
            //        Console.WriteLine($"k = {k}");
            //        Console.WriteLine($"j = {j}");
            //    }

            //}
            
            //Console.WriteLine(lines[4]);
            ////double[] X = new double[4] { 0.00989, 0.02475, 0.017369, -0.0074 };
            //Console.WriteLine("numer: "+ Convert.ToDouble(lines[4])+ 2);
            
            //double[,] W = new double[n, 2];
            //for (int j = 0; j < n; j++)
            //{
            //    W[j, 0] = Math.Cos(-2.0 * Math.PI * (double)j / (double)n);
            //    W[j, 1] = Math.Sin(-2.0 * Math.PI * (double)j / (double)n);
            //    //Convert.ToDouble(listaProb[j]) * W[]
            //}
            //double wynik;
            //for (int i = 3; i < n; i++)
            //{
            //    wynik = 0;
            //    double wynik2 = 0;
            //    //for (int j = 0; j < 4 ; j++)
            //    //{

            //    //    wynik = wynik + (Convert.ToDouble(lines[j]) * Math.Pow(W[j, 0], i)) + (Convert.ToDouble(lines[j]) * Math.Pow(W[j, 1], i));
            //    //    Console.WriteLine(wynik);
            //    //}
            //    //Console.WriteLine("W: "+ Math.Pow(W[2, 0], i));
            //    //Console.WriteLine($"R: {wynik}, U: {wynik2}");
            //    //Console.WriteLine($"W 11: {W[1, 1]}");
            //    if (i == 0)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            wynik += Convert.ToDouble(lines[j]) * Math.Pow(W[j, 0], i);
            //        }
            //        Console.WriteLine(wynik);
            //    }
            //    else if (i % 2 == 1)
            //    {
            //        for (int k = 0; k < n; k++)
            //        {
            //            wynik += Convert.ToDouble(lines[k]) * Math.Pow(W[k, 0], i);
            //            //wynik2 += Convert.ToDouble(lines[j + 1]) * Math.Pow(W[j+1, 1], i);
            //        }
            //        Console.WriteLine(wynik);
            //    }
            //    else
            //    {
            //        for (int l = 0; l < n; l++)
            //        {
            //            wynik += Convert.ToDouble(lines[l]) * Math.Pow(W[l, 0], i);
            //            double a = Math.Log2(i);
            //            int b = (int)Math.Log2(i);
            //            double c = b / 2;
            //            if (a==b && b%2 ==0 && c%2==0)
            //            {
            //                wynik += Convert.ToDouble(lines[l]) * Math.Abs(Math.Pow(W[l, 1], i));
            //            }
            //            else
            //            {
            //                wynik += Convert.ToDouble(lines[l]) * Math.Abs(Math.Pow(W[l, 1], i))*(-1);
            //            }
            //        }
            //        Console.WriteLine(wynik);

                    //}
                    //for (int k = 1; k < n / 2 - 1; k += 2)
                    //{
                    //    wynik += Convert.ToDouble(lines[k]) * Math.Pow(W[k, 0], i);
                    //    //wynik2 += Convert.ToDouble(lines[j + 1]) * Math.Pow(W[j+1, 1], i);
                    //}

           
           
            
        }
    }
}
