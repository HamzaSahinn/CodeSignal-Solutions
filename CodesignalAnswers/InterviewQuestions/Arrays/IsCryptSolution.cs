using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.Arrays
{
    internal class IsCryptSolution
    {
        bool solution(string[] crypt, char[][] solution)
        {

            var number1 = createNumber(crypt[0], solution);
            var number2 = createNumber(crypt[1], solution);
            var number3 = createNumber(crypt[2], solution);

            var numeric = new long[]{isValidString(string.Join("",number1)),
                            isValidString(string.Join("", number2)),
                            isValidString(string.Join("", number3))};

            if (numeric.Any(n => n == -1))
            {
                return false;
            }

            return numeric[0] + numeric[1] == numeric[2] ? true : false;
        }
        List<char> createNumber(string s, char[][] solution)
        {
            List<char> number = new List<char>();

            s.ToCharArray().ToList().ForEach(c =>
            {
                number.Add(solution.ToList().Where(s =>
                {
                    return s.ElementAt(0) == c;
                }).ElementAt(0).ElementAt(1));
            });

            return number;
        }

        long isValidString(string input)
        {
            long num;

            if (input[0] == '0' && input.Length > 1)
                return -1;

            if (long.TryParse(input, out num))
            {
                Console.WriteLine(num);
                return num;
            }
            return -1;
        }

    }
}
