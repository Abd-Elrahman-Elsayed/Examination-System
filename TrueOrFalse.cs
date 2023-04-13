using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Sys
{
    internal class TrueOrFalse:Question
    {
        static string[] arr = { "True", "False" }; 
        static List<string> TOrF = new List<string>() { "True", "False"};
        public TrueOrFalse(string _header, int _marks, string TrueOrFalse) : base(_header, TOrF, _marks, Array.IndexOf(arr,TrueOrFalse)) { }
    }
}
