using System;
using System.Collections.Generic;
using System.Text;

namespace SIngleTone
{
    public class DummyDatabase : IDatabase
    {
        public int GetPopulation(string name)
        {
            return new Dictionary<string, int>
            {
                ["alpa"] = 1,
                ["betta"] = 2,
                ["gamma"] = 3
            }[name]; 
        }
    }
}
