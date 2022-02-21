using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nary_node1
{
    internal class NaryNode<T>
    {
        internal T Value { get; set; }
        internal List<NaryNode<T>> Children;

        internal NaryNode(T value)
        {
            Value = value;
            Children = new List<NaryNode<T>>();
        }

        internal void AddChild(NaryNode<T> child)
        {
            Children.Add(child);
        }

        // Return a string representation of the node and its children.
        public override string ToString()
        {
            string result = string.Format("{0}:", Value);
            foreach (NaryNode<T> child in Children)
                result += string.Format(" {0}", child.Value);
            return result;
        }
    }
}
