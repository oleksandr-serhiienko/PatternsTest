using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    class Program
    {
        public class Creature : IEnumerable<int>
        {
            private int strength = 0;
            private int[] stats = new int[3];
            public int Strenth
            {
                get => stats[strength];
                set => stats[strength] = value;
            }
            public int Agility { get; set; }
            public int Intelligence { get; set; }

            public double AverageStat =>
                stats.Average();

            public IEnumerator<int> GetEnumerator()
            {
                return stats.AsEnumerable().GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public int this[int index]
            {
                get { return stats[index]; }
                set { stats[index] = value;}
            }
        }


        static void Main(string[] args)
        {
            var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));
            var it = new InOrderIterator<int>(root);
            //while (it.MoveNext())
            //{
            //    Console.WriteLine(it.Current.Value);
            //    Console.WriteLine(",");
            //}

            //var tree = new BinaryTree<int>(root);
            //Console.WriteLine(string.Join(",", tree.InOrder.Select(x => x.Value)));

            var tree = new BinaryTree<int>(root);



            var node = new Coding.Exercise.Node<char>('a',
          new Coding.Exercise.Node<char>('b',
            new Coding.Exercise.Node<char>('c'),
            new Coding.Exercise.Node<char>('d')),
          new Coding.Exercise.Node<char>('e'));

            var dd = node.PreOrder;
            //Console.WriteLine(.Select(x => x.));
        }
    }
}
