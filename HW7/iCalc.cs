using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public interface iCalc
    {
        double Result { get; set; }
        void Sum(int x);
        void Sub(int x, bool dontPrint);
        void Divide(int x);
        void Multiply(int x);

        event EventHandler<EventArgs> MyEventHandler; 
    }
}
