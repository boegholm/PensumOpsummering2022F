using Eksamen;

namespace MitProgram
{

    public class BuyTransaction : Transaction
    {
        User u;
        public override void Execute()
        {
            u.Balance -= 10;
        }
    }

    class C
    {
        public static void Bar()
        {
        }
        public int i;
        public static int k;
        public void Foo()
        {
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            C.Bar();
            C.k++;
            
            C c = new C();
            c.Foo();
        }
    }
}