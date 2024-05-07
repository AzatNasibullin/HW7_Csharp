using HW7;

internal class Program
{ 
    delegate void MyDelegate(string message);

    private static void Main(string[] args)
    {
        var calc = new Calc();
        calc.MyEventHandler += Calc_MyEventHandler;
       
        bool firstNum = true;

        while (true)
        {
            if (firstNum) 
            {
                Console.WriteLine("Введите число:");
                calc.Sum(Convert.ToInt32(Console.ReadLine()),true);
                firstNum = false;
            }
            
            Console.WriteLine("\nВыберите операцию (+, -, *, /) или введите 'отмена' для завершения:");
            string operation = Console.ReadLine();
            if (operation == "отмена" || string.IsNullOrEmpty(operation))
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            Console.WriteLine("Введите число:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            switch (operation)
            {
                case "+":
                    calc.Sum(num1,false);
                    continue;
                    ;
                case "-":
                    calc.Sub(num1);
                    continue;
                case "*":
                    calc.Multiply(num1);
                    continue;
                case "/":
                    calc.Devide(num1);
                    continue;
                default:
                    Console.WriteLine("Некорректная операция.");
                    continue;
            }
        }
        
        
        
        //var calc = new Calc();

        // calc.MyEventHandler += Calc_MyEventHandler;
        //calc.Multiply(10);
        //calc.Sub(1);
        //calc.Sum(2);
        //calc.Devide(4);
        //calc.CanselLast();
        //calc.CanselLast();
        //calc.CanselLast();
        //calc.CanselLast();
        //calc.CanselLast();

        //List<string> list = new List<string>() {"1","2","3"};

        //Parse(list, int.Parse, (x) => Console.WriteLine(x));

    }

    private static void Calc_MyEventHandler(object? sender,EventArgs e)
    {
        if (sender is Calc)
        
            Console.WriteLine(((Calc)sender).Result);
    }

    static void Parse(List<string> ListStr,Func<string,int> func,Action<int> action)
    { 
        foreach (var item in ListStr) 
        { 
            int res = func(item);
            action(res);
        }
    }
}