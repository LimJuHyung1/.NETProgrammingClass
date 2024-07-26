// 4-12 177p        오류있음
class Destructor
{
    public Destructor()
    {
        Console.WriteLine("In the constructor ...");
    }
    ~Destructor()
    {
        Console.WriteLine("In the destructor ...");
    }
}
class DestructorApp
{
    public static void Main()
    {
        Console.WriteLine("Start of Main");
        Destructor d = new Destructor();
        Console.WriteLine("End of Main");
    }

}