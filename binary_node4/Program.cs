// See https://aka.ms/new-console-template for more information
// test setup

using binary_node4;

var f = new BinaryNode<string>("F");
var e = new BinaryNode<string>("E");
var d = new BinaryNode<string>("D");
var c= new BinaryNode<string>("C");
var b= new BinaryNode<string>("B");
var a= new BinaryNode<string>("A");
var root = new BinaryNode<string>("Root");

root.RightChild = b;
b.RightChild = e;
e.LeftChild = f;

root.LeftChild = a;
a.LeftChild = c;
a.RightChild = d;

string result;
result = "Preorder:      ";

foreach (BinaryNode<string> node in root.TraversePreorder())
{
    result += string.Format("{0} ", node.Value);
}
Console.WriteLine(result);

result = "Inorder:       ";

foreach (BinaryNode<string> node in root.TraverseInorder())
{
    result += string.Format("{0} ", node.Value);
}
Console.WriteLine(result);

result = "Postorder:     ";

foreach (BinaryNode<string> node in root.TraversePostorder())
{
    result += string.Format("{0} ", node.Value);
}
Console.WriteLine(result);

result = "Breadth First: ";

foreach (BinaryNode<string> node in root.TraverseBreadthFirst())
{
    result += string.Format("{0} ", node.Value);
}
Console.WriteLine(result);

