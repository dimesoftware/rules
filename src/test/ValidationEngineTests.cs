using System.Linq;
using Dime.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.Rules.Tests
{
    [TestClass]
    public class ValidationEngineTests
    {
        [TestMethod]
        public void ValidationEngine_Validate_Null_ShouldFail()
        {
            ValidationRule<Customer> rule1 = new ValidationRule<Customer>(x => x != null, "Item cannot be null");
            ValidationRule<Customer> rule2 = new ValidationRule<Customer>(x => x.IsActive, "IsActive needs to be true");

            ValidationEngine<Customer> engine = new ValidationEngine<Customer>(rule1, rule2);
            ValidationResult runResult = engine.Validate(null);

            Assert.IsTrue(!runResult.IsValid);
            Assert.IsTrue(runResult.Messages.Count() == 1);
            Assert.IsTrue(runResult.Messages.ElementAt(0) == "Item cannot be null");
        }

        [TestMethod]
        public void ValidationEngine_Validate_Inactive_ShouldFail()
        {
            ValidationRule<Customer> rule1 = new ValidationRule<Customer>(x => x != null, "Item cannot be null");
            ValidationRule<Customer> rule2 = new ValidationRule<Customer>(x => x.IsActive, "IsActive needs to be true");

            ValidationEngine<Customer> engine = new ValidationEngine<Customer>(rule1, rule2);
            ValidationResult runResult = engine.Validate(new Customer());

            Assert.IsTrue(!runResult.IsValid);
            Assert.IsTrue(runResult.Messages.Count() == 1);
            Assert.IsTrue(runResult.Messages.ElementAt(0) == "IsActive needs to be true");
        }

        [TestMethod]
        public void ValidationEngine_ValidData_ShouldPass()
        {
            ValidationRule<Customer> rule1 = new ValidationRule<Customer>(x => x != null, "Item cannot be null");
            ValidationRule<Customer> rule2 = new ValidationRule<Customer>(x => x.IsActive, "IsActive needs to be true");

            ValidationEngine<Customer> engine = new ValidationEngine<Customer>(rule1, rule2);
            ValidationResult runResult = engine.Validate(new Customer { IsActive = true });

            Assert.IsTrue(runResult.IsValid);
            Assert.IsTrue(!runResult.Messages.Any());
        }
    }
}