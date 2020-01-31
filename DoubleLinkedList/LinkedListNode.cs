using System;

namespace DoubleLinkedList
{
    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Previous { get; internal set; }
        public LinkedListNode<T> Next { get; internal set; }
        public T Value { get; internal set; }
        
        public LinkedListNode(T value)
        {
            this.Value = value;
        }
    }
}
