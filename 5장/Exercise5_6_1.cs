using System;

//5.6 (1)

class BaseClass { public static int supNum = 100; }

class DerivedClass : BaseClass { public static int subNum = 200; }

public class Exercise5_6_1
{
    public static void Main()
    {
        Console.Write(BaseClass.supNum + ", " + DerivedClass.supNum);

        Console.WriteLine(", " + DerivedClass.subNum);
    }
}