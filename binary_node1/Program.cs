// See https://aka.ms/new-console-template for more information
// test setup

using binary_node1;

var fNode = new BinaryNode<string>() { Value = "F" };
var eNode = new BinaryNode<string>() { Value = "E" };
var dNode = new BinaryNode<string>() { Value = "D" };
var cNode = new BinaryNode<string>() { Value = "C" };
var bNode = new BinaryNode<string>() { Value = "B" };
var aNode = new BinaryNode<string>() { Value = "A" };
var rootNode = new BinaryNode<string>() { Value = "Root" };

rootNode.RightChild = bNode;
bNode.RightChild = eNode;
eNode.LeftChild = fNode;

rootNode.LeftChild = aNode;
aNode.LeftChild = cNode;
aNode.RightChild = dNode;

Console.WriteLine(rootNode.ToString());
Console.WriteLine(aNode.ToString());
Console.WriteLine(bNode.ToString());
Console.WriteLine(cNode.ToString());
Console.WriteLine(dNode.ToString());
Console.WriteLine(eNode.ToString());
Console.WriteLine(fNode.ToString());




