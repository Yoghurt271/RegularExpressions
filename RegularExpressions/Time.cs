using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Time
    {
        public void time()
        {
            string a = "что то 09:00, потом 05:55 далее 06:65 а так же 19:25";
            Regex regex = new Regex(@"\b(?:[01][0-9]|2[0-3]):[0-5][0-9]\b");
            MatchCollection matches = regex.Matches(a);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
        }
    }
}
