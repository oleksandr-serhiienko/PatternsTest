using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIngleTone
{
    [TestFixture]
    public class SingletoneTest
    {
        [Test]
        public void IsSingletonTest()
        {
            var db = SingletonDatabase.Instance;
            var db2 = SingletonDatabase.Instance;

            Assert.That(db, Is.SameAs(db2));
            Assert.That(SingletonDatabase.Count, Is.EqualTo(1));
        }

        [Test]
        public void SingletonePopulationTest()
        {
            var rt = new SingleToneRecordFinder();
            var names = new[] { "Seoul", "Mexico City" };
            var tp = rt.GetTotalPopulation(names);
            Assert.That(tp, Is.EqualTo(4565 + 4688));
        }
  
        [Test]
        public void ConfigurablePopulatinTest()
        {
            var rf = new ConfigurableRecordFinder(new DummyDatabase());
            var names = new[] { "alpha", "gamma" };
            int tp = rf.GetTotalPopulation(names);

            Assert.That(tp, Is.EqualTo(4));
        }
    }
}
