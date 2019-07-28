using System;
using System.Collections.Generic;

namespace c_
{
    class Solution
    {
        struct Guest
        {
            public int initialPosition;
            public int currentPosition;
            public bool clockWise;
        }

        struct Consulate
        {
            public List<int> lastSeen;
        }
        static void Main(string[] args)
        {
            int testSamples = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testSamples; i++)
            {
                int[] data = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                Consulate[] consulate = new Consulate[data[0]];
                Guest[] guest = new Guest[data[1]];

                for (int g = 0; g < data[1]; g++)
                {
                    string[] guestsData = Console.ReadLine().Split(' ');

                    guest[g].currentPosition = Convert.ToInt32(guestsData[0]);
                    guest[g].clockWise = guestsData[1] == "C";

                    Console.WriteLine(guest[g].clockWise);
                }

                for (int m = 0; m < data[2]; m++)
                {
                    for (int g = 0; g < guest.Length; g++)
                    {
                        guest[g].currentPosition = guest[g].clockWise ? guest[g].currentPosition + 1 : guest[g].currentPosition - 1;

                        consulate[guest[g].currentPosition].lastSeen.Clear();
                        consulate[guest[g].currentPosition].lastSeen.Add(g);
                    }
                }

                // Console.Write("Case #" + i + ": ");

                // for (int g = 0; g < guest.Length; g++)
                // {
                //     for (int i = 0; i < length; i++)
                //     {
                        
                //     }
                //     if (consulate[guest[g].])
                // }
            }
        }
    }
}
