using System;

namespace MaikHo.Extensions.Int
{
    public static class IntExtensions
    {
        // Beispiel Extension Method: Überprüfen, ob eine Zahl gerade ist
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        // Beispiel Extension Method: Überprüfen, ob eine Zahl ungerade ist
        public static bool IsOdd(this int number)
        {
            return !number.IsEven();
        }

        // Beispiel Extension Method: Berechnen der Quadratzahl einer Zahl
        public static int Square(this int number)
        {
            return number * number;
        }

        // Beispiel Extension Method: Überprüfen, ob eine Zahl positiv ist
        public static bool IsPositive(this int number)
        {
            return number > 0;
        }

        // Beispiel Extension Method: Überprüfen, ob eine Zahl negativ ist
        public static bool IsNegative(this int number)
        {
            return number < 0;
        }

        // Beispiel Extension Method: Berechnen der Fakultät einer Zahl
        public static int Factorial(this int number)
        {
            if (number == 0)
                return 1;
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        // Beispiel Extension Method: Überprüfen, ob eine Zahl eine Primzahl ist
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
