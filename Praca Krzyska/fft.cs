using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Krzyska
{
    class fft: Dane
    {
        public fft(string path) : base (path)
        {
            liczfft();
        }
        Complex tmp; 
        Complex W;
        Complex U;
        int i;
        int j = 0;
        int k = 0;
        int id = 0;
        int L = 0;
        int LE = 0;
        int LE1 = 0;
        int N2;
        
        public void liczfft()
        {
            tmp = new Complex();
            N2 = n / 2;
            
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
                    tmp = new Complex(X[j].Real, X[j].Imaginary);
                    X[j] = new Complex(X[i].Real, X[i].Imaginary);
                    X[i] = new Complex(tmp.Real, tmp.Imaginary);
                }

            }
            for (L = 1; L <= M; L++)
            {
                LE = (int)Math.Pow(2, L);
                LE1 = LE / 2;
                U = new Complex(1.0, 0.0);
                W = new Complex(Math.Cos(Math.PI / LE1), (-1.0) * Math.Sin(Math.PI / LE1));
                for (j = 0; j < LE1; j++)
                {
                    for (i = j; i < n; i += LE)
                    {
                        id = i + LE1;
                        tmp = new Complex(X[id].Real * U.Real - (X[id].Imaginary * U.Imaginary), X[id].Imaginary * U.Real + X[id].Real * U.Imaginary);
                        X[id] = new Complex(X[i].Real - tmp.Real, X[i].Imaginary - tmp.Imaginary);
                        X[i] = new Complex(X[i].Real + tmp.Real, X[i].Imaginary + tmp.Imaginary);
                    }
                    // zapytac Przemka
                    tmp = new Complex(U.Real * W.Real - U.Imaginary * W.Imaginary, X[id].Imaginary * U.Real + X[id].Real * U.Imaginary);
                    U = new Complex(tmp.Real, U.Real * W.Imaginary + U.Imaginary * W.Real);

                }
            }
            //void liczifft()
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        X[i] = Complex.Conjugate(X[i]);
            //    }
            //    liczfft();
            //    for (int i = 0; i < n; i++)
            //    {
            //        X[i] = new Complex(X[i].Real / n, X[i].Imaginary / n);
            //    }
            //}

        }
    }
}
