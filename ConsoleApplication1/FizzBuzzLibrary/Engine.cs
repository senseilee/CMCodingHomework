using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    /// <summary>
    /// Engine provides divisible algorithm for determining if rules are met.
    /// </summary>
    public class Engine
    {
        // Rules to be iterated over for client-specified number
        private readonly IEnumerable<IProvideFizzBuzzRule> rules;

        /// <summary>
        /// Constructor that requires a list of rules to be used.
        /// </summary>
        /// <param name="customRules">List of custom rules that satisfy
        /// the IProvideFizzBuzzRule interface</param>
        public Engine(IEnumerable<IProvideFizzBuzzRule> customRules)
        {
            rules = customRules;
        }

        /// <summary>
        /// Debug method to quickly print results for numbers 1 through 100
        /// </summary>
        public void PrintTo100()
        {
            for (int i = 1; i <= 100; ++i)
            {
                Console.WriteLine(Calculate(i));
            }
        }

        /// <summary>
        /// Method to get string representing which rules were satisfied
        /// </summary>
        /// <param name="number">Number to test rules against</param>
        /// <returns>Returns string containing concatenated words depending
        /// if the rule was met.  If rule was not met, returns the number
        /// passed in.</returns> 
        public string Calculate(int number)
        {
            string matches = string.Empty;

            // iterate through rules
            foreach (var rule in rules)
            {
                // checks if number is divisible evenly by the
                // rule's MultipleOf property
                if (number % rule.MultipleOf == 0)
                {
                    // Evenly divisible, so concatenate WordMatch
                    matches += rule.WordMatch;
                }
            }

            if (matches == string.Empty)
            {
                // if matches is empty, then number was not divisible evenly.
                // Set it number.
                matches = number.ToString();
            }

            return matches;
        }

    }
}
