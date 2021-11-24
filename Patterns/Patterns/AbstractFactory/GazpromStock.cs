using Norbit.Crm.Kiselev.Patterns.Models;

namespace Norbit.Crm.Kiselev.Patterns.AbstractFactory
{
    /// <summary>
    /// Акция компании "Газпром".
    /// </summary>
    internal class GazpromStock : IStock
    {
        /// <summary>
        /// Валюта.
        /// </summary>
        public Currency Currency { get; } = Currency.RUB;

        /// <summary>
        /// Цена Газпрома.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// Название компании.
        /// </summary>
        public string Title { get; } = "ПАО \"Газпром\"";

        /// <summary>
        /// Создает новую акцию Теслы.
        /// </summary>
        public GazpromStock()
        {
            Price = 337.62M;
        }
    }
}
