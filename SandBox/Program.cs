using System;
using System.Collections.Generic;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var suits = new List<string>
            {
                "Diamond",
                "Spade",
                "Club",
                "Heart"
            };

            var intSuits = new List<int>
            {
                1, 2, 3, 4
            };

            var values = new List<string>
            {
                "T",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "V",
                "D",
                "K",
            };


            var listDeck = new Dictionary<List<string>, List<string>>();

            var rnd = new Random();

            listDeck.Add(suits, values);
            int count = 0;
            int rndKey, rndValue;

            foreach (var ld in listDeck)
            {

                for (int i = 0; i < ld.Key.Count; i++)
                {
                    for (int j = 0; j < ld.Value.Count; j++)
                    {
                        rndKey = rnd.Next(0, suits.Count);
                        rndValue = rnd.Next(0, values.Count);

                        Console.WriteLine(ld.Key[rndKey] + " " + ld.Value[rndValue]);

                        count++;
                    }
                }
            }

            Console.WriteLine(count);

        }


    }
}    