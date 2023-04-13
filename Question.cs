using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sys
{
    internal abstract class Question
    {
        int marks;
        List<string> body;
        string header;
        Answer answer;

        public int Marks { get => marks; set => marks = value; }
        public List<string> Body { get => body; set => body = value; }
        public string Header { get => header; set => header = value; }
        internal Answer Answer { get => answer; set => answer = value; }

        public Question(string header, List<string> body, int marks, int answerIndex)
        {
            Marks = marks;
            Body = body;
            Header = header;
            Answer = new Answer(body[answerIndex]);
        }

        public override string ToString()
        {
            return header.ToString();
        }

        public override bool Equals(object? obj)
        {
            if(obj == null) return false;
            Question question= obj as Question;
            return header==question.header;
        }

        public override int GetHashCode()
        {
            return header.GetHashCode();
        }
    }
}
