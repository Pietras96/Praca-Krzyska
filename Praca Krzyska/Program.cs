namespace AnalizaFouriera
{
    public class Program
    {
        static void Main(string[] args)
        {
            // zmienic imie
            string file = @"E:\Studia\Krzysiek\Wyniki pomiarow\SWEEP\dane_sweep.txt";

            var fft = new FFT(file);
            fft.SaveToFile("fftResult.txt", fft.X);
            var aps = new APS(file);
            aps.SaveToFile("PSDResult.txt", aps.PSDList);                                         
        }
    }
}
