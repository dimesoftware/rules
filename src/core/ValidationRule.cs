using System;

namespace Dime.Validation
{
    public class ValidationRule<T> where T : class
    {
        #region Constructor

        public ValidationRule(Func<T, bool> rule)
        {
            RuleDelegate = rule;
        }

        #endregion Constructor

        #region Properties

        public string Message { get; set; }
        public string SuggestionString { get; set; }
        public ValidationResultType ResultTypeIfFailed { get; set; }
        internal Func<T, bool> RuleDelegate { get; set; }

        #endregion Properties

        #region Methods

        public bool ExecuteRule(T objectToValidate)
        {
            return this.RuleDelegate(objectToValidate);
        }

        #endregion Methods
    }
}