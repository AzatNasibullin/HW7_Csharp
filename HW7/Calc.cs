using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    internal class Calc: iCalc
    {
        public double Result { get; set; } = 0;

        private Stack<double> LastResult { get; set; } = new Stack<double>();
       
        public event EventHandler<EventArgs> MyEventHandler;

        private void PrintResult() 
        {
            MyEventHandler?.Invoke(this, new EventArgs());
        }
        public void Devide(int x)
        {
            Result /= x;
            PrintResult();
            LastResult.Push(Result);
        }
        public void Multiply(int x)
        {
            Result *= x;
            PrintResult();
            LastResult.Push(Result);
        }
        public void Sub(int x)
        {
            Result -= x;
            PrintResult();
            LastResult.Push(Result);
        }
        public void Sum(int x, bool dontPrint)
        {
            Result += x;
            if (!dontPrint)
                PrintResult();
            LastResult.Push(Result);
        }
        
        public double Divide(int x)
        {
            throw new NotImplementedException();
        }

        public void CanselLast() 
        {
            if(LastResult.TryPop(out double res))
            {
                Result = res;
                Console.WriteLine("Последнее действие отменено.Результат равен:");
                PrintResult();
            }
            else 
            {
                Console.WriteLine("Нельзя отменить последнее действие!");
            }
        }

        void iCalc.Divide(int x)
        {
            throw new NotImplementedException();
        }

        public void Sum(int x)
        {
            throw new NotImplementedException();
        }

        public void Sub(int x, bool dontPrint)
        {
            throw new NotImplementedException();
        }
    }
}
