using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLibrary;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            OriginalRules originalRules = new OriginalRules();
            
            Engine engine = new Engine(originalRules);
            
            engine.PrintTo100();
        }
    }
}
