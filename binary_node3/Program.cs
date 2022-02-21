// See https://aka.ms/new-console-template for more information
// test setup

using binary_node3;

var fNode = new BinaryNode<string>("F");
var eNode = new BinaryNode<string>("E");
var dNode = new BinaryNode<string>("D");
var cNode = new BinaryNode<string>("C");
var bNode = new BinaryNode<string>("B");
var aNode = new BinaryNode<string>("A");
var rootNode = new BinaryNode<string>("Root");

rootNode.RightChild = bNode;
bNode.RightChild = eNode;
eNode.LeftChild = fNode;

rootNode.LeftChild = aNode;
aNode.LeftChild = cNode;
aNode.RightChild = dNode;


// Find some values.
FindValue(rootNode, "Root");
FindValue(rootNode, "E");
FindValue(rootNode, "F");
FindValue(rootNode, "Q");

// Find F in the B subtree.
FindValue(bNode, "F");

void FindValue(BinaryNode<string> root, string key)
{
    var found = root.FindNode(key);
    
    if (found != null)
    {
        Console.WriteLine($"Found {found.Value}");
    }
    else
    {
        Console.WriteLine($"Value {key} not found");
    }
}

