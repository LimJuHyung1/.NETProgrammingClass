using System;
using System.Threading;

class Account                   //6.14-2
{
    private double balance;
    public Account(double initialDeposit)
    {
        balance = initialDeposit;
    }
    public double Balance
    {
        get { return balance; }
        // set {balance = value;}
    }
    public void Deposit(double amount)
    {
        lock (this)
        {
            balance += amount;
        }
    }
    public void Deposit2(double amount)
    {
        balance += amount;
    }
}

class Teller
{
    string name;
    Account account;
    double amount;
    public Teller(string name, Account account, double amount)
    {
        this.name = name;
        this.account = account;
        this.amount = amount;
    }
    public void TellerTask()
    {
        account.Deposit(amount);
        Console.WriteLine(name + " : " + account.Balance);
    }
}

class BankApp
{
    static public void Main()
    {
        Account ac = new Account(1000);

        Teller t1 = new Teller("1번째 텔러입니다", ac, 100);
        Teller t2 = new Teller("2번째 텔러입니다", ac, 300);
        Teller t3 = new Teller("3번째 텔러입니다", ac, 1000);

        ThreadStart t1s = new ThreadStart(t1.TellerTask);
        ThreadStart t2s = new ThreadStart(t2.TellerTask);
        ThreadStart t3s = new ThreadStart(t3.TellerTask);

        Thread teller1 = new Thread(t1s);
        Thread teller2 = new Thread(t2s);
        Thread teller3 = new Thread(t3s);


        teller1.Start();
        Thread.Sleep(1000);
        teller2.Start();
        Thread.Sleep(1000);
        teller3.Start();

    }
}
