// 4-7 172p
class ParameterArrayApp
{
    static void ParameterArray(params object[] obj)
    {
        for (int i = 0; i < obj.Length; i++)
        {
            Console.WriteLine(obj[i]);
        }
    }
    public static void Main()
    {
        ParameterArray(123, "Hello", true, 'A');
    }
}