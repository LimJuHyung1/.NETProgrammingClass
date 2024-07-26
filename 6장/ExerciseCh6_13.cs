using System;
class ExerciseCh6_13 : ApplicationException         //6.13
{
    public static void Main(string[] args)
    {
        int mysteriousState = int.Parse(Console.ReadLine());
        //int mysteriousState = int.Parse(args[0]);
        while (true)
        {
            Console.Write("Who ");
            try
            {
                Console.WriteLine("is ");
                if (mysteriousState == 1) return;
                Console.WriteLine("that ");
                if (mysteriousState == 2) break;
                Console.WriteLine("strange ");
                if (mysteriousState == 3) continue;
                Console.WriteLine("but kindly ");
                if (mysteriousState == 4)
                    throw new ExerciseCh6_13();
                Console.Write("not at all ");
            }
            finally
            {
                Console.Write("amusing ");
            }
            Console.Write("yet compelling ");
            break;
        }
        Console.Write("man?");
    }
}