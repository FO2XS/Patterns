using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Norbit.Crm.Kiselev.Patterns.AbstractFactory.Tests
{
    /// <summary>
    /// Тесты интерфейса фабрики бирж.
    /// </summary>
    [TestClass()]
    public class IStockMarketFactoryTests
    {
        /// <summary>
        /// Проверяет возвращаемый тип метода IBond.
        /// </summary>
        [TestMethod()]
        public void CreateBond_CreateDefault_ReturnIBond()
        {
            var moq = Substitute.For<IStockMarketFactory>();

            Assert.IsInstanceOfType(moq.CreateBond(), typeof(IBond));
        }

        /// <summary>
        /// Проверяет возвращаемый тип метода IStock.
        /// </summary>
        [TestMethod()]
        public void CreateStock_CreateDefault_ReturnIStock()
        {
            var moq = Substitute.For<IStockMarketFactory>();

            Assert.IsInstanceOfType(moq.CreateStock(), typeof(IStock));
        }
    }
}
