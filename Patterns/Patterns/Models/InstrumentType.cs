namespace Norbit.Crm.Kiselev.Patterns.Models
{
    /// <summary>
    /// Виды активов фондового рынка.
    /// </summary>
    public enum InstrumentType
    {
        /// <summary>
        /// Акция.
        /// </summary>
        Stock,
        /// <summary>
        /// Валюта.
        /// </summary>
        Currency,
        /// <summary>
        /// Облигация.
        /// </summary>
        Bond,
        /// <summary>
        /// Фонд.
        /// </summary>
        Etf,
        /// <summary>
        /// Все виды ценных бумаг.
        /// </summary>
        All
    }
}
