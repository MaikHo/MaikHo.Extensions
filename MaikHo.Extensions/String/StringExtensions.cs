using System;
using System.Linq;

namespace MaikHo.Extensions.String
{
    public static class StringExtensions
    {
        // Beispiel Extension Method: Umdrehen eines Strings
        public static string Reverse(this string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        // Beispiel Extension Method: Überprüfen, ob ein String Palindrom ist
        public static bool IsPalindrome(this string input)
        {
            string cleanedInput = input.ToLower().Replace(" ", "");
            return cleanedInput == cleanedInput.Reverse();
        }

        // Beispiel Extension Method: Zählen der Vorkommen eines Zeichens in einem String
        public static int CountOccurrences(this string input, char character)
        {
            return input.Count(c => c == character);
        }

        // Extension Method: Entfernen aller Leerzeichen aus einer Zeichenfolge
        public static string RemoveWhitespace(this string str)
        {
            return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
        }

        // Extension Method: Ersetzen einer Teilzeichenfolge in einer Zeichenfolge durch eine andere Teilzeichenfolge
        public static string Replace(this string str, string oldValue, string newValue)
        {
            return str.Replace(oldValue, newValue);
        }
    }
}