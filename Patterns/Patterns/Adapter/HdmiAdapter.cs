using System;

namespace Norbit.Crm.Kiselev.Patterns.Adapter
{
    /// <summary>
    /// Адаптер на разъём HDMI.
    /// </summary>
    public class HdmiAdapter : IVideo
    {
        /// <summary>
        /// Адаптируемая техника.
        /// </summary>
        Tv Adapter { get; set; }

        /// <summary>
        /// Создает адаптер.
        /// </summary>
        /// <param name="monitor">Адаптируемый объект.</param>
        public HdmiAdapter(Tv tv)
        {
            Adapter = tv ?? throw new ArgumentNullException(nameof(tv));
        }

        /// <summary>
        /// Отобразить на экране.
        /// </summary>
        /// <param name="text">Текст.</param>
        public void Show(string text)
        {
            Adapter.ShowWithHdmi(text);
        }
    }
}
