using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.LinkedLists
{
    internal class RearrangeLastN
    {
        // Singly-linked lists are already defined with this interface:
        // class ListNode<T> {
        //   public T value { get; set; }
        //   public ListNode<T> next { get; set; }
        // }
        //
        ListNode<int> solution(ListNode<int> l, int n)
        {

            if (l == null || n == 0)
                return l;

            ListNode<int> res = l;
            ListNode<int> temp = l;

            int size = 0;
            // Find Size of list
            while (temp != null)
            {
                size += 1;
                if (temp.next != null)
                {
                    temp = temp.next;
                }
                else
                {
                    break;
                }
            }

            if (size == n)
                return l;

            temp = l;

            //get last n element, head of last n element is in temp
            for (int i = 1; i < size - n; i++)
            {
                temp = temp.next;
            }
            //next is the first element of last n element
            ListNode<int> next = temp.next;

            //split last n element from others
            temp.next = null;

            //temp is the first element of last n elements
            temp = next;

            //get last element of temp
            while (temp.next != null)
            {
                temp = temp.next;
            }
            //connect last element of temp to previous elements head
            temp.next = l;
            // return last n element head
            return next;
        }

    }
}
