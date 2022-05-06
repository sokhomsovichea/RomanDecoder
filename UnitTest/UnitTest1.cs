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

        [TestCase(1, "I")]
        [TestCase(49, "XLIX")]
        [TestCase(1666, "MDCLXVI")]
        [TestCase(1994, "MCMXCIV")]
        [TestCase(3724, "MMMDCCXXIV")]
        [TestCase(2048, "MMXLVIII")]
        [TestCase(5555, "MMMMMDLV")]
        [TestCase(3999, "MMMCMXCIX")]
        public void Test1(int expected, string romanNumeral)
        {
            Assert.AreEqual(expected, _program.RomanDecoder(romanNumeral));
        }
    }
}