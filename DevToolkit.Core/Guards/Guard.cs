using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DevToolkit.Core.Guards
{
    public static class Guard
    {
        public static bool HasValue(string value)
            => !string.IsNullOrWhiteSpace(value);

        public static bool HasItems<T>(IEnumerable<T> items)
            => items != null && items.Any();

        public static bool IsPositive(int value)
            => value > 0;

        public static bool Range(int value, int min, int max)
            => value >= min && value <= max;

        public static bool Range(DateTime value, DateTime min, DateTime max)
            => value >= min && value <= max;

        public static bool CorrectLength(string value, int minLength, int maxLength)
            => HasValue(value) && value.Length >= minLength && value.Length <= maxLength;

        public static bool MatchesPattern(string value, string pattern)
            => HasValue(value) && Regex.IsMatch(value, pattern);

        public static bool IsOfType<T>(object value)
            => value is T;

        public static void AgainstNull(object value, string paramName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void AgainstNullOrWhiteSpace(
            string value,
            string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    $"{paramName} cannot be empty.");
            }
        }
    }
}
