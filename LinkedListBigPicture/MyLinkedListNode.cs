﻿namespace LinkedListBigPicture;

public class MyLinkedListNode<T>
{
    public T Value {  get; set; }
    public MyLinkedListNode<T> Next { get; set; }
    public MyLinkedListNode(T value)
    {
        this.Value = value;
    }  
}

