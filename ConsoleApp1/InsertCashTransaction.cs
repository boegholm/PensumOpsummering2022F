using Eksamen;

namespace MitProgram
{
    public class InsertCashTransaction : Transaction
    {
        int amount;
        User u;
        public override void Execute()
        {
            u.Balance += amount;
        }
    }
}