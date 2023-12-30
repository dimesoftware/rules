namespace Dime.Rules
{
    public interface IValidationEngine<in T> where T : class
    {
        ValidationResult Validate(T item);
    }
}