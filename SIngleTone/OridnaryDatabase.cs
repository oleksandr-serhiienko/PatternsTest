using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SIngleTone
{
    public class OridnaryDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;

        private OridnaryDatabase()
        {
            Console.WriteLine("Initializing database");

            capitals = File.ReadAllLines("capitals.txt")
                           .Batch(2)
                           .ToDictionary(
                            list => list.ElementAt(0).Trim(),
                            list => int.Parse(list.ElementAt(1)));


        }

        public int GetPopulation(string name)
        {
            return capitals[name];
        }
    }
}
