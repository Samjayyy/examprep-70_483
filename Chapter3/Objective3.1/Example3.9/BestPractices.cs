using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Example3._9
{
    class BestPractices
    {
        public static void ExampleBacktracking()
        {
            Stopwatch sw;
            string[] addresses = { "sam.segers.is.giving.a.valid.email@capgemini.com",
                             "sam.should.not.do.this.at.the.bootcamp!@capgemini.com" };
            // The following regular expression should not actually be used to validate an email address.
            string pattern = @"^[0-9A-Z]([-.\w]*[0-9A-Z])*$";
            string input;

            foreach (var address in addresses)
            {
                string mailBox = address.Substring(0, address.IndexOf("@"));
                int index = 0;
                for (int ctr = mailBox.Length - 1; ctr >= 0; ctr--)
                {
                    index++;

                    input = mailBox.Substring(ctr, index);
                    sw = Stopwatch.StartNew();
                    Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                    sw.Stop();
                    if (m.Success)
                        Console.WriteLine("{0,2}. Matched '{1,25}' in {2}", index, m.Value, sw.Elapsed);
                    else
                        Console.WriteLine("{0,2}. Failed  '{1,25}' in {2}", index, input, sw.Elapsed);
                }
                Console.WriteLine();
            }

        }

        // BAD
        public static bool IsValidCurrencyBad(string currencyValue)
        {
            string pattern = @"\p{Sc}+\s*\d+";
            Regex currencyRegex = new Regex(pattern);
            return currencyRegex.IsMatch(currencyValue);
        }

        // GOOD
        public static bool IsValidCurrencyGood(string currencyValue)
        {
            string pattern = @"\p{Sc}+\s*\d+";
            return Regex.IsMatch(currencyValue, pattern);
        }

        // Set cache size if regexes are extensively used, and performance is depending on it
        public static void SetCacheSize(int size)
        {
            Regex.CacheSize = size;
        }

        public static void CompileVsInterpreted()
        {
            string pattern = @"\b(\w+((\r?\n)|,?\s))*\w+[.?:;!]";
            Stopwatch sw;
            Match match;
            int ctr;

            StreamReader inFile = new StreamReader(@".\textfile.txt");
            string input = inFile.ReadToEnd();
            inFile.Close();

            // Read first ten sentences with interpreted regex.
            Console.WriteLine("10 Sentences with Interpreted Regex:");
            sw = Stopwatch.StartNew();
            Regex int10 = new Regex(pattern, RegexOptions.Singleline);
            match = int10.Match(input);
            for (ctr = 0; ctr <= 9; ctr++)
            {
                if (match.Success)
                    // Do nothing with the match except get the next match.
                    match = match.NextMatch();
                else
                    break;
            }
            sw.Stop();
            Console.WriteLine("   {0} matches in {1}", ctr, sw.Elapsed);

            // Read first ten sentences with compiled regex.
            Console.WriteLine("10 Sentences with Compiled Regex:");
            sw = Stopwatch.StartNew();
            Regex comp10 = new Regex(pattern,
                         RegexOptions.Singleline | RegexOptions.Compiled);
            match = comp10.Match(input);
            for (ctr = 0; ctr <= 9; ctr++)
            {
                if (match.Success)
                    // Do nothing with the match except get the next match.
                    match = match.NextMatch();
                else
                    break;
            }
            sw.Stop();
            Console.WriteLine("   {0} matches in {1}", ctr, sw.Elapsed);

            // Read all sentences with interpreted regex.
            Console.WriteLine("All Sentences with Interpreted Regex:");
            sw = Stopwatch.StartNew();
            Regex intAll = new Regex(pattern, RegexOptions.Singleline);
            match = intAll.Match(input);
            int matches = 0;
            while (match.Success)
            {
                matches++;
                // Do nothing with the match except get the next match.
                match = match.NextMatch();
            }
            sw.Stop();
            Console.WriteLine("   {0:N0} matches in {1}", matches, sw.Elapsed);

            // Read all sentnces with compiled regex.
            Console.WriteLine("All Sentences with Compiled Regex:");
            sw = Stopwatch.StartNew();
            Regex compAll = new Regex(pattern,
                            RegexOptions.Singleline | RegexOptions.Compiled);
            match = compAll.Match(input);
            matches = 0;
            while (match.Success)
            {
                matches++;
                // Do nothing with the match except get the next match.
                match = match.NextMatch();
            }
            sw.Stop();
            Console.WriteLine("   {0:N0} matches in {1}", matches, sw.Elapsed);
        }
    }
}
