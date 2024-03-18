using System;
namespace MyLinqList;
class Program
{
    static void Main(string[] args)
    {
        Node first = new Node { Value = 3 };
        Node middle = new Node { Value = 5 };
        first.Next = middle;

        Node last = new Node { Value = 7 };
        middle.Next = last;
        Print(first);
    }
    public static void Print(Node node)
    {
        while (node != null)
        {
            Console.WriteLine(node.Value);
            node = node.Next;  
        }
    }
}