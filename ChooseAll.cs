using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sys
{
    internal class ChooseAllQuestion:Question
    {
        public ChooseAllQuestion(string _header, List<string> _body, int _marks) : base(_header, _body, _marks, _body.Count - 1) { }
    }
}
