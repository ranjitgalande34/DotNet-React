using System;
using System.Collections;

namespace program
{
    public class Collections
    {
        static void Main()
        {
           
            ArrayList list = new ArrayList();

           
            list.Add(1);
            list.Add(2);
            list.Add(3);

           
            list.Remove(2);


            List<int> list1 = new List<int>();
            list1.Add(4);


          //  for (int i = 0; i < list.Count; i++)
          //  {
           //     Console.WriteLine(list[i]);
          //  }

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Pop();
            foreach(int item in stack)
            {
                Console.WriteLine(item);
            }

            Stack<int> stack1 = new Stack<int>();
            stack1.Push(5);

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);

            queue.Dequeue();

            Queue<int> queue2 = new Queue<int>();
            queue.Enqueue(6);

            Dictionary<string, int> ages = new Dictionary<string, int>();

            ages.Add("Alice", 30);
            ages.Add("Bob", 25);

            ages.Remove("Bob");

            int aliceAge = ages["Alice"];
            Console.WriteLine(aliceAge);
        }
    }
}

