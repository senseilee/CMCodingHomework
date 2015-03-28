using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    /// <summary>Interface that clients implement to define rules
    /// for the FizzBuzz engine.
    /// </summary> 
    public interface IProvideFizzBuzzRule
    {
        /// <summary>Provides the word to be returned when a number
        /// is a multiple of the MultipleOf property.
        /// </summary> 
        string WordMatch { get; }

        /// <summary>Defines value that if engine encounters a number
        /// that is divisible by MultipleOf, it is considered a match
        /// and the WordMatch is returned by the engine.
        /// </summary> 
        int MultipleOf { get; }
    }
}
