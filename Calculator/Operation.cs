using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Holds information about a single operation from the calculator
    /// </summary>
    class Operation
    {
        #region Public Properties
        /// <summary>
        /// The left side of the operation
        /// </summary>
        public string leftSide { get; set; }

        /// <summary>
        /// The right side of the operation
        /// </summary>
        public string rightSide { get; set; }

        /// <summary>
        /// The type of operation to perform
        /// </summary>
        public OperationType Operationtype { get; set; }

        /// <summary>
        /// The inner operation to be performed prior to this operation
        /// </summary>
        public Operation InnerOperation { get; set; }
        #endregion

        #region Constructor
        public Operation()
        {
            this.leftSide = string.Empty;
            this.rightSide = string.Empty;
        }
        #endregion
    }
}
