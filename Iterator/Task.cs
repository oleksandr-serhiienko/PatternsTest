using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Left, Right;
        public Node<T> Parent;

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> left, Node<T> right)
        {
            Value = value;
            Left = left;
            Right = right;

            left.Parent = right.Parent = this;
        }

        public IEnumerable<T> PreOrder
        {
            get
            {
                foreach (var node in PreOrderFunc(this))
                    yield return node.Value;
            }
        }
        IEnumerable<Node<T>> PreOrderFunc(Node<T> current)
        {
            if (current.Left != null)
            {
                foreach (var left in PreOrderFunc(current.Left))
                {
                    yield return left.Parent;
                }
                yield return current.Left;
            }
            if (current.Right != null)
            {
                foreach (var right in PreOrderFunc(current.Right))
                {
                    yield return right.Parent;
                }
                yield return current.Right;
            }
            if (current.Left == null || current.Right == null)
                if (current.Parent != null)
                    yield return current;
        }
    }
}

