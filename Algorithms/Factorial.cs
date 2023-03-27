namespace Algorithms
{
    public static class Factorial
    {
        public static int Calculate(int x)
        {
            if(x == 1)
            {
                return 1;
            }
            else
            {
                return x * Calculate(x - 1);
            }
        }
    }
}
