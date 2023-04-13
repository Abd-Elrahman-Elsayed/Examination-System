using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sys
{
    internal class AnswerList:List<Answer>
    {
        static int fileCounter = 0;
        string path;

        public AnswerList()
        {
            fileCounter++;
        }

        public void AddAnswer(Answer answer)
        {
            base.Add(answer);
            path = @"F:\iTi\QuesList" + fileCounter.ToString() + "(Answers).txt";

            using (var sw = new StreamWriter(path, true))
            {
                sw.WriteLine("QuesNum: "+ answer.QuesId + ", Answer: " + answer.Body);
                sw.WriteLine("\n");
            }
        }
    }
}
