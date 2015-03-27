using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public class Engine
    {
        private readonly IEnumerable<IProvideFizzBuzzRule> rules;

        public Engine(IEnumerable<IProvideFizzBuzzRule> customRules)
        {
            rules = customRules;
        }

        public void PrintTo100()
        {
            for (int i = 1; i <= 100; ++i)
            {
                Console.WriteLine(Calculate(i));
            }
        }

        public string Calculate(int i)
        {
            string matches = string.Empty;

            foreach (var rule in rules)
            {
                if (i % rule.MultipleOf == 0)
                {
                    matches += rule.WordMatch;
                }
            }

            if (matches == string.Empty)
            {
                matches = i.ToString();
            }

            return matches;
        }

    }
}
