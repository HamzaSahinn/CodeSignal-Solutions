using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.LinkedLists
{
    internal class RemoveKFromList
    {
        // Singly-linked lists are already defined with this interface:
        //class ListNode<T> {
        // public T value { get; set; }
        //public ListNode<T> next { get; set; }
        //}
        //
        ListNode<int> solution(ListNode<int> l, int k)
        {

            if (l == null)
            {
                return l;
            }
            while (l != null && l.value == k)
            {
                l = l.next;
            }

            ListNode<int> n = l;

            while (n != null && n.next != null)
            {
                if (n.next.value == k)
                {
                    n.next = n.next.next;
                }
                else
                {
                    n = n.next;
                }
            }

            return l;

        }

    }
}
