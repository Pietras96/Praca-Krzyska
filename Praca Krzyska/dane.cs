using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Krzyska
{
    class Dane
    {
        public string[] dane;
        public int n;
        public int M;
        public List<Complex> X;
        public Dane(string path)
        {
            dane = File.ReadAllLines(path);

            n = dane.Length;
            X = new List<Complex>();
            M = (int)Math.Log2(n);
            double rms2;
            for (int l = 0; l < n; l++)
            {
                X.Add(new Complex(Convert.ToDouble(dane[l]), 0));
                
            }
            //rms2 = rms();
            //rms2 *= rms2;
        }
        //double rms()
        //{
        //    double sum = X[0].Real * X[0].Real;
        //    for (int i = 0; i < n; i++)
        //    {
        //        sum += X[i].Real * X[i].Real;
        //    }
        //    return Math.Sqrt((1.0 / n) * sum);
        //}
    }
}
