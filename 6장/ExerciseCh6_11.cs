using System;

class ISwap             //318p 6.11
{
    public int x, y;
    public void swap()
    {
        int temp;
        temp = x; x = y; y = temp;
    }
}

class DSwap
{
    public double x, y;
    public void swap()
    {
        double temp;
        temp = x; x = y; y = temp;
    }
}

class GSwap<T>
{
    public T x, y;
    public void swap()
    {
        T temp;
        temp = x; x = y; y = temp;
    }
}

public class ExerciseCh6_11
{
    public static void Main(String[] args)
    {
        ISwap i = new ISwap();
        i.x = 1; i.y = 2;
        Console.WriteLine("x: " + i.x + " y: " + i.y);
        i.swap();
        Console.WriteLine("x: " + i.x + " y: " + i.y);

        DSwap d = new DSwap();
        d.x = 1.0; d.y = 2.0;
        Console.WriteLine("x: " + d.x + " y: " + d.y);
        d.swap();
        Console.WriteLine("x: " + d.x + " y: " + d.y);

        GSwap<Int32> gi = new GSwap<Int32>();
        gi.x = 1; gi.y = 2;
        Console.WriteLine("a: " + gi.x + " b: " + gi.y);
        gi.swap();
        Console.WriteLine("a: " + gi.x + " b: " + gi.y);

        GSwap<Double> gd = new GSwap<Double>();
        gd.x = 1.5; gd.y = 2.5;
        Console.WriteLine("a: " + gd.x + " b: " + gd.y);
        gd.swap();
        Console.WriteLine("a: " + gd.x + " b: " + gd.y);
    }
}