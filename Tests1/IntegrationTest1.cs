using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;

namespace ConsoleApp.Tests
{
    [TestFixture]  // Указание, что этот класс содержит тесты
    public class ProgramTests
    {
        [TestCase(3.7, 4)]  // Атрибут TestCase для параметризированных тестов
        [TestCase(-2.3, -2)]
        [TestCase(5.5, 6)]
        [TestCase(-5.5, -5)]
        public void TestRoundToNearestInteger(double input, int expected)
        {
            int result = Program.RoundToNearestInteger(input);  // Вызов тестируемого метода
            Assert.AreEqual(expected, result);  // Проверка, что результат совпадает с ожидаемым
        }

        [Test]
        public void TestConvertToIntegerArray()
        {
            double[] doubleArray = { 1.2, -2.8, 3.7, 4.1 };
            int[] expected = { 1, -3, 4, 4 };

            int[] result = Program.ConvertToIntegerArray(doubleArray);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestFindMaxAbsolute()
        {
            int[] intArray = { -3, 5, -2, 8, -10, 7 };
            int expected = -10;

            int result = Program.FindMaxAbsolute(intArray);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestFindMaxAbsolute_EmptyArray()
        {
            int[] intArray = { };
            Assert.Throws<ArgumentException>(() => Program.FindMaxAbsolute(intArray));  // Ожидаем исключение
        }
    }
}
