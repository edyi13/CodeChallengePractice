using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class BinarySearchTree
    {
        public Node? root { get; set; }
        public BinarySearchTree()
        {
            root = null;
        }

        public void InsertOld(int value)
        {
            Node node = new Node(value);
            if (root == null)
            {
                root = node;
            }
            else if (root.value < node.value)
            {
                if (root.right == null)
                {
                    root.right = node;
                }
                else if (root.right?.value < node.value)
                {
                    root.right.right = node;
                }
                else
                {
                    root.right.left = node;
                }
            }
            else if (root.value > node.value)
            {
                if (root.left == null)
                {
                    root.left = node;
                }
                else if (root.left?.value < node.value)
                {
                    root.left.right = node;
                }
                else
                {
                    root.left.left = node;
                }
            }
        }

        public void Insert(int value)
        {
            Node node = new Node(value);
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node currNode = root;
                while (true)
                {
                    if (node.value < currNode.value)
                    {
                        //Left
                        if (currNode.left == null)
                        {
                            currNode.left = node;
                            break;
                        }
                        currNode = currNode.left;
                    }
                    else
                    {
                        //Right
                        if (currNode.right == null)
                        {
                            currNode.right = node;
                            break;
                        }
                        currNode = currNode.right;
                    }
                }
            }
        }

        public Node Lookup(int value)
        {
            if (root == null)
                return null;

            if (value == root?.value)
                return root;


            Node currNode = root;
            while (currNode != null)
            {
                if (value < currNode.value)
                {
                    //Left
                    currNode = currNode.left;
                }
                else if (value > currNode.value)
                {
                    //Right
                    currNode = currNode.right;
                }
                else if (currNode.value == value)
                {
                    return currNode;
                }
            }

            return null;
        }

        public bool Remove(int value)
        {
            if (root == null)
                return false;

            if (value == root?.value)
            {
                root = null;
                return true;

            }

            Node currNode = root;
            Node parentNode = null;
            while (currNode != null)
            {
                if (value < currNode.value)
                {
                    //Left
                    parentNode = currNode;
                    currNode = currNode.left;
                }
                else if (value > currNode.value)
                {
                    //Right
                    parentNode = currNode;
                    currNode = currNode.right;
                }
                else if (currNode.value == value)
                {
                    //option 1: No right child 
                    if (currNode.right == null)
                    {
                        if (parentNode == null)
                        {
                            root = currNode.left;
                        }
                        else
                        {
                            //if parent > current value, make current left child a child of parent
                            if (currNode.value < parentNode.value)
                            {
                                parentNode.left = currNode.left;
                            }
                            //if parent < current value, make left child a right child of parent
                            else if (currNode.value > parentNode.value)
                            {
                                parentNode.right = currNode.left;
                            }
                        }
                    }
                    //option 2: Right child which doesnt have a left child
                    else if (currNode.right.left == null)
                    {
                        if (parentNode == null)
                        {
                            root = currNode.left;
                        }
                        else{
                            currNode.right.left = currNode.left;
                            //if parent > current, make right child on the left the parent
                            if (currNode.value < parentNode.value)
                            {
                                parentNode.left = currNode.right;
                            }
                            //if parent < current, make right child a right child of the parent
                            else if (currNode.value > parentNode.value)
                            {
                                parentNode.right = currNode.right;
                            }

                        }
                    }
                    //option 3: Right child that has a left child
                    else
                    {
                        //find the right child's left-most child
                        Node leftMost = currNode.right.left;
                        Node leftMostParent = currNode.right;

                        while (leftMost.left != null)
                        {
                            leftMostParent = leftMost;
                            leftMost = leftMostParent.left;
                        }

                        //parent's left subtree is now left-most's right subtree
                        leftMostParent.left = leftMost.right;
                        leftMost.left = currNode.left;
                        leftMost.right = currNode.right;

                        if (parentNode == null)
                        {
                            root = leftMost;
                        }
                        else
                        {
                            if (currNode.value < parentNode.value)
                            {
                                parentNode.left = leftMost;
                            }
                            else if(currNode.value > parentNode.value)
                            {
                                parentNode.right = leftMost;
                            }
                        }

                    }
                    return true;
                }
            }

            return false;
        }

        public Node Traverse(Node node)
        {
            Node tree = new Node(node.value);
            tree.left = node.left == null ? null : Traverse((Node)node.left);
            tree.right = node.right == null ? null : Traverse((Node)node.right);
            return tree;
        }

        //return the array without the first value
        public int[] Shift(int[] arr )
        {
            int[] tmp = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                tmp[(i + 1) % tmp.Length] = arr[i];
            }

            return tmp;
        }

        public List<Node> BreadthFirstSearch()
        {
            Node currNode = root;
            List<Node> list = new List<Node>();
            List<Node> queue = new List<Node>();
            queue.Add(currNode);

            while (queue.Count > 0)
            {
                var temp = queue.First();
                queue.Remove(temp);
                currNode = temp;
                list.Add(currNode);
                if (currNode.left != null)
                {
                    queue.Add(currNode.left);
                }

                if (currNode.right != null)
                {
                    queue.Add(currNode.right);
                }
            }
            return list;
        }

        public List<int> BreadthFirstSearchInt()
        {
            Node currNode = root;
            List<int> list = new List<int>();
            List<Node> queue = new List<Node>();
            queue.Add(currNode);

            while (queue.Count > 0)
            {
                var temp = queue.First();
                queue.Remove(temp);
                currNode = temp;
                list.Add(currNode.value);
                if (currNode.left != null)
                {
                    queue.Add(currNode.left);
                }

                if (currNode.right != null)
                {
                    queue.Add(currNode.right);
                }
            }
            return list;
        }
    }
}
