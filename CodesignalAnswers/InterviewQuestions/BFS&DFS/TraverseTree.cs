using CodesignalAnswers.InterviewQuestions.TreeBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.BFS_DFS
{
    internal class TraverseTree
    {
        //
        // Binary trees are already defined with this interface:
        // class Tree<T> {
        //   public T value { get; set; }
        //   public Tree<T> left { get; set; }
        //   public Tree<T> right { get; set; }
        // }
        int[] solution(Tree<int> t)
        {
            Queue<Tree<int>> que = new Queue<Tree<int>>();

            que.Enqueue(t);

            List<int> res = new List<int>();

            while (que.Count > 0)
            {
                var tempT = que.Dequeue();

                if (tempT == null)
                    continue;

                res.Add(tempT.value);

                que.Enqueue(tempT.left);
                que.Enqueue(tempT.right);
            }

            return res.ToArray();
        }

    }
}
