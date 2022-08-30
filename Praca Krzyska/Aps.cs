using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Krzyska
{
    class Aps: fft
    {
        public Aps(string path): base(path)
        {
            abspow();
            PSD();
        }
        public List<double> apList;
        public List<double> PSDList;
        List<double> abspow()
        {
            apList = new List<double>();
            PSDList = new List<double>();
            for (int i = 0; i < n; i++)
            {
                apList.Add(Math.Pow(X[i].Real,2) + Math.Pow(X[i].Imaginary,2));
            }
            return apList;
        }
        // dodac mianownik
        List<double> PSD()
        {
            for (int i = 0; i < n; i++)
            {
                PSDList.Add(Math.Sqrt(Convert.ToDouble(apList[i]))/(n*300));
            }
            return PSDList;
        }
    }
}
