using System;

namespace Dime.Rules
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValidationRule<T> where T : class
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="rule"></param>
        /// <param name="message"></param>
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