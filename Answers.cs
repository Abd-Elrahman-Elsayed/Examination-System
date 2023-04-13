using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sys
{
    internal class Answer
    {
        int quesId;
        string body;

        public Answer(string body)
        {
            Body= body;
        }

        public int QuesId { get => quesId; set => quesId = value; }
        public string Body { get => body; set => body = value; }
    }
}
