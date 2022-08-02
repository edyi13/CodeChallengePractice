using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBinaryTree
{
    internal class Program
    {
        static void Main(String[] args)
        {

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

            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(9);
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(6);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(170);
            binarySearchTree.Insert(15);
            binarySearchTree.Insert(1);


            Console.WriteLine(JsonConvert.SerializeObject(binarySearchTree.Traverse(binarySearchTree.root), Formatting.Indented));
            Console.WriteLine("/**************************************/");
            //Console.WriteLine(JsonConvert.SerializeObject(binarySearchTree.Lookup(20), Formatting.Indented));
            binarySearchTree.Remove(20);
            Console.WriteLine(JsonConvert.SerializeObject(binarySearchTree.Traverse(binarySearchTree.root), Formatting.Indented));




        }
    }
}