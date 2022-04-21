using Eksamen;

namespace MitProgram
{
    class SS
    {
        List<Transaction> TransactionList = new List<Transaction> ();
        void Run()
        {
            User u1 = new User();
            User u2 = new User();
            TransferCashTransaction t = new TransferCashTransaction(u1, u2, 100);
            BuyTransaction bt = new BuyTransaction();
            RunTransaction(bt);
            RunTransaction(t);
        }
        void RunTransaction(Transaction t)
        {
            t.Execute();
            TransactionList.Add(t);

            Console.WriteLine($"{DateTime.Now}:: Udførte transaktion");
        }

    }
}