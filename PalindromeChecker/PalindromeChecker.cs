using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string input)
        {
            // Перевірка, чи є вхідний рядок порожнім або містить лише пробіли
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("An empty value or only spaces are entered.");

            // Приведення слова до нижнього регістру і видалення розділових символів
            string cleanedInput = new string(input.ToLower().Where(char.IsLetterOrDigit).ToArray());

            // Перевірка на паліндромність
            return cleanedInput.SequenceEqual(cleanedInput.Reverse());
        }
    }
}
