using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLibrary;

namespace ConsoleApplication1
{
    public class OriginalRules : List<IProvideFizzBuzzRule>
    {
        private class Rule : IProvideFizzBuzzRule
        {
            public string WordMatch { get; private set; }
            public int MultipleOf { get; private set; }

            public Rule(string wordMatch, int multipleOf)
            {
                WordMatch = wordMatch;
                MultipleOf = multipleOf;
            }
        }

        public OriginalRules()
        {
            Add(new Rule("fizz", 3));
            Add(new Rule("buzz", 5));
        }
    }
}
