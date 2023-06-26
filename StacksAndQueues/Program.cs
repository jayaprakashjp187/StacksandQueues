using System.Collections.Generic;
using System.Xml.Linq;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the stacks and queues program");
            Console.WriteLine("1.Creating a stack\n2.by using pop and peek method in stack\n3.creating a queue");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                Stack<int> stack = new Stack<int>();

                // Pushing elements to the stack
                stack.Push(70);
                stack.Push(30);
                stack.Push(56);

                Console.WriteLine("Elements in the stack:");
                foreach (int item in stack)
                {
                    Console.WriteLine(item);
                }

                
                break;
                    case 2:
                    Console.WriteLine();
                    Stack<int> s = new Stack<int>();

                    // Pushing elements to the stack
                    s.Push(70);
                    s.Push(30);
                    s.Push(56);

                    Console.WriteLine("Stack elements before popping:");

                    // Peek and pop until the stack is empty
                    while (s.Count > 0)
                    {
                        int topElement = s.Peek();
                        Console.WriteLine("Peeked element: " + topElement);

                        int poppedElement = s.Pop();
                        Console.WriteLine("Popped element: " + poppedElement);
                    }
            
                     break;
                    case 3:
                    Console.WriteLine("welcome to queue program");
                    Queue<int> queue = new Queue<int>();

                    // Enqueue elements to the queue
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);

                    Console.WriteLine("Elements in the queue:");
                    foreach (int item in queue)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                case 4:
                    Console.WriteLine("using dequeue method ");
                    LinkedList<int> q = new LinkedList<int>();

                    // Enqueue elements to the queue
                    q.AddLast(56);
                    q.AddLast(30);
                    q.AddLast(70);

                    Console.WriteLine("Elements in the queue:");
                    foreach (int item in q)
                    {
                        Console.WriteLine(item);
                    }
                    
                    Console.WriteLine("Dequeued element: " + q.First.Value);
                    q.RemoveFirst();
                    break;
            }
            
                 
           

             
        }
    }
}