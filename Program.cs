using System.Text;

namespace Ex_Sys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Asia", "Africa", "Austrulia", "Europe"};
            List<string> list2 = new List<string>() { "Alex", "Mansoura", "Tanta", "All" };

            #region Questions
            ChooseOneQuestion q1 = new ChooseOneQuestion("In Which contenent does Egypt exist?", list, 5, 1);
            ChooseAllQuestion q2 = new ChooseAllQuestion("In Which ITI branch does C# being studied?", list2, 5);
            TrueOrFalse q3 = new TrueOrFalse("Will Artificial Intelligence replace developers?", 5, "False");
            ChooseOneQuestion q4 = new ChooseOneQuestion("In Which contenent does Libya exist?", list, 5, 1);
            ChooseAllQuestion q5 = new ChooseAllQuestion("In Which ITI branch does C++ being studied?", list2, 5);
            TrueOrFalse q6 = new TrueOrFalse("Will Artificial Intelligence replace engineers?", 5, "False");
            ChooseOneQuestion q7 = new ChooseOneQuestion("In Which contenent does Morroco exist?", list, 5, 1);
            ChooseAllQuestion q8 = new ChooseAllQuestion("In Which ITI branch does C being studied?", list2, 5);
            TrueOrFalse q9 = new TrueOrFalse("Will Artificial Intelligence replace rabbits?", 5, "False");
            ChooseOneQuestion q10 = new ChooseOneQuestion("In Which contenent does Oughanda exist?", list, 5, 1);
            #endregion

            #region QuestionList1
            QuestionList ql1 = new QuestionList(new Subject("Robotics"));
            ql1.Add(q1);
            ql1.Add(q2);
            ql1.Add(q3);
            ql1.Add(q4);
            ql1.Add(q5);
            ql1.Add(q6);
            ql1.Add(q7);
            #endregion

            #region QuestionList2
            QuestionList ql2 = new QuestionList(new Subject("MVC"));
            ql2.Add(q1);
            ql2.Add(q2);
            ql2.Add(q3);
            ql2.Add(q4);
            ql2.Add(q5);
            ql2.Add(q6);
            ql2.Add(q7);
            ql2.Add(q8); 
            #endregion


            FinalExam Final = new FinalExam(new Subject("MVC"), ql2);
            PracticeExam Practice = new PracticeExam(new Subject("Robotics"), ql1);

            Student S1 = new Student(5, new StringBuilder("Ali"), Final);
            /*Final.Status = ExamStatus.Starting;*/

            string ExamType = string.Empty;
            do
            {
                Console.Write("What kind of Exam do you want to show (Final or Practice) ?  ");
                ExamType = Console.ReadLine().ToLower();
                Console.Clear();

                if (ExamType.ToLower() == "final")
                {
                    Final.Show();
                    S1.startExam(Final);
                }
                else if (ExamType.ToLower() == "practice")
                {
                    Practice.Show();
                }
                else
                {
                    Console.WriteLine("Please write final or practice to detect your desired exam type!");
                }

            } while (ExamType.ToLower() != "final" && ExamType.ToLower() != "parctice");
        }
        static void Main1()
        {
            List<int> l = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rn = new Random();
            l = l.OrderBy(x=>rn.Next()).ToList();

            foreach (var item in l)
            {
                Console.WriteLine(item);
            }

            Dictionary<string,int> dic = new Dictionary<string,int>();
            dic.Add("g", 1);
            dic.Add("h", 2);
            dic.Add("y", 3);

            Console.WriteLine(dic.Keys.ElementAt(1)); 

        }
    }
}