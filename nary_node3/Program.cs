// See https://aka.ms/new-console-template for more information
using nary_node3;

var aNaryNode = new NaryNode<string>("A");
var bNaryNode = new NaryNode<string>("B");
var cNaryNode = new NaryNode<string>("C");
var dNaryNode = new NaryNode<string>("D");
var eNaryNode = new NaryNode<string>("E");
var fNaryNode = new NaryNode<string>("F");
var gNaryNode = new NaryNode<string>("G");
var hNaryNode = new NaryNode<string>("H");
var iNaryNode = new NaryNode<string>("I");
var rootNaryNode = new NaryNode<string>("Root");


rootNaryNode.Children = new List<NaryNode<string>> { aNaryNode, bNaryNode, cNaryNode };
aNaryNode.Children = new List<NaryNode<string>> { dNaryNode, eNaryNode };
dNaryNode.Children = new List<NaryNode<string>> { gNaryNode };
cNaryNode.Children = new List<NaryNode<string>> { fNaryNode };
fNaryNode.Children = new List<NaryNode<string>> { hNaryNode, iNaryNode };

// Find some values.
FindValue(rootNaryNode, "Root");
FindValue(rootNaryNode, "E");
FindValue(rootNaryNode, "F");
FindValue(rootNaryNode, "Q");

// Find F in the C subtree.
FindValue(cNaryNode, "F");

void FindValue(NaryNode<string> root, string key)
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







