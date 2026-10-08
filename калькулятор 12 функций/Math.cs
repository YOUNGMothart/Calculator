namespace Subjects
{
    public class Math
    {
        public double sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public double div(int num1, int num2)
        {
            if (num2 == 0) return 0;
            return (double)num1 / num2;
        }

        public double mult(int num1, int num2)
        {
            return num1 * num2;
        }

        public double subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public double root(double num1, double num2)
        {
            if (num1 < 0 && num2 % 2 == 0) return 0;
            if (num2 == 0) return 0;
            return System.Math.Pow(num1, 1.0 / num2);
        }

        public double square(double num1)
        {
            return num1 * num1;
        }

        public double cube(double num1)
        {
            return num1 * num1 * num1;
        }

        public double percent(double num1, double num2)
        {
            return (num1 / 100.0) * num2;
        }

        public double abs(double num1)
        {
            return num1 < 0 ? -num1 : num1;
        }

        public double factorial(int num1)
        {
            if (num1 < 0) return 0;
            if (num1 == 0 || num1 == 1) return 1;

            double result = 1;
            for (int i = 2; i <= num1; i++)
            {
                result *= i;
            }
            return result;
        }

        public double log(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0 || num2 == 1) return 0;
            return System.Math.Log(num1, num2);
        }

        public double average(double num1, double num2)
        {
            return (num1 + num2) / 2.0;
        }
    }
}