using Norbit.Crm.Kiselev.Patterns.Models;
using System;

namespace Norbit.Crm.Kiselev.Patterns.AbstractFactory
{
    /// <summary>
    /// Интерфейс облигаций.
    /// </summary>
    public interface IBond
    {
        /// <summary>
        /// Валюта облигации.
        /// </summary>
        Currency Currency { get; }
        /// <summary>
        /// Процентная ставка.
        /// </summary>
        float Percent { get; }
        /// <summary>
        /// Дата закрытия облигации.
        /// </summary>
        DateTime BondEnd { get; }
    }
}
