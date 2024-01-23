using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.TreeBasic
{
    internal class HasPathWithGivenSum
    {
        //
        // Binary trees are already defined with this interface:
        // class Tree<T> {
        //   public T value { get; set; }
        //   public Tree<T> left { get; set; }
        //   public Tree<T> right { get; set; }
        // }

        bool solution(Tree<int> t, int s)
        {
            if (t == null)
            {
                return false;
            }
            return checkTree(t, s, 0);
        }

        bool checkTree(Tree<int> t, int s, int sum)
        {
            int tempSum = sum + t.value;

            if (t.left == null && t.right == null && tempSum == s)
            {
                return true;
            }

            if (t.left == null && t.right == null)
            {
                return false;
            }

            if (t.left != null)
            {
                if (checkTree(t.left, s, tempSum))
                    return true;
            }

            if (t.right != null)
            {
                if (checkTree(t.right, s, tempSum))
                    return true;
            }
            return false;
        }


    }
}
