using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Piranha.CookiePolicy.ExtensionsMethods
{
    public static class CamelToKebab
    {
        //https://stackoverflow.com/questions/37301287/how-do-i-convert-pascalcase-to-kebab-case-with-c
        public static string PascalToKebabCase(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            return Regex.Replace(value, "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])", "-$1", RegexOptions.Compiled)
                .Trim()
                .ToLower();
        }
    }
}
