namespace Norbit.Crm.Kiselev.Patterns.Models
{
    /// <summary>
    /// Ценная бумага.
    /// </summary>
    public class Security
    {
        /// <summary>
        /// Глобальный идентификатор финансового инструмента.
        /// </summary>
        public string Figi { get; set; }
        /// <summary>
        /// Краткое название ценной бумаги в рамках биржы.
        /// </summary>
        public string Ticker { get; set; }
        /// <summary>
        /// Международный идентификационный код ценной бумаги по стандарту ISO 6166.
        /// </summary>
        public string Isin { get; set; }
        /// <summary>
        /// Валюта.
        /// </summary>
        public Currency Currency { get; set; }
        /// <summary>
        /// Наименование ценной бумаги.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Тип ценной бумаги.
        /// </summary>
        public InstrumentType InstrumentType { get; set; }
    }
}
