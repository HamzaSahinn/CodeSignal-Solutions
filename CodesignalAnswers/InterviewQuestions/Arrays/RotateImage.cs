using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.Arrays
{
    internal class RotateImage
    {
        int[][] solution(int[][] a)
        {
            a = a.Reverse().ToArray();

            int temp1 = 0;
            int temp2 = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    temp1 = a[i][j];
                    temp2 = a[j][i];

                    a[i][j] = temp2;
                    a[j][i] = temp1;
                }
            }
            return a;
        }

    }
}
