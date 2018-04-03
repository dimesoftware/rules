namespace Dime.Validation
{
    public interface IValidationEngine<T> where T : class
    {
        ValidationResult ExecuteRules(T item, BaseValidationRuleSet<T> rules);
    }
}