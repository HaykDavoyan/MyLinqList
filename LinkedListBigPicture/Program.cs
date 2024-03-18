using System;

namespace LinkedListBigPicture;
public class Program
{
    static void Main(string[] args)
    {
        MyLinkedList<int> nums = new MyLinkedList<int>();
        nums.AddFirst(23);
        nums.AddLast(8);
        nums.AddFirst(2004);
        nums.AddLast(3);
        nums.AddFirst(12);
        
        Print(nums.head);
    }
    public static void Print(MyLinkedListNode<int> nums)
    {
        while (nums.Next != null)
        {
            Console.WriteLine(nums.Value);
            nums = nums.Next;
            if (nums.Next == null)
            {
                Console.WriteLine(nums.Value);
            }
        }
    }
}