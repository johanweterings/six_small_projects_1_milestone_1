using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_node2
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
    }
}
