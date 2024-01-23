using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.HashTables
{
    internal class GroupingDishes
    {
        string[][] solution(string[][] dishes)
        {

            var list = dishes.ToList();

            Dictionary<string, List<string>> lookup = new Dictionary<string, List<string>>();

            list.ForEach(e => {

                e.Skip(1).ToList().ForEach(k => {
                    if (lookup.ContainsKey(k))
                    {
                        lookup[k].Add(e.ElementAt(0));
                    }
                    else
                    {
                        lookup.Add(k, new List<string>());
                        if (!lookup[k].Contains(e.ElementAt(0)))
                            lookup[k].Add(e.ElementAt(0));
                    }
                });
            });

            var keysSorted = lookup.Keys.ToList();

            keysSorted = keysSorted.Where(e => lookup[e].Count > 1).ToList();
            keysSorted = keysSorted.OrderBy(x => x, StringComparer.Ordinal).ToList();

            string[][] res = new string[keysSorted.Count][];

            int index = 0;
            keysSorted.ForEach((e) => {
                lookup[e] = lookup[e].OrderBy(x => x, StringComparer.Ordinal).ToList();

                lookup[e].Insert(0, e);

                res[index] = lookup[e].ToArray();
                index++;
            });


            return res;
        }

    }
}
