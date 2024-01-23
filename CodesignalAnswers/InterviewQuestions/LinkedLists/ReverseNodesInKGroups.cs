using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.LinkedLists
{
    internal class ReverseNodesInKGroups
    {
        // Singly-linked lists are already defined with this interface:
        // class ListNode<T> {
        //   public T value { get; set; }
        //   public ListNode<T> next { get; set; }
        // }
        //
        ListNode<int> solution(ListNode<int> l, int k)
        {

            if (l == null)
            {
                return l;
            }
            ListNode<int> tmp = new ListNode<int>();
            tmp.next = l;
            ListNode<int> prev = tmp;
            int i = 0;
            ListNode<int> x = l;
            while (x != null)
            {
                i++;
                if (i % k == 0)
                {
                    prev = reverse(prev, x.next);
                    x = prev.next;
                }
                else
                {
                    x = x.next;
                }
            }
            return tmp.next;
        }
        ListNode<int> reverse(ListNode<int> l, ListNode<int> j)
        {
            ListNode<int> tmp = l.next;
            ListNode<int> curr = tmp.next;
            while (curr != j)
            {
                tmp.next = curr.next;
                curr.next = l.next;
                l.next = curr;
                curr = tmp.next;
            }

            return tmp;
        }

    }
}
