////https://leetcode.com/problems/delete-node-in-a-linked-list/description/

using System;

namespace DeleteNodeInALinkedList
{
    class Program
    {
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
            solution.DeleteNode(head.next);
            Console.WriteLine();
            Console.WriteLine("Print result:");
            printLinkedList(head);
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
        /// Deletes the node.
        /// </summary>
        /// <param name="node">The node.</param>
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
