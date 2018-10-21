using System;

namespace NumberLibrary
{
    public class Numbers
    {
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int sqrt = (int)Math.Sqrt(number);

            for (int i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public int Fibonacci(int number)
        {
            if (number <= 1) return 1;
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
