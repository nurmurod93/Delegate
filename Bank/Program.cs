using Bank;

class Program
{
    static void Main()
    {
        PulBoshqaruvchi pulBoshqaruvchi = new PulBoshqaruvchi(1000, "USD");

        MoneyOperationDelegate depositDelegate = new MoneyOperationDelegate(pulBoshqaruvchi.Deposit);
        MoneyOperationDelegate withdrawDelegate = new MoneyOperationDelegate(pulBoshqaruvchi.Withdraw);


        depositDelegate(new Pul(500, "USD"));
        withdrawDelegate(new Pul(200, "USD"));
        withdrawDelegate(new Pul(1000, "USD"));

        Console.ReadLine();
    }
}