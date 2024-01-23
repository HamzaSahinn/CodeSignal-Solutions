using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.Arrays
{
    internal class Sudoku2
    {

        bool solution(char[][] grid)
        {

            bool rowsValid = grid.All(row => {
                var temp = row.ToList().Where(c => c != '.');
                return temp.Count() == temp.Distinct().Count();
            });

            if (!rowsValid)
                return false;

            for (int i = 0; i < grid[0].Count(); i++)
            {
                var temp = Enumerable.Range(0, grid.GetLength(0)).Select(x => grid[x][i]);

                temp = temp.Where(e => e != '.');

                if (temp.Count() != temp.Distinct().Count())
                    return false;
            }

            List<char> temp1 = new List<char>();

            for (int i = 0; i < grid.Count(); i += 3)
            {
                temp1.Clear();
                for (int j = 0; j < grid[0].Count(); j += 3)
                {
                    temp1.Clear();

                    temp1.AddRange(grid[i].Skip(j).Take(3).Where(e => e != '.'));
                    temp1.AddRange(grid[i + 1].Skip(j).Take(3).Where(e => e != '.'));
                    temp1.AddRange(grid[i + 2].Skip(j).Take(3).Where(e => e != '.'));

                    if (temp1.Count() != temp1.Distinct().Count())
                        return false;
                }
            }

            return true;
        }

    }
}
