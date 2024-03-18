using LinkedListBigPicture;
using System.Collections;

public class MyStack<T> : IEnumerable<T>
{
    private MyLinkedList<T> myStack = new MyLinkedList<T>();

    public void Push(T item)
    {
        myStack.AddFirst(item);
    }
    public T Pop()
    {
        T temp = myStack.head.Value;
        myStack.RemoveFirst();
        return temp;
    }
    public T Peek()
    {
        return myStack.head.Value;
    }
    public IEnumerator<T> GetEnumerator()
    {
        return myStack.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return myStack.GetEnumerator();
    }
}



