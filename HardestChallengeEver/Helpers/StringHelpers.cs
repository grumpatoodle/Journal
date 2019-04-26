using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HardestChallengeEver.Helpers
{
    public static class StringHelpers
    {
        // someString = "FooBarFoooo" result in "Foo Bar Foooo"
        // Pure Function => Helper Functions

        public static string ConvertToCamelCase(this string someString)
        {
            var stringToReturn = Regex.Replace(someString, "(\\B[A-Z])", " $1");
            return stringToReturn;
        }
    }
}
