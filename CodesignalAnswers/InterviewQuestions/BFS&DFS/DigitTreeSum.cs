using CodesignalAnswers.InterviewQuestions.TreeBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.BFS_DFS
{
    internal class DigitTreeSum
    {
        //
        // Binary trees are already defined with this interface:
        // class Tree<T> {
        //   public T value { get; set; }
        //   public Tree<T> left { get; set; }
        //   public Tree<T> right { get; set; }
        // }

        List<long> res = new List<long>();

        long solution(Tree<int> t)
        {
            recur(t, "");

            return res.Sum();
        }

        void recur(Tree<int> t, string numberList)
        {
            numberList = numberList + t.value;

            if (t.right == null && t.left == null)
            {
                res.Add(Convert.ToInt64(numberList));
            }

            if (t.right != null)
                recur(t.right, numberList);


            if (t.left != null)
                recur(t.left, numberList);
        }
    }
}
