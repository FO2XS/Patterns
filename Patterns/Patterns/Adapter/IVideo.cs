namespace Norbit.Crm.Kiselev.Patterns.Adapter
{
    /// <summary>
    /// Базовый интерфейс для работы с адаптерами.
    /// </summary>
    internal interface IVideo
    {
        /// <summary>
        /// Выводит текст на экран.
        /// </summary>
        /// <param name="text">Выводимый текст.</param>
        void Show(string text);
    }
}
