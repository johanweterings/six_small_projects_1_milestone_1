using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_node1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a test tree.
            //      Root
            //      /  \
            //     A    B
            //    / \    \
            //   C   D    E
            //           /
            //          F
            BinaryNode<string> root = new BinaryNode<string>("Root");
            BinaryNode<string> a = new BinaryNode<string>("A");
            BinaryNode<string> b = new BinaryNode<string>("B");
            BinaryNode<string> c = new BinaryNode<string>("C");
            BinaryNode<string> d = new BinaryNode<string>("D");
            BinaryNode<string> e = new BinaryNode<string>("E");
            BinaryNode<string> f = new BinaryNode<string>("F");

            root.AddLeft(a);
            root.AddRight(b);
            a.AddLeft(c);
            a.AddRight(d);
            b.AddRight(e);
            e.AddLeft(f);

            // Verify the tree.
            Console.WriteLine(root);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            Console.ReadLine();
        }
    }
}
