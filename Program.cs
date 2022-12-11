// See https://aka.ms/new-console-template for more information
// Using .NET 7

var list = new List<Node>
{
    {  new Node { Content = 1 } },
    {  new Node { Content = "Ice Cream" } },
    {  new Node { Content = new List<int> { 1, 2, 3 } } }
};

var graph = new LinkedList<Node>(list);

graph.ReversePrint();