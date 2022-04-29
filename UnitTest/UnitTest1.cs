using NUnit.Framework;
using RomanDecoder;

namespace UnitTest
{
    public class Tests
    {
        private Program _program;

        [SetUp]
        public void Setup()
        {
            _program = new Program();
        }

        [TestCase(1,"I")]
        [TestCase(49,"XLIX")]
        [TestCase(1666, "MDCLXVI")]
        [TestCase(1994, "MCMXCIV")]
        public void Test1(int expected,string romanNumeral)
        {
            Assert.AreEqual(expected, _program.RomanDecoder(romanNumeral));
        }
    }
}