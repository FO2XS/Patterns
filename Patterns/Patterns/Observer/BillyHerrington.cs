using System;
using System.Collections.Generic;

namespace Norbit.Crm.Kiselev.Patterns.Observer
{
    /// <summary>
    /// Класс-издатель.
    /// </summary>
    public class BillyHerrington : IPublisher
    {
        /// <summary>
        /// Лист подписчиков.
        /// </summary>
        public List<ISubscriber> Subscribers { get; }

        /// <summary>
        /// Информация для подписчиков.
        /// </summary>
        public string Phrase { get; } = "As ";

        /// <summary>
        /// Создает экземпляр объекта без подписчиков.
        /// </summary>
        public BillyHerrington()
        {
            Subscribers = new List<ISubscriber>();
        }


        /// <summary>
        /// Публикация события.
        /// </summary>
        public void Publish()
        {
            Subscribers.ForEach(x => x.GetEvent(this));
        }

        /// <summary>
        /// Добавление нового подписчика.
        /// </summary>
        /// <param name="subscriber">Новый подписчик.</param>
        /// <returns>True - успешная подписка, false - подписка существует.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool Subscribe(ISubscriber subscriber)
        {
            if(subscriber is null)
            {
                throw new ArgumentNullException(nameof(subscriber));
            }

            if (Subscribers.Contains(subscriber))
            {
                return false;
            }

            Subscribers.Add(subscriber);

            return true;
        }

        /// <summary>
        /// Отписка существующего подписчика.
        /// </summary>
        /// <param name="subscriber">Отписывающийся подписчик.</param>
        /// <returns>True - успешная отписка, false - подписки не существует.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool Unsubscribe(ISubscriber subscriber)
        {
            if (subscriber is null)
            {
                throw new ArgumentNullException(nameof(subscriber));
            }

            if (!Subscribers.Contains(subscriber))
            {
                return false;
            }

            Subscribers.Remove(subscriber);

            return true;
        }
    }
}
