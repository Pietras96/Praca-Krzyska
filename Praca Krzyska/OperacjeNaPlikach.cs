using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Krzyska
{
    class OperacjeNaPlikach
    {
      
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
         public void SaveFile(string path, string fileName, List<Complex> list)
        {
            using (TextWriter tw = new StreamWriter(path + fileName))
            {
                foreach (Complex s in list)
                    tw.WriteLine($"{s.Real}; {s.Imaginary}i");
            }

        }
        public void SaveFile(string path, string fileName, List<double> list)
        {
            using (TextWriter tw = new StreamWriter(path + fileName))
            {
                foreach (Complex s in list)
                    tw.WriteLine(s.Real);
            }

        }

    }
}
