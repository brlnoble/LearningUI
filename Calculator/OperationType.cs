using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// A type of operation the calculator can perform
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Adds two values together
        /// </summary>
        Add,

        /// <summary>
        /// Subtracts two values
        /// </summary>
        Minus,

        /// <summary>
        /// Divides two values
        /// </summary>
        Divide,

        /// <summary>
        /// Multiplies two values
        /// </summary>
        Multiply
    }
}
