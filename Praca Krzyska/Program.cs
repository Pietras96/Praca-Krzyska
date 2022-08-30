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

            string[] dane = File.ReadAllLines(file);
            int n = dane.Length;
            List<Complex> X = new List<Complex>();
            for (int l = 0; l < n; l++)
            {
                X.Add(new Complex(Convert.ToDouble(dane[l]),0));
            }

            Complex[] tmp = new Complex[n];
            Complex W;
            Complex U;
            int i;
            int j = 0;
            int k = 0;
            int id = 0;
            int L = 0;
            int LE = 0;
            int LE1 = 0;
            int N2 = n / 2;
            int M = (int)Math.Log2(n);


            for (i = 1; i < n - 1; i++)
            {
                k = N2;
                while (k <= j)
                {
                    j = j - k;
                    k = k / 2;
                }
                j = j + k;
                if (i < j)
                {
                    tmp[i] = new Complex(X[j].Real, X[j].Imaginary);
                    X[j] = new Complex(X[i].Real, X[i].Imaginary);
                    X[i] = new Complex(tmp[i].Real, tmp[i].Imaginary);
                }

            }
            for (L = 1; L <= M; L++)
            {
                LE = (int)Math.Pow(2, L);
                LE1 = LE / 2;
                U = new Complex(1.0, .0);
                W = new Complex(Math.Cos(Math.PI / LE1), (-1.0) * Math.Sin(Math.PI / LE1));
                for (j = 0; j < LE1; j++)
                {
                    for (i = j; i < n; i += LE)
                    {
                        id = i + LE1;
                        tmp[i] = new Complex(X[id].Real * U.Real - (X[id].Imaginary * U.Imaginary), X[id].Imaginary * U.Real + X[id].Real * U.Imaginary);
                        X[id] = new Complex(X[i].Real - tmp[i].Real, X[i].Imaginary - tmp[i].Imaginary);
                        X[i] = new Complex(X[i].Real + tmp[i].Real, X[i].Imaginary + tmp[i].Imaginary);
                    }
                    // zapytac Przemka


                }
            }



            Console.WriteLine("ELo");


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
