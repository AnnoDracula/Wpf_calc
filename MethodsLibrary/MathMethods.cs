using System;

namespace MethodsLibrary
{
    public static class MathMethods
    {
        private static double Summ(double a, double b)
        {
            return (a + b);
        }

        private static double Diff(double a, double b)
        {
            return (a - b);
        }

        private static double Multiplication(double a, double b)
        {
            return (a * b);
        }

        private static double Division(double a, double b)
        {
            return (a * 1.0 / b);
        }

        public static double Calculate(double a, double b, string sign)
        {
            double result;
            switch (sign)
            {
                case "+":
                    result = Summ(a, b);
                    break;
                case "-":
                    result = Diff(a, b);
                    break;
                case "x":
                    result = Multiplication(a, b);
                    break;
                case "/":
                    result = Division(a, b);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return result;
        }
    }
}
