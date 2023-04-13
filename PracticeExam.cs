using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sys
{
    internal class PracticeExam : Exam
    {
        static int counter = 1;
        public PracticeExam(Subject subject, QuestionList ql):base(subject, ql) { }
        public override void Show()
        {
            Console.WriteLine($"         \"{QL.Subject.Name}\" Exam Answers                       Total Degrees: {QL.Subject.Marks}         ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------\n");

            foreach (var item in QL)
            {
                Console.WriteLine($"{counter}) {item.Header}");
                foreach (var item2 in item.Body)
                {
                    Console.WriteLine($"=>{item2}");
                }
                Console.WriteLine($"(Answer: {item.Answer.Body})\n");
                counter++;
            }

            Console.ReadLine();
        }
    }
}
