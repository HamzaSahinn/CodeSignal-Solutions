using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.HashTables
{
    internal class AreFollowingPatterns
    {
        bool solution(string[] strings, string[] patterns)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            Dictionary<string, string> dict2 = new Dictionary<string, string>();

            for (int i = 0; i < strings.Length; i++)
            {
                if (dict.ContainsKey(strings[i]))
                {
                    if (dict[strings[i]] != patterns[i])
                        return false;
                }
                else
                {
                    dict.Add(strings[i], patterns[i]);
                }

                if (dict2.ContainsKey(patterns[i]))
                {
                    if (dict2[patterns[i]] != strings[i])
                        return false;
                }
                else
                {
                    dict2.Add(patterns[i], strings[i]);
                }
            }

            return true;
        }

    }
}
