using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nary_node4
{
    public class NaryNode<T>
    {
        public T Value { get; set; }
        public List<NaryNode<T>> Children { get; set; }

        public NaryNode(T value)
        {
            Value = value;
            Children = new List<NaryNode<T>>();
        }

        public void AddChild(NaryNode<T> child)
        {
            Children.Add(child);
        }

        public override string ToString()
        {
            return ToString(string.Empty);
        }

        public string ToString(string spaces)
        {
            var result = $"{spaces}{Value}:\n";
            Children.ForEach(e => result += (e.ToString(spaces + "   ")));
            return result;
        }

        public NaryNode<T>? FindNode(T key)
        {
            if (key == null)
            {
                return null;
            }

            if (key.Equals(Value))
            {
                return this;
            }

            foreach (var child in Children)
            {
                var foundChild = child.FindNode(key);
                if (foundChild != null) return foundChild;
            }

            return null;
        }

        public IEnumerable<NaryNode<T>> TraversePreorder()
        {
            return new List<NaryNode<T>>();
        }


        public IEnumerable<NaryNode<T>> TraversePostorder()
        {
            return new List<NaryNode<T>>();
        }
        public IEnumerable<NaryNode<T>> TraverseBreadthFirst()
        {
            return new List<NaryNode<T>>();
        }

    }
}
