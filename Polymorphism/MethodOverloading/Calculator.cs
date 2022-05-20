namespace Polymorphism.MethodOverloading
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
       
        public static float Add(float a, float b)
        {
            return a + b;
        }
    }
}
