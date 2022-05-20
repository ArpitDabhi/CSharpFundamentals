namespace Inheritance
{
    class Child1 : Parent
    {
        public int b;

        public Child1()
        {
            b = 20;
        }

        public int GetSum()
        {
            return a + b;
        }

    }
}
