// See https://aka.ms/new-console-template for more information
using nary_node4;

var a = new NaryNode<string>("A");
var b = new NaryNode<string>("B");
var c = new NaryNode<string>("C");
var d = new NaryNode<string>("D");
var e = new NaryNode<string>("E");
var f = new NaryNode<string>("F");
var g = new NaryNode<string>("G");
var h = new NaryNode<string>("H");
var i = new NaryNode<string>("I");
var root = new NaryNode<string>("Root");


root.Children = new List<NaryNode<string>> { a, b, c };
a.Children = new List<NaryNode<string>> { d, e };
d.Children = new List<NaryNode<string>> { g };
c.Children = new List<NaryNode<string>> { f };
f.Children = new List<NaryNode<string>> { h, i };

string result;
result = "Preorder:      ";

foreach (NaryNode<string> node in root.TraversePreorder())
{
    result += string.Format("{0} ", node.Value);
}
Console.WriteLine(result);

result = "Postorder:     ";

foreach (NaryNode<string> node in root.TraversePostorder())
{
    result += string.Format("{0} ", node.Value);
}
Console.WriteLine(result);

result = "Breadth First: ";

foreach (NaryNode<string> node in root.TraverseBreadthFirst())
{
    result += string.Format("{0} ", node.Value);
}
Console.WriteLine(result);







