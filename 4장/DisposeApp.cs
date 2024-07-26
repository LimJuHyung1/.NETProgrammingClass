//4-13 179p
class DisposeClass : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("In the Dispose ...");
        GC.SuppressFinalize(this);
    }
}
class DisposeApp
{
    public static void Main()
    {
        Console.WriteLine("Start of Main");
        using (DisposeClass obj = new DisposeClass())
        {

        }
        Console.WriteLine("End of Main");
    }
}