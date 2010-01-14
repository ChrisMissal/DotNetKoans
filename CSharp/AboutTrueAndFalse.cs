using System.Collections;
using Xunit;
 
namespace DotNetKoans.CSharp
{
    public class AboutTrueAndFalse : Koan
    {
        public object TruthValue(object condition)
        {
            if (condition is bool)
            {
                // if the condition can be converted to a bool, return its true/false value.
                return (bool) condition;
            }

            return null; // otherwise, return null (we don't know if it's true or false)
        }

        [Koan(1)]
        public void TrueIsTreatedAsTrue()
        {
            Assert.Equal(FILL_ME_IN, TruthValue(true));
        }

        [Koan(2)]
        public void FalseIsTreatedAsFalse()
        {
            Assert.Equal(FILL_ME_IN, TruthValue(false));
        }

        [Koan(3)]
        public void NullIsTreatedAsNull()
        {
            Assert.Equal(FILL_ME_IN, TruthValue(null));
        }

        [Koan(4)]
        public void EverythingElseIsTreatedAsNull()
        {
            Assert.Equal(FILL_ME_IN, TruthValue(1));
            Assert.Equal(FILL_ME_IN, TruthValue(0));
            Assert.Equal(FILL_ME_IN, TruthValue(new object[]{}));
            Assert.Equal(FILL_ME_IN, TruthValue(new Hashtable()));
            Assert.Equal(FILL_ME_IN, TruthValue("Strings"));
            Assert.Equal(FILL_ME_IN, TruthValue(""));
        }
    }
}