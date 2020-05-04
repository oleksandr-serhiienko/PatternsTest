using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class InOrderIterator<T>
    {
        private readonly Node<T> root;
        public Node<T> Current { get;  }
        private bool yieldedStart;

        public InOrderIterator(Node<T> root)
        {
            this.root = root;
            Current = root;
            while (Current.Left != null)
                Current = Current.Left;
        }

        public bool MoveNext()
        {   
            if(!yieldedStart)
            {
                yieldedStart = true;
                return true;
            }

            if (Current.Right != null)
            {
                Current = Current.Right;
                while (Current.Left != null)
                    Current = Current.Left;
            }
            else 
            {
                var p = Current.Parent;
                while (p != null && Current == p.Right)
                {
                    Current = p;
                    p = p.Parent;
                }
                Current = p;
                
            }
            return Current != null;
        }

        public void Reset()
        {
            Current = root;
            yieldedStart = false;
        }
    }
}
