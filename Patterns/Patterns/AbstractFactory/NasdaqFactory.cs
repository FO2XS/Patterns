namespace Norbit.Crm.Kiselev.Patterns.AbstractFactory
{
    /// <summary>
    /// Фабрика ценных бумаг.
    /// Биржа NASDAQ.
    /// </summary>
    public class NasdaqFactory : IStockMarketFactory
    {
        /// <summary>
        /// Создает долларовую облигацию.
        /// </summary>
        /// <returns></returns>
        public IBond CreateBond()
        {
            return new DollarBond();
        }

        /// <summary>
        /// Создает акцию компании "Tesla".
        /// </summary>
        /// <returns></returns>
        public IStock CreateStock()
        {
            return new TeslaStock();
        }
    }
}
