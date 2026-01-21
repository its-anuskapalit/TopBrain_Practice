using System;
delegate void MyDelegate();

class Program
{
    static void Show()
    {
        Console.WriteLine("Single Delegate Method");
    }
    static void Show2()
    {
        Console.WriteLine("multiple Delegate Method");
    }


    static void Main()
    {
        MyDelegate d = Show;
        d+= Show2;
        d();
    }
}
