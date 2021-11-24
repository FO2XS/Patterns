using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;

namespace Norbit.Crm.Kiselev.Patterns.Decorator.Tests
{
    /// <summary>
    /// Тесты обертки с проверкой длины пароля.
    /// </summary>
    [TestClass()]
    public class LengthCheckerTests
    {
        /// <summary>
        /// Тестирует иницализацию объекта с отрицательным значением длины пароля.
        /// </summary>
        /// <param name="length">Длина пароля.</param>
        [TestMethod()]
        [DataRow(0)]
        [DataRow(-1)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LengthChecker_ZeroOrLessLength_ThrowsArgumentOutOfRangeException(int length)
        {
            var moq = Substitute.For<IAuthorization>();
            var lengthChecker = new LengthChecker(moq, length);
        }

        /// <summary>
        /// Тестирует корректность проверки длины пароля на подходящих паролях.
        /// </summary>
        /// <param name="password">Пароль.</param>
        /// <param name="length">Необходимая длина.</param>
        [TestMethod()]
        [DataRow("123456", 6)]
        public void Verification_RequiredLengthPassword_ReturnsTrue(string password, int length)
        {
            string name = "test";
            var moq = Substitute.For<IAuthorization>();
            moq.Verification(name, password).Returns(true);
            var lengthChecker = new LengthChecker(moq, length);

            Assert.IsTrue(lengthChecker.Verification(name, password));
        }

        /// <summary>
        /// Тестирует корректность проверки длины пароля на неподходящих паролях.
        /// </summary>
        /// <param name="password">Пароль.</param>
        /// <param name="length">Необходимая длина.</param>
        [TestMethod()]
        [DataRow("12345", 6)]
        public void Verification_LessRequiredLengthPassword_ReturnsFalse(string password, int length)
        {
            string name = "test";
            var moq = Substitute.For<IAuthorization>();
            moq.Verification(name, password).Returns(true);
            var lengthChecker = new LengthChecker(moq, length);

            Assert.IsFalse(lengthChecker.Verification(name, password));
        }
    }
}