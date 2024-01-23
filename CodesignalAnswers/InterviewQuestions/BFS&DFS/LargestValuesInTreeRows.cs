using CodesignalAnswers.InterviewQuestions.TreeBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.BFS_DFS
{
    internal class LargestValuesInTreeRows
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

            if (t == null)
                return new int[0];

            Queue<Tree<int>> que = new Queue<Tree<int>>();
            List<Tree<int>> tempList = new List<Tree<int>>();

            que.Enqueue(t);

            List<int> res = new List<int>();

            while (que.Count > 0)
            {
                while (que.Count > 0)
                {
                    tempList.Add(que.Dequeue());
                }

                tempList = tempList.Where(e => e != null).ToList();

                if (tempList.Count == 0)
                    continue;

                res.Add(tempList.Max(e => e.value));

                tempList.ForEach(e => { que.Enqueue(e.left); que.Enqueue(e.right); });
                tempList.Clear();
            }

            return res.ToArray();
        }

    }
}
