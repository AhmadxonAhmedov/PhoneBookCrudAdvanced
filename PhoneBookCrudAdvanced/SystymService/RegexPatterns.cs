using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneBookCrudAdvanced.SystymService
{
    internal class RegexPatterns
    {
        public static bool PhoneNumberPattern(string input)
        {
            string pattern = @"^\(\d{3}\) \d{2}-\d{3}-\d{2}-\d{2}$";
            Match match = Regex.Match(input, pattern);
            bool isMatch = Regex.IsMatch(input, pattern);
            return isMatch; 
        }
    }
}
