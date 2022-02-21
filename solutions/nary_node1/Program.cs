using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nary_node1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a test tree.
            //       Root
            //        |
            //     +--+--+
            //     A  B  C
            //     |     |
            //    +-+    +
            //    D E    F
            //    |      |
            //    +     +-+
            //    G     H I
            NaryNode<string> root = new NaryNode<string>("Root");
            NaryNode<string> a = new NaryNode<string>("A");
            NaryNode<string> b = new NaryNode<string>("B");
            NaryNode<string> c = new NaryNode<string>("C");
            NaryNode<string> d = new NaryNode<string>("D");
            NaryNode<string> e = new NaryNode<string>("E");
            NaryNode<string> f = new NaryNode<string>("F");
            NaryNode<string> g = new NaryNode<string>("G");
            NaryNode<string> h = new NaryNode<string>("H");
            NaryNode<string> i = new NaryNode<string>("I");

            root.AddChild(a);
            root.AddChild(b);
            root.AddChild(c);
            a.AddChild(d);
            a.AddChild(e);
            c.AddChild(f);
            d.AddChild(g);
            f.AddChild(h);
            f.AddChild(i);

            // Verify the tree.
            Console.WriteLine(root);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
