using System;
using System.Collections.Generic;

namespace AnalizaFouriera
{
    class APS: FFT
    {
        public List<double> AbsList = new List<double>();
        public List<double> PSDList = new List<double>();

        public APS(string path): base(path)
        {
            AbsPow();
            PSD();
        }

        List<double> AbsPow()
        {
            for (int i = 0; i < n; i++)
            {
                AbsList.Add(Math.Pow(X[i].Real,2) + Math.Pow(X[i].Imaginary,2));
            }
            return AbsList;
        }

        List<double> PSD()
        {
            for (int i = 0; i < n; i++)
            {
                PSDList.Add(Math.Sqrt(Convert.ToDouble(AbsList[i]))/(n*300));
            }
            return PSDList;
        }
    }
}
