using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sys
{
    internal class Student
    {
        int id;
        StringBuilder name;
        Dictionary<Question, Answer> AnswersDict = new Dictionary<Question, Answer>();

        public int Id { get => id; set => id = value; }
        public StringBuilder Name { get => name; set => name = value; }

        public Student(int id, StringBuilder name, Exam e)
        {
            Id = id;
            Name = name;
            e.onStartExam += GetNotified;
        }

        public void startExam(FinalExam e)
        {
            Console.WriteLine($"Welcome {Name}, Please start writing your answers below");
            Console.WriteLine("-----------------------------------------------------------------------------\n");
            for (int i = 0; i < e.Content.Count; i++)
            {
                Console.WriteLine($"Enter ques no.{i+1} answer: ");
                Console.Write("--> ");
                string AnswerBody = Console.ReadLine();
                Answer A1 = new Answer(AnswerBody);

                //-->Store Answers in the dict of answers to compare it with the dict of the exam.
                AnswersDict.Add(e.Content.Keys.ElementAt(i), A1);

                Console.WriteLine("\n");
            }

            //Call function to calculate the degree.
            float PercentDegree = (float)ExamDegree(e) / (float)e.Content.Count;
            StringBuilder Grade;
            if (PercentDegree < 60)
            {
                Grade = new StringBuilder("Try again next year!");
            }
            else if(PercentDegree > 60 && PercentDegree < 85)
            {
                Grade = new StringBuilder("Very Good!");
            }
            else
            {
                Grade = new StringBuilder("Great Job, Execellent");
            }


            Console.WriteLine($"Your Grade is {PercentDegree * 100}%       {Grade}\n");

            //Diplay Exam Answers (Practice Exam)
            Console.Write("Do you want to see the exam answers? ");
            if (Console.ReadLine() == "yes")
            {
                Console.Clear();
                e.Pe.Show();
            };
        }

        private int ExamDegree(FinalExam e)
        {
            int Degree = 0;
            for (int i = 0; i < e.Content.Count; i++)
            {
                if (e.Content[e.Content.ElementAt(i).Key].Body.ToLower() == AnswersDict[e.Content.ElementAt(i).Key].Body.ToLower())
                {
                    Degree++;
                }
            }
            return Degree;
        }

        public void GetNotified(string notification)
        {
            Console.WriteLine(notification);
        }
    }
}
