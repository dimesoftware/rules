using System.Collections.Generic;
using System.Linq;

namespace Dime.Validation
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValidationEngine<T> : IValidationEngine<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rules"></param>
        public ValidationEngine(params ValidationRule<T>[] rules)
        {
            _rules = rules.ToList();
        }

        private readonly IEnumerable<ValidationRule<T>> _rules;

        /// <summary>
        /// Executes the rules.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public virtual ValidationResult Validate(T item)
        {
            ValidationResult validationResult = new ValidationResult { IsValid = true };
            List<string> messages = new List<string>();
            foreach (ValidationRule<T> rule in _rules
                .Select(rule => new { rule, isValid = rule.ExecuteRule(item) })
                .Where(t => !t.isValid)
                .Select(t => t.rule))
            {
                validationResult.IsValid = false;
                validationResult.ResultType = ValidationResultType.ERROR;
                messages.Add(rule.Message);

                break;
            }

            validationResult.Messages = messages;
            return validationResult;
        }
    }
}