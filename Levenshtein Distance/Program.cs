using System;
using System.Collections.Generic;
namespace LevenshteinAlgorithm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("############### Levenshtein Distance ###############");
            Console.Write("String(1) : ");
            string x = Console.ReadLine();
            Console.Write("String(2) : ");
            string y = Console.ReadLine();
            LevenshteinDistance(x, y);

        }

        static void LevenshteinDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            if (n == 0)
            {
                Console.WriteLine("There are {0} difference(s) between {1} and a null string",m,n);
            }

            if (m == 0)
            {
                Console.WriteLine("There are {0} difference(s) between {1} and a null string",n,m);
            }

            for (int i = 0; i <= n; i++)
                d[i, 0] = i;
            for (int j = 0; j <= m; j++)
                d[0, j] = j;

            for (int j = 1; j <= m; j++)
                for (int i = 1; i <= n; i++)
                    if (s[i - 1] == t[j - 1])
                    {
                        d[i, j] = d[i - 1, j - 1];  //no operation
                    }
                    else
                    {
                        d[i, j] = Math.Min(Math.Min(
                            d[i - 1, j] + 1,    //a deletion
                            d[i, j - 1] + 1),   //an insertion
                            d[i - 1, j - 1] + 1 //a substitution
                            );
                    }

            Console.WriteLine("There are {0} difference(s) between '{1} and '{2}'",d[n, m],s,t);
        }

    }
}