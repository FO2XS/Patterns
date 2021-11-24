using System;

namespace Norbit.Crm.Kiselev.Patterns.Adapter
{
    /// <summary>
    /// Системный блок.
    /// </summary>
    internal class Pc
    {
        /// <summary>
        /// Видео-разъём.
        /// </summary>
        public IVideo Video { get; set; }

        /// <summary>
        /// Иницализирует компьютер с видео-адаптером.
        /// </summary>
        /// <param name="video">Адаптер.</param>
        public Pc(IVideo video)
        {
            Video = video;
        }

        /// <summary>
        /// Отобразить на экране текст.
        /// </summary>
        /// <param name="text">Текст.</param>
        public void ShowWithAdapter(string text)
        {
            Console.WriteLine("Подключаемся по родному разъему PC.");
            Video.Show(text);
        }
    }
}
