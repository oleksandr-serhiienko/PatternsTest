using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MoreLinq;

namespace SIngleTone
{
    
    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;

        private static int instanceCount;
        public static int Count => instanceCount;

        private SingletonDatabase()
        {
            instanceCount++;
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

        private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(()=> new SingletonDatabase());

        public static SingletonDatabase Instance => instance.Value;
    }
}
