using System;
using System.Text.RegularExpressions;

namespace MaikHo.Extensions.Validation
{
    public static class ValidationExtensions
    {
        // Extension Method: Überprüfen, ob eine Zeichenfolge eine gültige E-Mail-Adresse ist
        public static bool IsValidEmail(this string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Extension Method: Überprüfen, ob eine Zeichenfolge ein gültiges Passwort ist (mindestens 8 Zeichen lang, mindestens ein Großbuchstabe, mindestens eine Zahl und mindestens ein Sonderzeichen)
        public static bool IsValidPassword(this string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            return password.Length >= 8 &&
                   hasNumber.IsMatch(password) &&
                   hasUpperChar.IsMatch(password) &&
                   hasLowerChar.IsMatch(password) &&
                   hasSymbols.IsMatch(password);
        }

        // Extension Method: Überprüfen, ob eine Zahl innerhalb eines bestimmten Bereichs liegt
        public static bool IsInRange(this int number, int min, int max)
        {
            return number >= min && number <= max;
        }

        
    }
}
