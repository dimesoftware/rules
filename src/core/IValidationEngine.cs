namespace Dime.Rules
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IValidationEngine<in T> where T : class
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        ValidationResult Validate(T item);
    }
}