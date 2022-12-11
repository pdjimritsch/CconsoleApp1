using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ConsoleApp1;

public static partial class Helper
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="nodes"></param>
    public static void ReversePrint(this LinkedList<Node> nodes)
    {
        if (nodes == null)
        {
            Console.WriteLine("!Empty linked list");
            return;
        }

        foreach (Node node in nodes.Reverse()) 
        {
            if (node?.Content is ICollection)
            {
                ICollection collection = (ICollection)node.Content;

                Stack<object> stack = new Stack<object>();

                foreach (var entry in collection)
                {
                    stack.Push(entry);
                }

                while (stack.Count > 0)
                {
                    Console.WriteLine(stack.Pop());
                }
            }
            else if (node?.Content is IEnumerable)
            {
                IEnumerable collection = (IEnumerable)node.Content;

                Stack<object> stack = new Stack<object>();

                foreach (var entry in collection)
                {
                    stack.Push(entry);
                }

                while (stack.Count > 0)
                {
                    Console.WriteLine(stack.Pop());
                }
            }
            else
            {
                Console.WriteLine(node?.ToString() ?? string.Empty);
            }
        }
    }
}
