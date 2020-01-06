using System;

namespace Dime.Validation
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValidationRule<T> where T : class
    {
        #region Constructor

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

        #endregion Constructor

        #region Properties

        public string Message { get; set; }
        internal Func<T, bool> Rule { get; set; }

        #endregion Properties

        #region Methods

        public bool ExecuteRule(T objectToValidate) => Rule(objectToValidate);

        #endregion Methods
    }
}