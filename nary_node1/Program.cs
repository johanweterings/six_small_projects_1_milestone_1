// See https://aka.ms/new-console-template for more information
using nary_node1;

var aNaryNode = new NaryNode<string> { Value = "A" };
var bNaryNode = new NaryNode<string> { Value = "B" };
var cNaryNode = new NaryNode<string> { Value = "C" };
var dNaryNode = new NaryNode<string> { Value = "D" };
var eNaryNode = new NaryNode<string> { Value = "E" };
var fNaryNode = new NaryNode<string> { Value = "F" };
var gNaryNode = new NaryNode<string> { Value = "G" };
var hNaryNode = new NaryNode<string> { Value = "H" };
var iNaryNode = new NaryNode<string> { Value = "I" };
var rootNaryNode = new NaryNode<string> { Value = "Root" };


rootNaryNode.Children = new List<NaryNode<string>> { aNaryNode, bNaryNode, cNaryNode };
aNaryNode.Children = new List<NaryNode<string>> { dNaryNode, eNaryNode };
dNaryNode.Children = new List<NaryNode<string>> { gNaryNode };
cNaryNode.Children = new List<NaryNode<string>> { fNaryNode };
fNaryNode.Children = new List<NaryNode<string>> { hNaryNode, iNaryNode };

Console.WriteLine(rootNaryNode);
Console.WriteLine(aNaryNode);
Console.WriteLine(bNaryNode);
Console.WriteLine(cNaryNode);
Console.WriteLine(dNaryNode);
Console.WriteLine(eNaryNode);
Console.WriteLine(fNaryNode);
Console.WriteLine(gNaryNode);
Console.WriteLine(hNaryNode);
Console.WriteLine(iNaryNode);







