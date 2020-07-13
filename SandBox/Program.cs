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


            var listDeck = new List<KeyValuePair<string,string>>();
            var pair = new KeyValuePair<string,string>();
            
            var rnd = new Random();

            int count = 0;
            int rndKey, rndValue;

            

            for (int i = 0; i < suits.Count; i++)
            {
                for (int j = 0; j < values.Count; j++)
                {
                    rndKey = rnd.Next(0, suits.Count);
                    rndValue = rnd.Next(0, values.Count);

                    listDeck.Add(new KeyValuePair<string, string>(suits[rndKey],values[rndValue]));
                    

                    count++;
                }
            }
            
            listDeck.ForEach(ld => Console.WriteLine($"{ld.Key}:{ld.Value}"));

            Console.WriteLine(count);

        }


    }
}    