using System;

namespace Norbit.Crm.Kiselev.Patterns.Adapter
{
    /// <summary>
    /// ЖК-телевизор.
    /// </summary>
    public class Tv
    {
        /// <summary>
        /// Отобразить через разъём HDMI.
        /// </summary>
        /// <param name="text">Текст.</param>
        public void ShowWithHdmi(string text)
        {
            Console.WriteLine("Подключаемся через Hdmi");
            Console.WriteLine(text);
        }
    }
}
