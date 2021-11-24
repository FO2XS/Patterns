using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Norbit.Crm.Kiselev.Patterns.Decorator.Tests
{
    /// <summary>
    /// Тесты пунктуационной обертки.
    /// </summary>
    [TestClass()]
    public class PunctuationCheckerTests
    {
        /// <summary>
        /// Тестирует корректность проверки паролей со знаками пунктуации.
        /// </summary>
        /// <param name="password">Пароль.</param>
        [TestMethod()]
        [DataRow(".")]
        [DataRow(",")]
        public void Verification_MultiplePunctiationPasswords_ReturnsTrue(string password)
        {
            string name = "test";
            var moq = Substitute.For<IAuthorization>();
            moq.Verification(name, password).Returns(true);
            var punctChecker = new PunctuationChecker(moq);

            Assert.IsTrue(punctChecker.Verification(name, password));
        }

        /// <summary>
        /// Тестирует корректность проверки паролей без знаков пунктуации.
        /// </summary>
        /// <param name="password">Пароль.</param>
        [TestMethod()]
        [DataRow("test")]
        public void Verification_NotPunctiationPassword_ReturnsFalse(string password)
        {
            string name = "test";
            var moq = Substitute.For<IAuthorization>();
            moq.Verification(name, password).Returns(true);
            var punctChecker = new PunctuationChecker(moq);

            Assert.IsFalse(punctChecker.Verification(name, password));
        }
    }
}