using System;

namespace Norbit.Crm.Kiselev.Patterns.Adapter
{
    /// <summary>
    /// Адаптер на разъём VGA.
    /// </summary>
    public class VgaAdapter : IVideo
    {
        /// <summary>
        /// Адаптируемая техника.
        /// </summary>
        Monitor Adapter { get; set; }

        /// <summary>
        /// Создает адаптер.
        /// </summary>
        /// <param name="monitor">Адаптируемый объект.</param>
        public VgaAdapter(Monitor monitor)
        {

            Adapter = monitor ?? throw new ArgumentNullException(nameof(Tv));
        }

        /// <summary>
        /// Отобразить на экране.
        /// </summary>
        /// <param name="text">Текст.</param>
        public void Show(string text)
        {
            Adapter.ShowWithVGA(text);
        }
    }
}
