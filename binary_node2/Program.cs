// See https://aka.ms/new-console-template for more information
// test setup

using binary_node2;

var fNode = new BinaryNode<string>("F") ;
var eNode = new BinaryNode<string>("E") ;
var dNode = new BinaryNode<string>("D") ;
var cNode = new BinaryNode<string>("C") ;
var bNode = new BinaryNode<string>("B") ;
var aNode = new BinaryNode<string>("A") ;
var rootNode = new BinaryNode<string>("Root");

rootNode.RightChild = bNode;
bNode.RightChild = eNode;
eNode.LeftChild = fNode;

rootNode.LeftChild = aNode;
aNode.LeftChild = cNode;
aNode.RightChild = dNode;

Console.WriteLine(rootNode.ToString());




