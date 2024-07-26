using System;
//5.6 (2)
class BaseClass
{
    public bool Equal(object obj)
    {
        if (GetType() == obj.GetType()) return true;
        else return false;
    }
}
class DerivedClass : BaseClass { }
class Exercise5_6_2
{
    public static void Main()
    {
        BaseClass b1 = new BaseClass();
        BaseClass b2 = new BaseClass();
        DerivedClass d1 = new DerivedClass();
        DerivedClass d2 = new DerivedClass();
        if (b1.Equal(d1))
            Console.WriteLine("Derived equals Base.");
        if (d1.Equal(b1))
            Console.WriteLine("Base equals Derived.");
        if (b1.Equal(b2))
            Console.WriteLine("Base equals Base.");
        if (d1.Equal(d2))
            Console.WriteLine("Derived equals Derived.");
    }
}