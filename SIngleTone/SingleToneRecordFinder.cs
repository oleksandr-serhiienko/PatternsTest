using System;
using System.Collections.Generic;
using System.Text;

namespace SIngleTone
{
    public class SingleToneRecordFinder
    {
        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int result = 0;
            foreach (var name in names)
                result += SingletonDatabase.Instance.GetPopulation(name);
            return result;
        }
    }
}
