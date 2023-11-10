using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegEx_Morfolojik_Analiz_App
{
   
        public static class RegexHelper
        {
            public static List<string> FindRegexMatches(string input, string pattern)
            {
                List<string> matches = new List<string>();

                try
                {
                    MatchCollection matchCollection = Regex.Matches(input, pattern);

                    foreach (Match match in matchCollection)
                    {
                        matches.Add(match.Value);
                    }
                }
                catch (Exception ex)
                {
                // Regex eşleşmesi sırasında oluşabilecek istisnaları yakalama
               
                Console.WriteLine("An error occurred: " + ex.Message);
                }

                return matches;
            }
        }
    }


