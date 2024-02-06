using System;

namespace Lab2_5
{
    public class MathOperations
    {
        public static double CalculatePower(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }

        public static double CalculatePower(double baseNumber, double exponent1, double exponent2)
        {
            return Math.Pow(Math.Pow(baseNumber, exponent1), exponent2);
        }
    }
}
