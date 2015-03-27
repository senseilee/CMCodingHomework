using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public interface IProvideFizzBuzzRule
    {
        string WordMatch { get; }
        int MultipleOf { get; }
    }
}
