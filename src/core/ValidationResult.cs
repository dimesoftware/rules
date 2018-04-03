using System.Collections.Generic;

namespace Dime.Validation
{
    public class ValidationResult
    {
        /// <summary>
        /// Doesn't seem to hard to get right?
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Informative messages about the result of the rule evaluation
        /// </summary>
        public IEnumerable<string> Messages { get; set; }

        /// <summary>
        ///
        /// </summary>
        public ValidationResultType ResultType { get; set; }
    }
}