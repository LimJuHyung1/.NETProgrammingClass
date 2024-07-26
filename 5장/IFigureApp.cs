using System;

public interface IFigure
{
    void Area();
    void Girth();
    void Draw();
}

class Rectangle : IFigure
{
    public int w, h;
    public double area;
    public double girth;

    public Rectangle()
    {
        w = 1;
        h = 1;
    }
    public Rectangle(int w, int h)
    {
        this.w = w;
        this.h = h;
    }

    void IFigure.Area()
    {
        area = w * h;
    }

    void IFigure.Girth()
    {
        girth = (w + h) * 2;
    }

    void IFigure.Draw() { }      //MFC로 작성
}

class Circle : IFigure
{
    public int r;
    public double area;
    public double girth;

    public Circle()
    {
        r = 10;
    }
    public Circle(int r)
    {
        this.r = r;
    }

    void IFigure.Area()
    {
        area = r * r * 3.14;
    }

    void IFigure.Girth()
    {
        girth = r * 2 * 3.14;
    }

    void IFigure.Draw() { }      //MFC로 작성
}

class IFigureApp
{
    public static void Main()
    {
        Rectangle rect = new Rectangle(100, 90);
        Circle cir = new Circle(130);

        ((IFigure)rect).Area();
        ((IFigure)rect).Girth();
        Console.WriteLine("rect's area = " + rect.area);
        Console.WriteLine("rect's grith = " + rect.girth);

        Console.WriteLine("");

        ((IFigure)cir).Area();
        ((IFigure)cir).Girth();
        Console.WriteLine("cir's area = " + cir.area);
        Console.WriteLine("cir's grith = " + cir.girth);

    }
}