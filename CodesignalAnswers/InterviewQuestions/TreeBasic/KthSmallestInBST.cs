using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.TreeBasic
{
    internal class KthSmallestInBST
    {
        //
        // Binary trees are already defined with this interface:
        // class Tree<T> {
        //   public T value { get; set; }
        //   public Tree<T> left { get; set; }
        //   public Tree<T> right { get; set; }
        // }
        int count = 0;

        int solution(Tree<int> t, int k)
        {
            return recursive(t, k).value;
        }

        Tree<int> recursive(Tree<int> t, int k)
        {
            if (t == null)
                return null;

            Tree<int> left = recursive(t.left, k);
            if (left != null)
            {
                return left;
            }

            count++;
            if (count == k)
            {
                return t;
            }

            return recursive(t.right, k);

        }

    }
}
