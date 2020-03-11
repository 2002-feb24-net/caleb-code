using RPS.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    // class (and interface etc.) - the default access is internal
    //only access that makes sense is public or internal (internal is private to this project
    class InputterOutputter : IInputterOutputter
    {
        public void Output(string str)
        {
            Console.WriteLine(str);
        }

        public string Input()
        {
            return Console.ReadLine();
        }
    }
}
