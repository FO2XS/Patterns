using System;

namespace Norbit.Crm.Kiselev.Patterns.Adapter
{
    /// <summary>
    /// Монитор.
    /// </summary>
    public class Monitor
    {
        /// <summary>
        /// Отобразить через разъём VGA.
        /// </summary>
        /// <param name="text">Текст.</param>
        public void ShowWithVGA(string text)
        {
            Console.WriteLine("Подключаемся через Vga");
            Console.WriteLine(text);
        }
    }
}
