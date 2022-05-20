namespace Abstraction
{
    class Square : Shape
    {
        private double side;
        public Square(double s)
        {
            side = s;
        }

        public override double Area()
        {
            return side * side;
        }
    }
}
