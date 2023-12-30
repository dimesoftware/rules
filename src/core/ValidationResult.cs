using System.Collections.Generic;

namespace Dime.Rules
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }

        public IEnumerable<string> Messages { get; set; }
    }
}