using System;
using AljabarLibraries;

namespace AljabarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AljabarLibrary aljabarLibrary = new AljabarLibrary();

            // Mencari akar-akar dari persamaan kuadrat
            Console.Write("Masukkan koefisien persamaan kuadrat (a, b, c) dipisahkan dengan spasi: ");
            string[] input = Console.ReadLine().Split();
            double[] persamaanKuadrat = new double[3];
            for (int i = 0; i < 3; i++)
            {
                persamaanKuadrat[i] = double.Parse(input[i]);
            }

            double[] akarPersamaan = aljabarLibrary.AkarPersamaanKuadrat(persamaanKuadrat);
            Console.WriteLine("AkarPersamaanKuadrat({0}, {1}, {2})", persamaanKuadrat[0], persamaanKuadrat[1], persamaanKuadrat[2]);
            if (double.IsNaN(akarPersamaan[0]) && double.IsNaN(akarPersamaan[1]))
            {
                Console.WriteLine("Persamaan kuadrat memiliki akar imajiner.");
            }
            else
            {
                Console.WriteLine("Output: {{{0}, {1}}}", akarPersamaan[0], akarPersamaan[1]);
            }
            Console.WriteLine();

            // Mendapatkan hasil kuadrat dari persamaan berpangkat 1
            Console.Write("Masukkan koefisien persamaan linear (a, b) dipisahkan dengan spasi: ");
            input = Console.ReadLine().Split();
            double[] persamaanLinear = new double[2];
            for (int i = 0; i < 2; i++)
            {
                persamaanLinear[i] = double.Parse(input[i]);
            }

            double[] hasilKuadrat = aljabarLibrary.HasilKuadrat(persamaanLinear);
            Console.WriteLine("HasilKuadrat({0}, {1})", persamaanLinear[0], persamaanLinear[1]);
            Console.WriteLine("Output: {{{0}, {1}, {2}}}", hasilKuadrat[0], hasilKuadrat[1], hasilKuadrat[2]);
            Console.WriteLine();
        }
    }
}
