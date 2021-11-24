using Norbit.Crm.Kiselev.Patterns.Models;
using System;

namespace Norbit.Crm.Kiselev.Patterns.AbstractFactory
{
    /// <summary>
    /// Акция компании "Тесла".
    /// </summary>
    public class TeslaStock : IStock
    {
        /// <summary>
        /// Валюта.
        /// </summary>
        public Currency Currency { get; } = Currency.USD;

        /// <summary>
        /// Цена Теслы.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// Название компании.
        /// </summary>
        public string Title { get; } = "Tesla";

        /// <summary>
        /// Создает новую акцию Теслы.
        /// </summary>
        public TeslaStock()
        {
            Price = 1137.06M;
        }
    }
}
