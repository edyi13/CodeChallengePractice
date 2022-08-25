using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class Program
    {
        //Examples:
        //If you know a solution is not far from the root of the tree:
        //Breadth First Search (BFS)

        //If the tree is very deep and solutions are rare: 
        //BFS --> Because DFS take long time with deep trees

        //If the tree is very wide:
        //Depth First Search (DFS) --> Because BFS will need too much memory

        //If solutions are frequent but located deep in the tree:
        //DFS

        //Determining whether a path exists between two nodes:
        //DFS

        //Finding the shortest path:
        //BFS

        static void Main(String[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(9);
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(6);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(170);
            binarySearchTree.Insert(15);
            binarySearchTree.Insert(1);

            //Console.WriteLine(JsonConvert.SerializeObject(binarySearchTree.BreadthFirstSearch(), Formatting.Indented));
            binarySearchTree.BreadthFirstSearchInt().ForEach(i => Console.Write("{0}\t", i));
            //Console.WriteLine("/**********************************/");
        }
    }
}
