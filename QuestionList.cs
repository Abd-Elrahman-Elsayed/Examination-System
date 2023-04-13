using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sys
{
    internal class QuestionList : List<Question>
    {
        static int fileCounter = 0;
        static int quesCounter = 0;
        AnswerList ListOfAnswers;
        string path;
        Subject subject;


        public QuestionList(Subject subject)
        {
            quesCounter = 0;
            fileCounter++;
            ListOfAnswers = new AnswerList();
            this.subject = subject;
            Subject = subject;
        }

        internal Subject Subject { get => subject; set => subject = value; }

        public new void Add(Question question)
        {
            quesCounter++;
            question.Answer.QuesId = quesCounter;
            ListOfAnswers.AddAnswer(question.Answer);
            base.Add(question);


            path = @"F:\iTi\QuesList"+ fileCounter.ToString()+".txt";
            using (var sw = new StreamWriter(path,true))
            {
                sw.WriteLine(quesCounter.ToString() + "- " + question.Header);
                foreach (var i in question.Body)
                {
                    sw.WriteLine("   => " + i);
                }
                sw.WriteLine("\n");
            }
        }
    }
}
