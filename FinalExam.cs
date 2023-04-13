using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sys
{
    internal class FinalExam : Exam
    {
        static int counter = 1;
        PracticeExam pe;


        public FinalExam(Subject subject, QuestionList ql) : base(subject, ql) { 
            Pe = new PracticeExam(subject, ql);
        }

        internal PracticeExam Pe { get => pe; set => pe = value; }

        public override void Show()
        {
            Console.WriteLine($"\"{QL.Subject.Name}\" Final Exam             Duration: {TimeInHours} Hours                Total Degrees: {QL.Subject.Marks}");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------\n");
            
            foreach (var item in QL)
            {
                //-->Adding to exam dictionary
                Content.Add(item, item.Answer);

                //-->Showing exam in the console
                Console.WriteLine($"{counter}) {item.Header}");
                foreach (var item2 in item.Body)
                {
                    Console.WriteLine($"=>{item2}");
                }
                counter++;
                Console.WriteLine("\n");
            }
        }
    }
}
