using System.Xml.Linq;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the stacks and queues program");
            Console.WriteLine("1.Creating a stack");
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
                 
           

             }
        }
    }
}
