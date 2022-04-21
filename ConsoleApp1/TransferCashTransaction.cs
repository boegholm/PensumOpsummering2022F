using Eksamen;

namespace MitProgram
{
    public class TransferCashTransaction  : Transaction
    {

        public TransferCashTransaction(User a, User receiver, int amount)
        {
            A = a;
            Receiver = receiver;
            Amount = amount;
        }

        public User A { get; }
        public User Receiver { get; }
        public int Amount { get; }

        public override void Execute()
        {
            A.Balance-=Amount;
            Receiver.Balance+=Amount;
        }
    }
}