using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.LinkedLists
{
    internal class IsListPalindrome
    {
        // Singly-linked lists are already defined with this interface:
        // class ListNode<T> {
        //   public T value { get; set; }
        //   public ListNode<T> next { get; set; }
        // }
        //
        bool solution(ListNode<int> l)
        {
            if (l == null || l.next == null)
                return true;


            ListNode<int> n = l;

            double len = 1;

            while (n != null && n.next != null)
            {
                n = n.next;
                len += 1;
            }
            int halfStartIndex;

            Console.WriteLine(len);

            if (len % 2 == 0)
            {
                halfStartIndex = 1 + (int)len / 2;
            }
            else
            {
                halfStartIndex = 1 + (int)Math.Ceiling(len / 2);
            }

            Console.WriteLine(halfStartIndex);


            n = l;
            ListNode<int> halfStart = null;

            for (int i = 1; i < halfStartIndex; i++)
            {
                n = n.next;
            }

            n = reverseLinkedList(n);

            while (n != null)
            {
                if (n.value != l.value)
                {
                    return false;
                }

                n = n.next;
                l = l.next;
            }


            return true;
        }

        ListNode<int> reverseLinkedList(ListNode<int> l)
        {
            ListNode<int> prev = null;
            ListNode<int> curr = l;
            ListNode<int> temp = curr;

            while (curr != null)
            {
                temp = curr;
                curr = curr.next;
                temp.next = prev;
                prev = temp;
            }

            return prev;
        }
    }
}
