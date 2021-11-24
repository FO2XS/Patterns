using Norbit.Crm.Kiselev.Patterns.Models;
using System;

namespace Norbit.Crm.Kiselev.Patterns.AbstractFactory
{
    /// <summary>
    /// Американские гос. облигации.
    /// </summary>
    public class DollarBond : IBond
    {
        /// <summary>
        /// Валюта.
        /// </summary>
        public Currency Currency { get; } = Currency.USD;

        /// <summary>
        /// Процентная ставка.
        /// </summary>
        public float Percent { get; }

        /// <summary>
        /// Время истечения облигации.
        /// </summary>
        public DateTime BondEnd { get; }

        /// <summary>
        /// Создает новую американскую гос. облигацию.
        /// </summary>
        public DollarBond()
        {
            Percent = 2.1F;
            BondEnd = DateTime.Now.AddYears(20);
        }
    }
}
