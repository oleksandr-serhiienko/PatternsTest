using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.MultipleInheritance
{
    public class Dragon : IBird, ILizzard
    {
        private Bird bird = new Bird();
        private Lizzard lizzard = new Lizzard();

        public void Crawl()
        {
            lizzard.Crawl();
        }

        public void Fly()
        {
            bird.Fly();
        }
    }
}
