using System;

namespace Dime.Rules
{
    public class ValidationRule<T> where T : class
    {
        public ValidationRule(Func<T, bool> rule, string message)
        {
            Rule = rule;
            Message = message;
        }

        public string Message { get; set; }
        internal Func<T, bool> Rule { get; set; }

        public bool ExecuteRule(T objectToValidate) => Rule(objectToValidate);
    }
}