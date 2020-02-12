using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace CodeFirst.Custom
{
    public static class SnakeCaseConverter
    {
        
        

            public static string ToSnakeCase(this string input)
            {
                if (string.IsNullOrEmpty(input)) { return input; }

                var noLeadingUndescore = Regex.Replace(input, @"^_", "");
                return Regex.Replace(noLeadingUndescore, @"([a-z0-9])([A-Z])", "$1_$2").ToLower();
            }
        
    }
}