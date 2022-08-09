using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeLinkedList
{
    internal class Solution
    {
        public static bool nodeIsPalindrome(ListNode head)
        {
            //input: head type ListNode of a LinkedList
            //Output: true or false type boolean
            //Desire big O notation: 0(n) in time and 0(1) in space
            //Example:
            //The input [1,2,2,1] should return true
            if (head.next == null) return true;
            StringBuilder sb = new StringBuilder();

            while (head != null)
            {
                if (head != null)
                    sb.Append(head.val);
                head = head.next;
            }

            char[] actual = sb.ToString().ToCharArray();
            char[] reversed = sb.ToString().ToCharArray();
            Array.Reverse(reversed);

            for (int i = 0; i < reversed.Length; i++)
            {
                if (reversed[i] != actual[i])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(String[] args)
        {
            ListNode listNode = new ListNode();
            listNode.val = 1;
            ListNode listNode2 = new ListNode();
            listNode2.val = 2;
            ListNode listNode3 = new ListNode();
            listNode3.val = 2;
            ListNode listNode4 = new ListNode();
            listNode4.val = 1;

            listNode.next = listNode2;
            //listNode.next.next = listNode3;
            //listNode.next.next.next = listNode4;

            Console.WriteLine(nodeIsPalindrome(listNode));
        }
    }
}
