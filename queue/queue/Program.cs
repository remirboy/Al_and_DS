using System;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Kate");
            queue.Enqueue("Sam");
            queue.Enqueue("Alice");
            queue.Enqueue("Tom");

            Console.WriteLine("Кол-во элементов: "+ queue.Count);

            foreach (string item in queue)
                Console.WriteLine(item);

            Console.WriteLine(queue.Contains("Sam"));
            Console.WriteLine(queue.Contains("Remir"));

            Console.WriteLine("Первый элемент: "+ queue.Head);
            Console.WriteLine("Последний элемент: " + queue.Tail);
            Console.WriteLine();
            string firstItem = queue.Dequeue();
            Console.WriteLine($"Извлеченный элемент: {firstItem}");
            Console.WriteLine();

            foreach (string item in queue)
                Console.WriteLine(item);

            Console.WriteLine("////|||");

            Stack<string> stack = new Stack<string>();

            stack.Push("Kate");
            stack.Push("Sam");
            stack.Push("Alice");
            stack.Push("Tom");

            Console.WriteLine("Кол-во элементов: " + stack.Count);

            foreach (string item in queue)
                Console.WriteLine(item);

            Console.WriteLine(stack.Contains("Sam"));
            Console.WriteLine(stack.Contains("Tom"));

            Console.WriteLine("Первый элемент: " + stack.Head);
            Console.WriteLine("Последний элемент: " + stack.Tail);
            Console.WriteLine();

            string firstItem1 = stack.Pop();
            Console.WriteLine($"Извлеченный элемент: {firstItem1}");
            Console.WriteLine();

            foreach (string item in stack)
                Console.WriteLine(item);
        }
    }
}
