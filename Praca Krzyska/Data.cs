using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnalizaFouriera
{
    class Data
    {
        public string[] data;
        public int n;
        public int M;
        public List<Complex> X;
        string path;
        public Data(string filePath)
        {
            GetPath(filePath);
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
        public void SaveFile(string fileName, List<Complex> list)
        {
            using (TextWriter tw = new StreamWriter(path + fileName))
            {
                foreach (Complex s in list)
                    tw.WriteLine($"{s.Real}; {s.Imaginary}i");
            }

        }
        public void SaveFile(string fileName, List<double> list)
        {
            using (TextWriter tw = new StreamWriter(path  + fileName))
            {
                foreach (Complex s in list)
                    tw.WriteLine(DoubleToString(s.Real));
            }

        }
        public string GetPath(string path)
        {
            int index = path.LastIndexOf(@"\");
            if (index >= 0)
            {
                this.path = path.Substring(0, index+1);
            }
            return this.path;
        }
    }
}
