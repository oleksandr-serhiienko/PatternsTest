using System;

namespace Coding.Exercise
{
    public class Bird
    {
        public int Age { get; set; }

        public string Fly()
        {
            return (Age < 10) ? "flying" : "too old";
        }
    }

    public class Lizard
    {
        public int Age { get; set; }

        public string Crawl()
        {
            return (Age > 1) ? "crawling" : "too young";
        }
    }

    public class Dragon // no need for interfaces
    {
        Bird bird = new Bird();
        Lizard Lizard = new Lizard();
        int age;

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                bird.Age = value;
                Lizard.Age = value;
            }
        }

        public string Fly()
        {
            return bird.Fly();
        }

        public string Crawl()
        {
            return Lizard.Crawl();
        }
    }
}
