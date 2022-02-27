using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_node4
{
    public class BinaryNode<T>
    {
        public T Value { get; set; }
        public BinaryNode<T>? LeftChild { get; set; }
        public BinaryNode<T>? RightChild { get; set; }

        public BinaryNode(T value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }

        public void AddLeft(BinaryNode<T> child) 
        {
            LeftChild = child;
        }

        public void AddRight(BinaryNode<T> child)
        {
            RightChild = child;
        }

        public override string ToString()
        {
            return ToString(string.Empty);
        }

        public string ToString(string spaces)
        {
            var result = $"{spaces}{Value}:\n";
            if (LeftChild == null && RightChild == null)
            {
                return result;
            }
            
            var indent = spaces + "   ";
            result += LeftChild?.ToString(indent) ?? $"{indent}none\n";
            result += RightChild?.ToString(indent) ?? $"{indent}none\n";
            return result;
        }

        public BinaryNode<T>? FindNode(T key)
        {
            if (key == null)
            {
                return null;
            }

            if (key.Equals(Value))
            {
                return this;
            }

            return LeftChild?.FindNode(key) ?? RightChild?.FindNode(key) ?? null;
        }

        public IEnumerable<BinaryNode<T>> TraversePreorder()
        {
            return TraversePreorder(this, new List<BinaryNode<T>>());
        }

        private ICollection<BinaryNode<T>> TraversePreorder(BinaryNode<T>? root, ICollection<BinaryNode<T>> list)
        {
            if (root == null)
            {
                return list;
            }

            list.Add(root);
            TraversePreorder(root.LeftChild, list);
            TraversePreorder(root.RightChild, list);
            return list;
        }

        public IEnumerable<BinaryNode<T>> TraverseInorder()
        {
            return TraverseInorder(this, new List<BinaryNode<T>>());
        }
        private ICollection<BinaryNode<T>> TraverseInorder(BinaryNode<T>? root, ICollection<BinaryNode<T>> list)
        {
            if (root == null)
            {
                return list;
            }

            TraverseInorder(root.LeftChild, list);
            list.Add(root);
            TraverseInorder(root.RightChild, list);
            return list;
        }

        public IEnumerable<BinaryNode<T>> TraversePostorder()
        {
            return TraversePostorder(this, new List<BinaryNode<T>>());
        }
        private ICollection<BinaryNode<T>> TraversePostorder(BinaryNode<T>? root, ICollection<BinaryNode<T>> list)
        {
            if (root == null)
            {
                return list;
            }

            TraverseInorder(root.LeftChild, list);
            TraverseInorder(root.RightChild, list);
            list.Add(root);
            return list;
        }

        public IEnumerable<BinaryNode<T>> TraverseBreadthFirst()
        {
            var result = new List<BinaryNode<T>>();
            var queue = new Queue<BinaryNode<T>>();

            queue.Enqueue(this);
            while (queue.Any())
            {
                var node = queue.Dequeue();
                result.Add(node);

                if (node.LeftChild != null)
                {
                    queue.Enqueue(node.LeftChild);
                }

                if (node.RightChild != null)
                {
                    queue.Enqueue(node.RightChild);
                }
            }

            return result;
        }


    }
}
