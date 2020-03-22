using System;

namespace c_
{
    class Program
    {
        static int Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string line0 = Console.ReadLine();
                int[] l0 = Array.ConvertAll(line0.Split(' '), int.Parse);

                int n = l0[0];
                int b = l0[1];

                string line1 = Console.ReadLine();
                int[] l1 = Array.ConvertAll(line1.Split(' '), int.Parse);

                Array.Sort<int>(l1);

                int maxHouses = 0;

                for (int j = 0; j < n; j++)
                {
                    if (b >= l1[j])
                    {
                        b -= l1[j];
                        maxHouses++;
                    }
                    else break;
                }

                Console.WriteLine("Case #" + (i + 1) + ": " + maxHouses);
            }

            return 0;
        }
    }
}
