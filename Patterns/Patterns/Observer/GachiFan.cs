using System;

namespace Norbit.Crm.Kiselev.Patterns.Observer
{
    /// <summary>
    /// Класс-подписчик.
    /// </summary>
    public class GachiFan : ISubscriber
    {
        /// <summary>
        /// Фраза подписчика.
        /// </summary>
        public string Phrase { get; set; }

        /// <summary>
        /// Обработчик события.
        /// </summary>
        /// <param name="publisher">Издатель события.</param>
        public void GetEvent(IPublisher publisher)
        {
            var billy = publisher as BillyHerrington;
            if (billy is null)
            {
                Phrase = "Sleep tight, Aniki";
            }
            Phrase = billy.Phrase + "we can!";

            Console.WriteLine(Phrase);
        }


    }
}
