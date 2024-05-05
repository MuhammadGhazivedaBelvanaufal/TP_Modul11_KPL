namespace AljabarLibraries
{
    public class AljabarLibrary
    {
        public double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];
            double diskriminan = b * b - 4 * a * c;
            double akar1, akar2;

            if (diskriminan > 0)
            {
                akar1 = (-b + Math.Sqrt(diskriminan)) / (2 * a);
                akar2 = (-b - Math.Sqrt(diskriminan)) / (2 * a);
            }
            else if (diskriminan == 0)
            {
                akar1 = akar2 = -b / (2 * a);
            }
            else
            {
                akar1 = akar2 = double.NaN; // Menandakan akar imajiner
            }

            return new[] { akar1, akar2 };
        }

        public double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double a2 = a * a;
            double b2 = 2 * a * b;
            double c2 = b * b;

            return new[] { a2, b2, c2 };
        }
    }
}