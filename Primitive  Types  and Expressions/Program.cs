using System;

namespace PrimitiveTypesAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        private static void doApp()
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            double[] doubleArray = new double[] { 1.5, 2.7, 3.2, 4.8, 5.1 };
            char[] charArray = new char[] { 'a', 'b', 'c', 'd', 'e' };
            bool[] boolArray = new bool[] { true, false, true, true, false };

            int sum = intArray[0] + intArray[1];
            double product = doubleArray[2] * doubleArray[3];
            char firstChar = charArray[0];
            bool result = boolArray[1] || boolArray[2];

            Console.WriteLine("Sum of the first two integers: " + sum);
            Console.WriteLine("Product of the third and fourth doubles: " + product);
            Console.WriteLine("First character in the char array: " + firstChar);
            Console.WriteLine("Result of the OR operation: " + result);
        }
    }
}
