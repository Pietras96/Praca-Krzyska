using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace AnalizaFouriera
{
    public class Program
    {
        static void Main(string[] args)
        {
            // zmienic imie
            string file = @"E:\Studia\Krzysiek\dane1\Szum\szum.txt";

            var fft = new FFT(file);
            fft.SaveFile("fftResult.txt", fft.X);
            var aps = new Aps(file);
            aps.SaveFile("PSDResult.txt", aps.PSDList);                                         
        }
    }
}
