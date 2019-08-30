using System;

namespace _0704A1Eratosthenes
{
    class Program
    {
        static void anzeigen(int[] a)
        {
            for (int i = 2; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("");
        }

        static void streichen(int[] a, int b)
        {
            for (int i = 2*b; i < a.Length; i += b)
                a[i] = 1;
        }

        static void Main(string[] args)
        {
            int i = 2, j = 2;

            int[] sieb = new int[1000]; 

            do
            {
                if (sieb[i]==0)
                    streichen(sieb, i);
                anzeigen(sieb);
                i++;
            }
            while (i < 37);

        }
    }
}
