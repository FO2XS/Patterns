using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Norbit.Crm.Kiselev.Patterns.Singleton.Tests
{
    [TestClass()]
    public class DapperProviderTests
    {
        /// <summary>
        /// Проверяет, возвращает ли класс единственный экземпляр.
        /// </summary>
        [TestMethod()]
        [DataRow("test", "test2")]
        public void GetInstance_CheckOnlyOne_ReturnsSameInstance(string firstConnectionString, string secondConnectionString)
        {
            var instanceOne = DapperProvider.GetInstance(firstConnectionString);
            var instanceTwo = DapperProvider.GetInstance(secondConnectionString);

            Assert.AreEqual(instanceOne.ConnectionString, instanceTwo.ConnectionString);
        }

        /// <summary>
        /// Проверка невалидных значений.
        /// </summary>
        [TestMethod()]
        [DataRow("")]
        [DataRow(null)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetInstance_NullOrEmpty_ThrowsArgumentNullException(string firstConnectionString)
        {
            var instanceOne = DapperProvider.GetInstance(firstConnectionString);
        }

        /// <summary>
        /// Проверка невалидных значений.
        /// </summary>
        [TestMethod()]
        [DataRow("")]
        [DataRow(null)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetSecurity_NullOrEmpty_ThrowsArgumentNullException(string figi)
        {
            var provider = DapperProvider.GetInstance("test");

            var test = provider.GetSecurity(figi);
        }
    }
}