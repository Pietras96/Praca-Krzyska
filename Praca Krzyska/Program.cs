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
            string file = @"C:\Users\Piotrek\Desktop\ostatniaproba.txt";

            var fft = new FFT(file);
            fft.SaveFile("fftResult.txt", fft.X);
            var aps = new Aps(file);
            aps.SaveFile("PSDResult.txt", aps.PSDList);


            Console.WriteLine("elo");            
                                 
        }
    }
}
