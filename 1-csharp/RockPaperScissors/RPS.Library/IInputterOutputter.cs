using System;
using System.Collections.Generic;
using System.Text;

namespace RPS.Library
{
    //default interface access modifier is internal
    public interface IInputterOutputter
    {
        //nothing is private in an interface - that's the whole point - to have everything be found
        //you can't have access modifiers (no private/public) on interface members...
        //because they HAVE to have the same one as their containing types
        void Output(string str);
        string Input();
    }//we could improve this interface to better follow the interface segregation rules
}
