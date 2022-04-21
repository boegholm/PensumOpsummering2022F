namespace Eksamen
{
    class Firkant : Figur
    {
        public int H { get; set; }
        public int W { get; set; }
        public override void Draw()
        {
            for(int x = X; x < W+X; x++)
                for(int y = Y; y < Y+H; y++)
                    DrawPixel(x, y);
        }
        public Firkant(int x, int y, int h, int w) : base(x, y)
        {
            H = h;
            W = w;
        }

        public double Angle { get; private set; }

        public void RotateRad(double dAngle) {
            Angle += dAngle;
        }
        public void RotateDeg(double dAngle)
        {
            Angle += dAngle / (2.0 * Math.PI);
        }
    }

}
