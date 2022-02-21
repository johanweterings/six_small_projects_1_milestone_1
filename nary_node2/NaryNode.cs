using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nary_node2
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

    }
}
