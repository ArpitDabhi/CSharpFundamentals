namespace Abstraction
{
    class Triangle : Shape
    {
        private double tbase;
        private double theight;

        public Triangle(double b, double h)
        {
            tbase = b;
            theight = h;
        }

        public override double Area()
        {
            return 0.5 * tbase * theight;
        }
    }
}
