using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodesignalAnswers.InterviewQuestions.TreeBasic
{
    internal class Tree<T>
    {
        public T value { get; set; }
        public Tree<T> left { get; set; }
        public Tree<T> right { get; set; }
    }
}
