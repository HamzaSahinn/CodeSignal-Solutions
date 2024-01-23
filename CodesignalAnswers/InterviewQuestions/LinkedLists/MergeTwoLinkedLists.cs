using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.LinkedLists
{
    internal class MergeTwoLinkedLists
    {
        // Singly-linked lists are already defined with this interface:
        // class ListNode<T> {
        //   public T value { get; set; }
        //   public ListNode<T> next { get; set; }
        // }
        //
        ListNode<int> solution(ListNode<int> l1, ListNode<int> l2)
        {
            ListNode<int> result = new ListNode<int>();
            ListNode<int> temp = result;

            if (l1 == null)
                return l2;

            if (l2 == null)
            {
                return l1;
            }

            if (l1.value < l2.value)
            {
                result.value = l1.value;
                l1 = l1.next;
            }
            else
            {
                result.value = l2.value;
                l2 = l2.next;
            }

            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    temp.next = l2;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    temp.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    if (l1.value < l2.value)
                    {
                        temp.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        temp.next = l2;
                        l2 = l2.next;
                    }
                }


                temp = temp.next;
            }

            return result;
        }

    }
}
