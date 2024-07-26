using System;
interface IOperation
{
    void Insert(string str);
    string Delete();
    bool Search(string str);
    string GetCurrentElt();
    int NumOfElements();
}

class Stack : IOperation
{
    private string[] stack;
    int sp = -1;

    public Stack()
    {
        stack = new string[100];
    }
    public Stack(int size)
    {
        stack = new string[size];
    }
    void IOperation.Insert(string str)
    {
        sp = sp + 1;
        stack[sp] = str;
    }
    string IOperation.Delete()
    {
        sp--;
        return stack[sp];
    }
    bool IOperation.Search(string str)
    {
        int tmp = 0;
        for (int i = 0; i <= sp; i++)
        {
            if (stack[i] == str)
            {
                tmp = 1;
                break;
            }
        }
        if (tmp == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    string IOperation.GetCurrentElt()
    {
        return stack[sp];
    }
    int IOperation.NumOfElements()
    {
        return sp + 1;
    }
}

class Queue : IOperation
{
    int Front = 0, Rear = -1;
    int Count = 0;
    private string[] queue;

    public Queue()
    {
        queue = new string[100];
    }

    public Queue(int size)
    {
        queue = new string[size];
    }

    void IOperation.Insert(string str)
    {
        if (Count <= queue.Length)
        {
            Rear = (Rear + 1) % queue.Length;
            queue[Rear] = str;
            Count++;
        }
    }

    string IOperation.Delete()
    {
        string result = "";
        if (Count > 0)
        {
            result = queue[Front];
            Front = (Front + 1) % queue.Length;
            Count--;
        }
        return result;
    }

    bool IOperation.Search(string str)
    {
        int tmp;
        int check = 0;
        bool result = false;

        if (Count > 0)
        {
            if (Front <= Rear)
            {
                for (tmp = Front; tmp <= Rear; tmp++)
                {
                    if (queue[tmp] == str)
                    {
                        result = true;
                        break;
                    }
                }
            }
            else if (Front > Rear)
            {
                for (tmp = 0; tmp <= Rear; tmp++)
                {
                    if (queue[tmp] == str)
                    {
                        result = true;
                        check++;
                        break;
                    }
                }
                if (check == 0)
                {
                    for (tmp = Front; tmp < queue.Length; tmp++)
                    {
                        if (queue[tmp] == str)
                        {
                            result = true;
                            break;
                        }
                    }
                }
            }
        }
        return result;
    }

    string IOperation.GetCurrentElt()
    {
        return queue[Front];
    }

    int IOperation.NumOfElements()
    {
        return Count;
    }

}

class IOperationApp
{
    public static void Main()
    {
        Stack stk = new Stack(10);
        Queue que = new Queue(10);

        ((IOperation)stk).Insert("�ȳ��ϼ���");
        ((IOperation)stk).Insert("���� �����Դϴ�");
        ((IOperation)stk).Insert("������α׷���");
        ((IOperation)stk).Insert("�� ������ �������� �����Դϴ�");

        Console.WriteLine("���� ���� ž�� �ִ� ���� : " + ((IOperation)stk).GetCurrentElt());
        Console.WriteLine("���ÿ� �����ϴ� ������ ���� : " + ((IOperation)stk).NumOfElements());
        Console.WriteLine("�� ������ �������� �����Դϴ� - �����Ѵ� �����ΰ�? : " + ((IOperation)stk).Search("�� ������ �������� �����Դϴ�"));

        ((IOperation)stk).Delete();
        Console.WriteLine("");

        Console.WriteLine("���� ���� ž�� �ִ� ���� : " + ((IOperation)stk).GetCurrentElt());
        Console.WriteLine("���ÿ� �����ϴ� ������ ���� : " + ((IOperation)stk).NumOfElements());
        Console.WriteLine("�� ������ �������� �����Դϴ� - �����Ѵ� �����ΰ�? : " + ((IOperation)stk).Search("�� ������ �������� �����Դϴ�"));
        //-----------------------------------------------------------------------//
        Console.WriteLine("");

        ((IOperation)que).Insert("�� ������ �������� �����Դϴ�");
        ((IOperation)que).Insert("�ȳ��ϼ���");
        ((IOperation)que).Insert("���� ����ť�Դϴ�");
        ((IOperation)que).Insert("������α׷���");

        Console.WriteLine("���� ť�� Front�� �ִ� ���� : " + ((IOperation)que).GetCurrentElt());
        Console.WriteLine("ť�� �����ϴ� ������ ���� : " + ((IOperation)que).NumOfElements());
        Console.WriteLine("�� ������ �������� �����Դϴ� - �����Ѵ� �����ΰ�? : " + ((IOperation)que).Search("�� ������ �������� �����Դϴ�"));

        ((IOperation)que).Delete();
        Console.WriteLine("");

        Console.WriteLine("���� ť�� Front�� �ִ� ���� : " + ((IOperation)que).GetCurrentElt());
        Console.WriteLine("ť�� �����ϴ� ������ ���� : " + ((IOperation)que).NumOfElements());
        Console.WriteLine("�� ������ �������� �����Դϴ� - �����Ѵ� �����ΰ�? : " + ((IOperation)que).Search("�� ������ �������� �����Դϴ�"));
    }
}