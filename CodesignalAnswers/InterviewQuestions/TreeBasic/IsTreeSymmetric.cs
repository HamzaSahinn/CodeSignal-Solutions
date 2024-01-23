using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.TreeBasic
{
    internal class IsTreeSymmetric
    {
        //
        // Binary trees are already defined with this interface:
        // class Tree<T> {
        //   public T value { get; set; }
        //   public Tree<T> left { get; set; }
        //   public Tree<T> right { get; set; }
        // }
        bool solution(Tree<int> t)
        {

            if (t == null)
                return true;

            if ((t.right == null && t.left != null) || (t.right != null && t.left == null))
                return false;

            if (t.right == null && t.left == null)
                return true;

            Queue<Tree<int>> rightQ = new Queue<Tree<int>>();
            Queue<Tree<int>> leftQ = new Queue<Tree<int>>();

            rightQ.Enqueue(t.right);
            leftQ.Enqueue(t.left);

            Tree<int> rightCurr;
            Tree<int> leftCurr;

            while (rightQ.Count() != 0 && leftQ.Count() != 0)
            {
                rightCurr = rightQ.Dequeue();
                leftCurr = leftQ.Dequeue();

                if (rightCurr.value != leftCurr.value)
                {
                    return false;
                }

                if (rightCurr.right != null && leftCurr.left != null)
                {
                    rightQ.Enqueue(rightCurr.right);
                    leftQ.Enqueue(leftCurr.left);
                }
                else if (rightCurr.right == null && leftCurr.left == null)
                {

                }
                else
                {
                    return false;
                }

                if (rightCurr.left != null && leftCurr.right != null)
                {
                    rightQ.Enqueue(rightCurr.left);
                    leftQ.Enqueue(leftCurr.right);
                }
                else if (rightCurr.left == null && leftCurr.right == null)
                {

                }
                else
                {
                    return false;
                }

            }


            return true;
        }

    }
}
