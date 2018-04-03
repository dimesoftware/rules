using System.Collections.Generic;

namespace Dime.Validation
{
    public abstract class ValidationEngine<T> : IValidationEngine<T> where T : class
    {
        /// <summary>
        /// Executes the rules.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="rules">The rules.</param>
        /// <returns></returns>
        public virtual ValidationResult ExecuteRules(T item, BaseValidationRuleSet<T> rules)
        {
            ValidationResult validationResult = new ValidationResult() { IsValid = true };
            List<string> messages = new List<string>();
            foreach (ValidationRule<T> rule in rules.RuleList)
            {
                bool isValid = rule.ExecuteRule(item);
                if (!isValid)
                {
                    validationResult.IsValid = false;
                    validationResult.ResultType = ValidationResultType.ERROR;
                    messages.Add(rule.Message);

                    break;
                }
            }

            validationResult.Messages = messages;
            return validationResult;
        }
    }
}