using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLibrary;

namespace Customer1Rules
{
    public class CustomRules : List<IProvideFizzBuzzRule>
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
        
        public CustomRules()
        {
            Add(new Rule("hello", 7));
            Add(new Rule("goodbye", 10));
        }
    }
}
