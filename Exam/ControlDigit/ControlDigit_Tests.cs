using NUnit.Framework;

namespace Exam.ControlDigit
{
    [TestFixture]
    public class ControlDigitTests
    {
        [TestCase(00000000000, 0)]
        [TestCase(00000000001, 7)]
        [TestCase(00000000002, 4)]
        [TestCase(00000000009, 3)]
        [TestCase(00000000010, 9)]
        [TestCase(00000000013, 0)]
        [TestCase(00000000015, 4)]
        [TestCase(00000000017, 8)]
        [TestCase(00000000018, 5)]
        [TestCase(11111111111, 7)]
        [TestCase(12345678901, 2)]
        [TestCase(98765432101, 2)]
        [TestCase(11223344556, 2)]
        [TestCase(32512312431, 1)]
        [TestCase(98439874398, 8)]
        [TestCase(98439876398, 6)]
        public void Upc(long number, int expected)
        {
            var actual = number.CalculateUpc();

            Assert.AreEqual(expected, actual);
        }
    }
}