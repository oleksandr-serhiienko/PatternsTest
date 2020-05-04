using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class BinaryTree<T>
    {
        Node<T> root;

        public BinaryTree(Node<T> root)
        {
            this.root = root;
        }

        InOrderIterator<T> GetEnumerator()
        {
            return new InOrderIterator<T>(root);
        }
    }
}
