using System;
using System.Collections;


namespace Assignment
{
    class QueueImplementation
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Pankaj");
            q.Enqueue(1);
            q.Enqueue(10.5);
            q.Enqueue(true);
            q.Enqueue('A');
            Console.WriteLine("Count : {0}", q.Count);
            Console.WriteLine();
            Console.WriteLine("Element in Queue : ");
            foreach (object obj in q)
                Console.WriteLine(obj);
            Console.WriteLine();
            Console.WriteLine("End element of Queue : {0}", q.Peek());
            Console.WriteLine();
            object TopElement = q.Dequeue();
            Console.WriteLine("Removing End element of Queue = {0}\nNow End element of Queue = {1}\n", TopElement, q.Peek());
            if (q.Contains("Pankaj")) Console.WriteLine("Pankaj Found");
            else Console.WriteLine("Pankaj Not found");
            Object[] ob = q.ToArray();
            Console.WriteLine();
            foreach (object obj in ob)
                Console.WriteLine(obj);
            q.TrimToSize();
            q.Clear();
            Console.WriteLine();
            Console.WriteLine("Count : {0}", q.Count);
            Console.ReadKey();
        }
    }
}  
   
