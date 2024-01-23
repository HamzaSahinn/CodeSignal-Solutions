using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.TreeBasic
{
    internal class FindProfession
    {
        string solution(int level, int pos)
        {
            if (pos == 1)
                return "Engineer";

            if (solution(level - 1, (pos + 1) / 2) == "Doctor")
            {
                return pos % 2 == 1 ? "Doctor" : "Engineer";
            }

            return pos % 2 == 0 ? "Doctor" : "Engineer";
        }

    }
}
