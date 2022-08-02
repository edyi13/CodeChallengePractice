using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackQueue
{
    internal class CustomQueue
    {
        public Node? first;
        public Node? last;
        public int length;

        public CustomQueue()
        {
            first = null;
            last = null;
            length = 0;
        }

        public object Peek()
        {
            return first.value;
        }

        public void Enqueue(object value)
        {
            var newNode = new Node(value);
            if (length == 0)
            {
                first = newNode;
                last = newNode;
                length++;
            }
            else
            {
                last.next = newNode;
                last = newNode;
                length++;

            }
        }

        public void Dequeue()
        {
            if (length == 0)
            {
                first = null;
                last = null;
            }
            else if (length > 0)
            {
                Node temp = (Node)first.next;
                first = temp;
                length--;
            }
        }

        public object[] GetList()
        {
            var arr = new object[length];
            var currNode = first;
            //Console.WriteLine(JsonConvert.SerializeObject(currNode, Formatting.Indented));
            var count = 0;
            while (currNode != null)
            {
                if (count == length)
                    break;
                arr[count] = currNode.value;
                currNode = (Node)currNode.next;
                count++;
                //Console.WriteLine(JsonConvert.SerializeObject(currNode, Formatting.Indented));
            }
            return arr;
        }
    }
}
