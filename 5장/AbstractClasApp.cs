using System;
abstract class Figure
{
    public abstract void Area();
    public abstract void Grith();
    public abstract void Draw();

}

class Circle : Figure
{
    int r;
    double area;
    double grith;
    public Circle()
    {
        this.r = 1;
    }
    public Circle(int n)
    {
        this.r = n;
    }
    public override void Area()
    {
        this.area = r * r * 3.14;
        Console.WriteLine("This circle's area is " + area);
    }
    public override void Grith()
    {
        this.grith = r * 2 * 3.14;
        Console.WriteLine("This circle's grith is " + grith);
    }
    public override void Draw()
    {
        throw new NotImplementedException();
    }
}

class Rect : Figure
{
    int w, h;
    double area;
    double grith;
    public Rect()
    {
        this.w = 1;
        this.h = 1;
    }
    public Rect(int n = 1, int m = 1)
    {
        this.w = n;
        this.h = m;
    }
    public override void Area()
    {
        this.area = w * h;
        Console.WriteLine("This rectangle's area is " + area);
    }
    public override void Grith()
    {
        this.grith = (w + h) * 2;
        Console.WriteLine("This rectangle's grith is " + grith);
    }
    public override void Draw()
    {
        throw new NotImplementedException();
    }
}

class AbstractClasApp
{
    public static void Main()
    {
        Circle obj1 = new Circle(100);
        Rect obj2 = new Rect(50, 80);
        obj1.Area();
        obj1.Grith();
        Console.WriteLine("");
        obj2.Area();
        obj2.Grith();
    }
}}