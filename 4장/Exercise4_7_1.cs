using System;

class Exercise4_7_1
{
    static void Inc(ref int x, int y)
    {
        ++x; ++y;
        Console.WriteLine("   Inc: x = {0}, y = {1}", x, y);
    }
    public static void Main()
    {
        int x = 1;
        int y = 1;
        Console.WriteLine("Before: x = {0}, y = {1}", x, y);
        Inc(ref x, y);
        Console.WriteLine(" After: x = {0}, y = {1}", x, y);
    }
}