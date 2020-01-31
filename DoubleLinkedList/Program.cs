using System;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> instance = new LinkedList<int> { };

            instance.AddFirst(1);

            instance.AddLast(2);
            instance.AddLast(3);
            instance.AddLast(4);
            instance.AddLast(5);

            instance.Remove(3);

            instance.RemoveLast();

            foreach (var item in instance)
            {
                Console.WriteLine(item);
            }
        }
    }
}
