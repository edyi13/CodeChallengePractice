using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackQueue
{
    internal class CustomStack
    {
        public Node? top;
        public Node? bottom;
        public int length;
        public CustomStack()
        {
            top = null;
            bottom = null;
            length = 0;
        }

        public object Peek()
        {
            return top.value;
        }

        public void Push(object value)
        {
            var newNode = new Node(value);
            if (length == 0)
            {
                top = newNode;
                bottom = newNode;
                length++;
            }
            else
            {
                Node temp = top;
                top = newNode;
                top.next = temp;
                length++;

            }
        }

        public void Pop()
        {
            if (length == 0)
            {
                top = null;
                bottom = null;
            }
            else if (length > 0)
            {
                Node temp = (Node)top.next;
                top = temp;
                length--;
            }            
        }

        public object[] GetList()
        {
            var arr = new object[length];
            var currNode = top;
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
