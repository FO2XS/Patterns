namespace Norbit.Crm.Kiselev.Patterns.AbstractFactory
{
    /// <summary>
    /// Фабрика ценных бумаг.
    /// Московская биржа.
    /// </summary>
    internal class MoscowExchangeFactory : IStockMarketFactory
    {
        /// <summary>
        /// Создает рублевую облигацию.
        /// </summary>
        /// <returns></returns>
        public IBond CreateBond()
        {
            return new RubBond();
        }

        /// <summary>
        /// Создает акцию компании "Газпром".
        /// </summary>
        /// <returns></returns>
        public IStock CreateStock()
        {
            return new GazpromStock();
        }
    }
}
