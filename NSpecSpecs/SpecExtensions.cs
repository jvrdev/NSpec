using System.Text.RegularExpressions;
using NSpec.Domain;

namespace NSpecSpecs
{
    public static class SpecExtensions
    {
        public static bool should_have_passed(this Example example)
        {
            return (example.HasRun && example.Exception == null);
        }

        public static bool should_have_failed(this Example example)
        {
            return !example.should_have_passed();
        }

        public static string RegexReplace(this string input, string pattern, string replace)
        {
            return Regex.Replace(input, pattern, replace);
        }
    }
}