namespace Abstraction
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return 3.14 * radius * radius;
        }
    }
}
