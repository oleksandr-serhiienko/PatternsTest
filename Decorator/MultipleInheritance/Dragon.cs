using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.MultipleInheritance
{
    public class Dragon : IBird, ILizzard
    {
        private Bird bird = new Bird();
        private Lizzard lizzard = new Lizzard();

        private int weight;

        public int Weight
        {
            get { return weight; }
            set { 
                    weight = value;
                    bird.Weight = value;
                    lizzard.Weight = value;
                }
        }


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
