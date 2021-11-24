using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NSubstitute;

namespace Norbit.Crm.Kiselev.Patterns.Observer.Tests
{
    /// <summary>
    /// Тесты класса-издателя.
    /// </summary>
    [TestClass()]
    public class BillyHerringtonTests
    {
        /// <summary>
        /// Тестирует null-аргумент при новой подписке.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Subscribe_NullArgument_ThrowsArgumentNullException()
        {
            var test = new BillyHerrington();

            test.Subscribe(null);
        }

        /// <summary>
        /// Тестирует новую подписку.
        /// </summary>
        [TestMethod()]
        public void Subscribe_NewSubscriber_ReturnsTrue()
        {
            var moq = Substitute.For<ISubscriber>();
            var test = new BillyHerrington();
            
            Assert.IsTrue(test.Subscribe(moq));
        }

        /// <summary>
        /// Тестирует процесс добавления нового подписчика, который уже есть в подписках.
        /// </summary>
        [TestMethod()]
        public void Subscribe_ContainsSubscriber_ReturnsFalse()
        {
            var moq = Substitute.For<ISubscriber>();
            var test = new BillyHerrington();
            test.Subscribe(moq);

            Assert.IsFalse(test.Subscribe(moq));
        }

        /// <summary>
        /// Тестирует отписку существующего подписчика.
        /// </summary>
        [TestMethod()]
        public void Unsubscribe_ExistSubscriber_ReturnsTrue()
        {
            var moq = Substitute.For<ISubscriber>();
            var test = new BillyHerrington();
            test.Subscribe(moq);

            Assert.IsTrue(test.Unsubscribe(moq));
        }

        /// <summary>
        /// Тестирует попытку отписки несуществующего подписчика.
        /// </summary>
        [TestMethod()]
        public void Unsubscribe_NotExistSubscriber_ReturnsFalse()
        {
            var moq = Substitute.For<ISubscriber>();
            var test = new BillyHerrington();

            Assert.IsFalse(test.Unsubscribe(moq));
        }
    }
}