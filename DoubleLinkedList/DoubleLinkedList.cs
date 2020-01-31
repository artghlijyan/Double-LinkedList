using System;

namespace DoubleLinkedList
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;

        public bool IsEmpty { get { return Count == 0; } }
        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            if (Count == 0)
            {
                head = node;
                tail = head;
            }
            else
            {
                LinkedListNode<T> temp = head;
                head = node;
                head.Next = temp;
                temp.Previous = head;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            if (Count == 0)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }

            tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.Next;
                    head.Previous = null;
                }

                Count--;
            }
        }

        public bool Remove(T value)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;
                        }

                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }

                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    tail.Previous.Next = null;
                    tail = tail.Previous;
                }

                Count--;
            }
        }

        public void CopyToArray(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = head;

            while (current != null && arrayIndex < array.Length)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }


        public bool Contains(T value)
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
