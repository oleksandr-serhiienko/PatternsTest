using DynamicStrategy.Format;
using DynamicStrategy.QualityCompar;
using System;
using System.Collections.Generic;

namespace DynamicStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            people.Sort();
            people.Sort((x, y) => x.Name.CompareTo(y.Name));
        }
    }
}
