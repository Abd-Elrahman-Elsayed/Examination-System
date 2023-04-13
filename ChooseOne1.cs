using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sys
{
    internal class ChooseOneQuestion:Question
    {
        public ChooseOneQuestion(string _header, List<string> _body ,int _marks, int answerIndex) :base(_header, _body, _marks, answerIndex) { }
    }
}
