using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.Arrays
{
    internal class FirstDuplicate
    {
        int solution(int[] a)
        {

            Dictionary<int, int> dubsDict = new Dictionary<int, int>();
            List<int> dubs = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (dubsDict.ContainsKey(a.ElementAt(i)))
                {
                    if (dubsDict[a.ElementAt(i)] == 1)
                    {
                        dubsDict[a.ElementAt(i)] = 2;
                        dubs.Add(i);
                    }
                }
                else
                {
                    dubsDict[a.ElementAt(i)] = 1;
                }
            }
            if (dubs.Count < 1)
                return -1;

            return a[dubs.Min()];
        }

    }
}
