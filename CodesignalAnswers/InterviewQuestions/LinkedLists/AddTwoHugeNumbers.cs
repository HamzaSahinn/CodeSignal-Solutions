using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.LinkedLists
{
    internal class AddTwoHugeNumbers
    {
        // Singly-linked lists are already defined with this interface:
        // class ListNode<T> {
        //   public T value { get; set; }
        //   public ListNode<T> next { get; set; }
        // }
        //
        ListNode<int> solution(ListNode<int> a, ListNode<int> b)
        {
            var listA = linkedList2List(a);
            var listB = linkedList2List(b);

            listA.Reverse();
            listB.Reverse();

            int lenA = listA.Count();
            int lenB = listB.Count();

            int maxLength = Math.Max(lenA, lenB);

            int i = 0;
            int j = 0;
            int carry = 0;

            List<int> res = new List<int>();

            for (int k = 0; k < maxLength; k++)
            {
                int val_a = 0;
                int val_b = 0;

                if (i < lenA)
                {
                    val_a = listA[i];
                    i += 1;
                }

                if (j < lenB)
                {
                    val_b = listB[j];
                    j += 1;
                }
                res.Add((val_a + val_b + carry) % 10000);
                carry = (val_a + val_b + carry) / 10000;
            }

            if (carry > 0)
            {
                res.Add(carry);
            }

            res.Reverse();

            ListNode<int> result = a;

            for (int l = 0; l < res.Count(); l++)
            {
                a.value = res.ElementAt(l);
                if (l != res.Count() - 1)
                {
                    a.next = new ListNode<int>();
                    a = a.next;
                }
            }

            return result;
        }

        List<int> linkedList2List(ListNode<int> l)
        {
            List<int> t = new List<int>();
            while (l != null)
            {
                t.Add(l.value);
                if (l.next != null)
                    l = l.next;
                else
                    break;
            }

            return t;
        }

    }
}
