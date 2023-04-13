using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sys
{
    delegate void ExamStarting (string str);

    internal abstract class Exam : IComparable<Exam>, ICloneable
    {
        byte timeInHours;
        static byte numOfQuestions = 10;
        Dictionary<Question, Answer> content;
        Subject subject;
        QuestionList qL;
        ExamStatus status = ExamStatus.Queued;
        public event ExamStarting onStartExam;

        internal QuestionList QL { get => qL; set { 
                if(value.Subject.Name == this.Subject.Name)
                {
                    qL = value;
                }
                else
                {
                    Console.WriteLine("Wrong list");
                };
            } }
        public byte TimeInHours { get => timeInHours; set { if (value >= 2) timeInHours = value; } }
        internal Dictionary<Question, Answer> Content { get => content; set => content = value; }
        internal Subject Subject { get => subject; set => subject = value; }
        internal ExamStatus Status { get => status; set { 
                if(status == ExamStatus.Starting)
                {
                    onStartExam.Invoke("Your Exam has been started");
                }
                status = value; 
            } }

        public Exam(Subject subject, QuestionList ql)
        {
            Subject = subject;
            QL = ql;
            TimeInHours = 2;
            content= new Dictionary<Question, Answer>();
        }

        public abstract void Show();

        public int CompareTo(Exam? other)
        {
            if (other== null) return -1;
            return Subject.Name.CompareTo(other.Subject.Name);
        }

        public object Clone()
        {
            Exam E =  (Exam)MemberwiseClone();
            E.Subject = new Subject(Subject.Name);
            return E;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Exam exam= obj as Exam;
            return (Subject.Name == exam.Subject.Name && QL == exam.QL);
        }

        public override string ToString()
        {
            return $"Exam of {Subject.Name}, Duration: {TimeInHours} Hours, Status: {Status}\n" +
                $"No.Of Questions: {numOfQuestions}.";
        }

        public override int GetHashCode()
        {
            return (Subject.Name+" "+numOfQuestions).GetHashCode();
        }
    }
}
