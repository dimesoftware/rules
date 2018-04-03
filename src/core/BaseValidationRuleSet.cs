using System.Collections.Generic;

namespace Dime.Validation
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseValidationRuleSet<T> where T : class
    {
        #region Constructor

        /// <summary>
        /// Initiates rule list
        /// </summary>
        public BaseValidationRuleSet()
        {
            this.RuleList = new List<ValidationRule<T>>();
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        ///
        /// </summary>
        public List<ValidationRule<T>> RuleList { get; internal set; }

        #endregion Properties
    }
}