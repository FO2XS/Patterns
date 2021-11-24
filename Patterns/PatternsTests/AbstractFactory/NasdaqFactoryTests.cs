using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Norbit.Crm.Kiselev.Patterns.AbstractFactory.Tests
{
    /// <summary>
    /// Тесты класса биржы Nasdaq.
    /// </summary>
    [TestClass()]
    public class NasdaqFactoryTests
    {
        /// <summary>
        /// Проверяет возвращаемый тип значения (IBond).
        /// </summary>
        [TestMethod()]
        public void CreateBond_GetBond_ReturnIBond()
        {
            var nasdaq = new NasdaqFactory();

            Assert.IsInstanceOfType(nasdaq.CreateBond(), typeof(IBond));
        }

        /// <summary>
        /// Проверка на null-возвращаемый результат.
        /// </summary>
        [TestMethod()]
        public void CreateBond_GetBond_NotNull()
        {
            var nasdaq = new NasdaqFactory();

            Assert.IsNotNull(nasdaq.CreateBond());
        }
    }
}