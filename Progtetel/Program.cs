using System;

namespace Progtetel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SIGMA

            int[] x = { 7, 2, -5, 4, 11, 9 };

            // Max kiválasztás

            int n = x.Length;

            int i = 0;
            int maxe = 0;
            for (i = 0; i < n; i++)
            {
                if (x[i] > maxe)
                {
                    x[i] = x[maxe];
                }
            }
            Console.WriteLine(maxe);

            //Párosak kiválogatása
        }
    }
}
