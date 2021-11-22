using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedListStack stack = new LinkedListStack();
           stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.IsEmpty();
            stack.Display();
           /*
            * LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            stack.Display();
           */
        }
    }
}
