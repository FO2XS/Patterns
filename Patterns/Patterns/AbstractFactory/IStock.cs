using Norbit.Crm.Kiselev.Patterns.Models;

namespace Norbit.Crm.Kiselev.Patterns.AbstractFactory
{
    /// <summary>
    /// Интерфейс акций.
    /// </summary>
    public interface IStock
    {
        /// <summary>
        /// Валюта акции.
        /// </summary>
        Currency Currency { get; }
        /// <summary>
        /// Цена акции.
        /// </summary>
        decimal Price { get; }
        /// <summary>
        /// Название компании.
        /// </summary>
        string Title { get; }
    }
}