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
            Array.ForEach(linkedList.Remove(7), Console.WriteLine);

        }
    }
}
