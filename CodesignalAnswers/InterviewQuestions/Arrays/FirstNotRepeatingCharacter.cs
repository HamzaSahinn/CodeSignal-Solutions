using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.Arrays
{
    internal class FirstNotRepeatingCharacter
    {
        char solution(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (!dict.ContainsKey(c))
                    dict.Add(c, 1);

                else
                    dict[c] += 1;
            }

            var res = dict.Where(p => p.Value < 2).ToList();
            return res.Count() > 0 ? res.ElementAt(0).Key : '_';
        }

    }
}
