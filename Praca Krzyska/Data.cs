using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace AnalizaFouriera
{
    class Data
    {
        public int n, M;
        string path;
        public string[] data;
        public List<Complex> X;

        public Data(string filePath)
        {
            GetDirectoryPath(filePath);
            GetData(filePath);          
        }

        public void GetData(string path)
        {
            data = File.ReadAllLines(path);
            n = data.Length;
            X = new List<Complex>();
            M = (int)Math.Log2(n);

            for (int l = 0; l < n; l++)
            {
                X.Add(new Complex(StringToDouble(data[l]), 0));
            }
        }

        public string GetDirectoryPath(string filePath)
        {
            int index = filePath.LastIndexOf(@"\");
            if (index >= 0)
            {
                path = filePath.Substring(0, index+1);
            }
            return path;
        }

        public void SaveToFile(string fileName, List<Complex> list)
        {
            using (TextWriter tw = new StreamWriter(path + fileName))
            {
                foreach (Complex s in list)
                {
                    tw.WriteLine($"{s.Real}; {s.Imaginary}i");
                }
            }
        }

        public void SaveToFile(string fileName, List<double> list)
        {
            using (TextWriter tw = new StreamWriter(path  + fileName))
            {
                foreach (Complex s in list)
                {
                    tw.WriteLine(DoubleToString(s.Real));
                }
            }
        }

        public double StringToDouble(string str)
        {
            double number = Convert.ToDouble(str);
            return number;
        }

        public string DoubleToString(double number)
        {
            string str = Convert.ToString(number);
            return str;
        }
    }
}
