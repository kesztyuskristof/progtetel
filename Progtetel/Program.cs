using System;

namespace Progtetel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 7, 2, -5, 4, 11, 9 };

            // Párosok kiválogatása

            int n = x.Length;

            int[] parosak = new int[100];
            int db = 0;
            int i;
            for (i = 0; i < n; i++)
            {
                if (x[i] % 2 == 0)
                {
                    parosak[db] = x[i];
                    db++;
                }
            }
            for (i = 0; i < db; i++)
            {
                Console.Write(parosak[i] + " ");
            }

            // Max kiválasztás - 100% fluffy hair 🤣🤣😂😂😅😅😅😅 low taper fade

            int maxe = 0;
            i = 0;
            for (i = 0; i < n; i++)
            {
                if (x[i] > maxe)
                {
                    maxe = x[i];
                }
            }
            Console.WriteLine(maxe);

            //Párosak kiválogatása
        }
    }
}
