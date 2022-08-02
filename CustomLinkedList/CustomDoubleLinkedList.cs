using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    internal class CustomDoubleLinkedList
    {
        public Node head;
        public Node tail;        public Node prev;
        public int length;

        public CustomDoubleLinkedList(object value)
        {
            head = new Node(value);

            tail = head;
            length = 1;
        }

        public void Append(object value)
        {
            var newNode = new Node(value);
            newNode.prev = tail;
            tail.next = newNode;
            tail = newNode;
            length++;
        }

        public void Preppend(object value)
        {
            var newNode = new Node(value);
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
            length++;
        }

        public object[] GetList()
        {
            var arr = new object[length];
            var currNode = head;
            var count = 0;
            while (currNode != null)
            {
                if (count == length)
                    break;
                arr[count] = currNode.value;
                currNode = (Node)currNode.next;
                count++;
            }
            return arr;
        }

        public object[] Insert(int index, object value)
        {
            if (index == 0)
            {
                Preppend(value);
                return GetList();
            }
            var newNode = new Node(value);
            Node leaderNode = TraverseToIndex(index-1);
            Node follower = (Node)leaderNode.next;
            leaderNode.next = newNode;
            newNode.prev = leaderNode;
            newNode.next = follower;
            follower.prev = newNode;
            length++;
            return GetList();
        }

        public object[] Remove(int index)
        {
            if (index > length)
                return GetList();
            if (index == 0)
            {
                Node currHead = head;
                head = (Node)currHead.next;
                length--;
                if (length == 0)
                    tail = head;

                return GetList();
            }
            Node prevNode = TraverseToIndex(index-1);
            Node nextNode = (Node)prevNode.next;
            nextNode.prev = prevNode;
            prevNode.next = nextNode.next;
            length--;
            return GetList();
        }

        public Node TraverseToIndex(int index)
        {
            int counter = 0;
            var currNode = head;
            while (counter != index)
            {
                currNode = (Node?)currNode.next;
                counter++;
            }

            return currNode;
        }
    }
}
