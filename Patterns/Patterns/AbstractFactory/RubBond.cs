using Norbit.Crm.Kiselev.Patterns.Models;
using System;

namespace Norbit.Crm.Kiselev.Patterns.AbstractFactory
{
    /// <summary>
    /// Российские гос. облигации.
    /// </summary>
    public class RubBond : IBond
    {
        /// <summary>
        /// Валюта.
        /// </summary>
        public Currency Currency { get; } = Currency.RUB;

        /// <summary>
        /// Процентная ставка.
        /// </summary>
        public float Percent { get; }

        /// <summary>
        /// Время истечения облигации.
        /// </summary>
        public DateTime BondEnd { get; }

        /// <summary>
        /// Создает новую облигацию.
        /// </summary>
        public RubBond()
        {
            Percent = 11.34F;
            BondEnd = DateTime.Now.AddYears(1);
        }
    }
}
