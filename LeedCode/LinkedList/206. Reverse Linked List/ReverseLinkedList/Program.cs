using System;

////https://leetcode.com/problems/reverse-linked-list/description/

namespace ReverseLinkedList
{
    /// <summary>
    /// 
    /// </summary>
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
                        }
                    }
                }
            };

            Console.WriteLine("Print initial Linked List:");
            printLinkedList(head);

            var solution = new Solution();
            var reversedList = solution.ReverseList(head);
            Console.WriteLine();
            Console.WriteLine("Print reversed Linked List:");
            printLinkedList(reversedList);
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
  public class ListNode {
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
    /// 
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Reverses the list.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head)
        {
            ListNode tempPreviousNode = null;
            var currentNode = head;
            while (currentNode != null)
            {
                var tempNextNode = currentNode.next;
                currentNode.next = tempPreviousNode;
                tempPreviousNode = currentNode;
                currentNode = tempNextNode;
            }
 
            return tempPreviousNode;
        }
    }
}
