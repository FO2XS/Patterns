using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Norbit.Crm.Kiselev.Patterns.Decorator.Tests
{
    /// <summary>
    /// Тесты базового декоратора класса авторизации.
    /// </summary>
    [TestClass()]
    public class AuthorizeDecoratorTests
    {
        /// <summary>
        /// Тесты на передачу null-аргумента в конструктор.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AuthorizeDecorator_NullArgument_ThrowsArgumentNullException()
        {
            var test = new AuthorizeDecorator(null);
        }
    }
}