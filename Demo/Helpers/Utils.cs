using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Helpers
{
    public static class Utils
    {
        public static string DisplayName(string firstName, string lastName) => $"{firstName}, {lastName}";

        public static int MultiplyMe(int first, int second) => first * second;
    }
}
