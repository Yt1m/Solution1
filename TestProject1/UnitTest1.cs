using NUnit.Framework;

namespace ProgramTests
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void TestRoundToNearestInteger_PositiveNumber()
        {
            double input = 5.6;

            int result = Program.RoundToNearestInteger(input);

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void TestRoundToNearestInteger_NegativeNumber()
        {
            double input = -2.3;

            int result = Program.RoundToNearestInteger(input);

            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void TestConvertToIntegerArray()
        {
            double[] inputArray = { 1.5, 2.3, -3.7, 4.1 };
            int[] expectedArray = { 2, 2, -4, 4 };

            int[] result = Program.ConvertToIntegerArray(inputArray);

            Assert.That(result, Is.EqualTo(expectedArray));
        }

        [Test]
        public void TestFindMaxAbsolute()
        {

            int[] inputArray = { 5, -8, 7, -3 };

            int expectedMaxAbs = -8; 

            int result = Program.FindMaxAbsolute(inputArray);

            Assert.That(result, Is.EqualTo(expectedMaxAbs));
        }
    }
}
