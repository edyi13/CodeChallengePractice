using Newtonsoft.Json;

namespace CustomStackQueue
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("/******************Stack********************/");
            CustomStack customStack = new CustomStack();
            customStack.Push(1);
            customStack.Push(2);
            customStack.Push(3);
            customStack.Push(4);
            Array.ForEach(customStack.GetList(), Console.WriteLine);
            Console.WriteLine("/**************************************/");
            Console.WriteLine(JsonConvert.SerializeObject(customStack.Peek(), Formatting.Indented));
            Console.WriteLine("/**************************************/");
            customStack.Pop();
            Console.WriteLine(JsonConvert.SerializeObject(customStack.GetList(), Formatting.Indented));
            Console.WriteLine("/******************Stack********************/");
            Console.WriteLine("/******************Queue********************/");
            CustomQueue customQueue = new CustomQueue();
            customQueue.Enqueue("Ana");
            customQueue.Enqueue("Gerson");
            customQueue.Enqueue("Noemy");
            customQueue.Enqueue("Edson");
            Array.ForEach(customQueue.GetList(), Console.WriteLine);
            Console.WriteLine("/**************************************/");
            customQueue.Dequeue();
            customQueue.Dequeue();
            Array.ForEach(customQueue.GetList(), Console.WriteLine);
            Console.WriteLine("/**************************************/");
            Console.WriteLine(JsonConvert.SerializeObject(customQueue.Peek(), Formatting.Indented));
            Console.WriteLine("/******************Queue********************/");

        }
    }
}
