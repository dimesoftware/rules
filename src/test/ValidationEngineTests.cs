using System.Linq;
using Dime.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.RuleEngine.Tests
{
    [TestClass]
    public class ValidationEngineTests
    {
        [TestMethod]
        public void TestValidationEngine()
        {
            var rule1 = new ValidationRule<MyClass>(x => x != null, "Item cannot be null");
            var rule2 = new ValidationRule<MyClass>(x => x.MyBoolean == true, "MyBoolean needs to be true");

            ValidationEngine<MyClass> engine = new ValidationEngine<MyClass>(rule1, rule2);
            var run1Result = engine.Validate(null);
            var run2Result = engine.Validate(new MyClass());
            var run3Result = engine.Validate(new MyClass {MyBoolean = true});

            Assert.IsTrue(!run1Result.IsValid);
            Assert.IsTrue(run1Result.Messages.Count() == 1);
            Assert.IsTrue(run1Result.Messages.ElementAt(0) == "Item cannot be null");

            Assert.IsTrue(!run2Result.IsValid);
            Assert.IsTrue(run2Result.Messages.Count() == 1);
            Assert.IsTrue(run2Result.Messages.ElementAt(0) == "MyBoolean needs to be true");

            Assert.IsTrue(run3Result.IsValid);
            Assert.IsTrue(!run3Result.Messages.Any());
        }
    }
}