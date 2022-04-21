namespace MitProgram
{ 
    interface ITransaction
    {
        
    }

    public abstract class Transaction
    {
        public int Id { get; set; }
        public abstract void Execute();
    }
}