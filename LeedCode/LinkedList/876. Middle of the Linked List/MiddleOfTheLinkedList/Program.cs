////https://leetcode.com/problems/middle-of-the-linked-list/description/

using System;

namespace MiddleOfTheLinkedList
{
    /// <summary>
    /// Program
    /// </summary>
    /// <seealso cref="Object" />
    class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                            {
                                next = new ListNode(6)
                            }
                        }
                    }
                }
            };

            Console.WriteLine("Print initial Linked List:");
            printLinkedList(head);
            var solution = new Solution();
            var result = solution.MiddleNode(head);
            Console.WriteLine();
            Console.WriteLine(String.Format("Print result: {0}", result.val));
            Console.ReadKey();
        }

        /// <summary>
        /// Prints the list node.
        /// </summary>
        /// <param name="node">The node.</param>
        private static void printLinkedList(ListNode node)
        {
            Console.Write(node.val);
            if (node.next != null)
            {
                Console.Write(" => ");
                printLinkedList(node.next);
            }
        }
    }

    //Definition for singly-linked list.
    public class ListNode
    {
        /// <summary>
        /// The value
        /// </summary>
        public int val;

        /// <summary>
        /// The next
        /// </summary>
        public ListNode next;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNode"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        public ListNode(int x) { val = x; }
    }

    /// <summary>
    /// Solution
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Middles the node.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <returns></returns>
        public ListNode MiddleNode(ListNode head)
        {
            var count = head.GetLength();
            if (count <= 1)
                return head;

            var middleIndex = count / 2 + 1;
            var currentNode = head;

            ListNode result = null;
            var counter = 1;
            while (result == null)
            {
                if (counter == middleIndex)
                    result = currentNode;
               
                currentNode = currentNode.next;
                counter++;
            }
  
            return result;
        }
    }

    /// <summary>
    /// NodeExtentions
    /// </summary>
    public static class NodeExtentions
    {
        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <returns></returns>
        public static int GetLength(this ListNode head)
        {
            if (head == null)
                return 0;

            var count = 1;
            var node = head;
            while (node.next != null)
            {
                node = node.next;
                count++;
            }

            return count;
        }
    }
}
