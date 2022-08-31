using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnalizaFouriera
{
    class FFT: Data
    {
        public FFT(string path) : base (path)
        {
            CalculateFFT();
        }
        Complex temp; 
        Complex W;
        Complex U;
        int i;
        int j = 0;
        int k = 0;
        int id = 0;
        int L = 0;
        int ne = 0;
        int ne2 = 0;
        int n2;

        public List<Complex> CalculateFFT()
        {
            temp = new Complex();
            n2 = n / 2;
            
            for (i = 1; i < n - 1; i++)
            {
                k = n2;
                while (k <= j)
                {
                    j = j - k;
                    k = k / 2;
                }
                j = j + k;
                if (i < j)
                {
                    temp = new Complex(X[j].Real, X[j].Imaginary);
                    X[j] = new Complex(X[i].Real, X[i].Imaginary);
                    X[i] = new Complex(temp.Real, temp.Imaginary);
                }

            }
            for (L = 1; L <= M; L++)
            {
                ne = (int)Math.Pow(2, L);
                ne2 = ne / 2;
                U = new Complex(1.0, 0.0);
                W = new Complex(Math.Cos(Math.PI / ne2), (-1.0) * Math.Sin(Math.PI / ne2));
                for (j = 0; j < ne2; j++)
                {
                    for (i = j; i < n; i += ne)
                    {
                        id = i + ne2;
                        temp = new Complex(X[id].Real * U.Real - (X[id].Imaginary * U.Imaginary), X[id].Imaginary * U.Real + X[id].Real * U.Imaginary);
                        X[id] = new Complex(X[i].Real - temp.Real, X[i].Imaginary - temp.Imaginary);
                        X[i] = new Complex(X[i].Real + temp.Real, X[i].Imaginary + temp.Imaginary);
                    }
                    temp = new Complex(U.Real * W.Real - U.Imaginary * W.Imaginary, X[id].Imaginary * U.Real + X[id].Real * U.Imaginary);
                    U = new Complex(temp.Real, U.Real * W.Imaginary + U.Imaginary * W.Real);

                }
                
            }
            return X;

        }
    }
}
