using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("/******************Linked List********************/");
            CustomLinkedList linkedList = new CustomLinkedList(15);
            //Console.WriteLine(JsonConvert.SerializeObject(linkedList, Formatting.Indented));
            linkedList.Append(20);
            linkedList.Append(25);
            //Console.WriteLine(JsonConvert.SerializeObject(linkedList, Formatting.Indented));
            //Console.WriteLine("/**************************************/");
            linkedList.Preppend(5);
            //Console.WriteLine(JsonConvert.SerializeObject(linkedList, Formatting.Indented));
           // Console.WriteLine("/**************************************/");
            linkedList.Preppend(0);
            //Console.WriteLine(JsonConvert.SerializeObject(linkedList, Formatting.Indented));

            Array.ForEach(linkedList.Insert(2,10), Console.WriteLine);
            //Array.ForEach(linkedList.GetList(), Console.WriteLine);
            Console.WriteLine("/**************************************/");
            //Array.ForEach(linkedList.Remove(4), Console.WriteLine);
            Array.ForEach(linkedList.Reverse(), Console.WriteLine);
            Console.WriteLine("/******************Linked List********************/");

            //Console.WriteLine("/******************Double Linked List********************/");
            //CustomDoubleLinkedList doubleLinkedList = new CustomDoubleLinkedList(4);
            //doubleLinkedList.Append(5);
            //doubleLinkedList.Append(6);
            //doubleLinkedList.Preppend(3);
            //doubleLinkedList.Preppend(1);
            //Array.ForEach(doubleLinkedList.Insert(1, 2), Console.WriteLine);
            //Console.WriteLine("/**************************************/");
            //Array.ForEach(doubleLinkedList.Remove(4), Console.WriteLine);
            //Console.WriteLine("/******************Double Linked List********************/");

        }
    }
}
