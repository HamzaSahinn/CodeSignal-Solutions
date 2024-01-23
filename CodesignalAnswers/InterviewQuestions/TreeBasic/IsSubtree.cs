using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.TreeBasic
{
    internal class IsSubtree
    {
        //
        // Binary trees are already defined with this interface:
        // class Tree<T> {
        //   public T value { get; set; }
        //   public Tree<T> left { get; set; }
        //   public Tree<T> right { get; set; }
        // }
        bool solution(Tree<int> t1, Tree<int> t2)
        {
            Queue<Tree<int>> que = new Queue<Tree<int>>();

            que.Enqueue(t1);

            if ((t1 != null && t2 == null) || (t2 == null && t1 == null))
                return true;

            while (que.Count() > 0)
            {
                var tempT = que.Dequeue();

                if (tempT == null)
                    continue;

                if (tempT.value == t2.value)
                {
                    if (isSameTree(tempT, t2))
                        return true;
                }

                que.Enqueue(tempT.left);
                que.Enqueue(tempT.right);
            }

            return false;
        }

        bool isSameTree(Tree<int> t1, Tree<int> t2)
        {
            if (t1 == null && t2 == null)
                return true;

            if (t1 == null || t2 == null || t1.value != t2.value)
                return false;

            if (isSameTree(t1.right, t2.right) && isSameTree(t1.left, t2.left))
                return true;

            return false;
        }
    }
}
