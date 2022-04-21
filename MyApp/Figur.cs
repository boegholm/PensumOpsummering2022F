namespace Eksamen
{
    abstract class Figur
    {
        protected void DrawPixel(int x, int y)
        {
            
        }

        public abstract void Draw();
        public Figur(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }

}
