using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));
            var it = new InOrderIterator<int>(root);
            while (it.MoveNext())
            {
                Console.WriteLine(it.Current.Value);
                Console.WriteLine(",");
            }

        }
    }
}
