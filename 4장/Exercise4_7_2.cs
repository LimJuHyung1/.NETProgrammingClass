using System;
delegate void ExDelegator(string str);

class Ex
{
    public static void StaticMethod(string str)
    {
        Console.Write(str);
        Console.WriteLine("\tFramework");
    }
    public void InstanceMethod(string str)
    {
        Console.Write(str);
        Console.WriteLine("\tPrograming Language");
    }
}

class ExcerciseCh4_7_2
{
    public static void Main()
    {
        Ex ex = new Ex();
        ExDelegator d1 = new ExDelegator(ex.InstanceMethod);
        ExDelegator d2 = new ExDelegator(Ex.StaticMethod);
        d1("C#");
        d2(".NET");
    }
}