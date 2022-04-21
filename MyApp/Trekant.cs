namespace Eksamen
{
    class Trekant : Figur
    {
        public Trekant(int h, int g, int x, int y) : base(x+10, y+10)
        {
            H = h;
            G = g;
        }

        public int H { get; }
        public int G { get; }

        public override void Draw()
        {
            
        }
    }

}
