using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.MultipleInheritance
{
    public class Dragon : IBird, ILizzard
    {
        private Bird bird = new Bird();
        private Lizzard lizzard = new Lizzard();

        public int Weight { get; set; }

        public void Crawl()
        {
            ((ILizzard)lizzard).Crawl();
        }

        public void Fly()
        {
            ((IBird)bird).Fly();
        }
    }
}
