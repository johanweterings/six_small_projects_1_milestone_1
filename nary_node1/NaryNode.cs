using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nary_node1
{
    public class NaryNode<T>
    {
        public T? Value { get; set; }
        public List<NaryNode<T>> Children { get; set; }

        public NaryNode()
        {
            Value = default;
            Children = new List<NaryNode<T>>();
        }

        public void AddChild(NaryNode<T> child)
        {
            Children.Add(child);
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            Children.ForEach(e => stringBuilder.Append($"{e?.Value.ToString() ?? "null"} "));
            return $"{Value}: {stringBuilder}";
        }
    }
}
