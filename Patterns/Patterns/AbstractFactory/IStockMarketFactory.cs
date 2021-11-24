namespace Norbit.Crm.Kiselev.Patterns.AbstractFactory
{
    /// <summary>
    /// Фабрика фондовых бирж, управляющих ценными бумагами.
    /// </summary>
    public interface IStockMarketFactory
    {
        /// <summary>
        /// Создает новую акцию.
        /// </summary>
        /// <returns>Акция.</returns>
        IStock CreateStock();
        /// <summary>
        /// Создает новую облигацию.
        /// </summary>
        /// <returns>Облигация.</returns>
        IBond CreateBond();
    }
}
