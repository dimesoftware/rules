using System.Collections.Generic;

namespace Dime.Rules
{
    /// <summary>
    ///
    /// </summary>
    public class ValidationResult
    {
        /// <summary>
        /// Indicates the status of the validation run
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Informative messages about the result of the rule evaluation
        /// </summary>
        public IEnumerable<string> Messages { get; set; }
    }
}