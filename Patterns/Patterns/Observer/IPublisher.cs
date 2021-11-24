using System.Collections.Generic;

namespace Norbit.Crm.Kiselev.Patterns.Observer
{
    /// <summary>
    /// Интерфейс издателя.
    /// </summary>
    public interface IPublisher
    {
        /// <summary>
        /// Список подписчиков.
        /// </summary>
        List<ISubscriber> Subscribers { get; }

        /// <summary>
        /// Добавление нового подписчика.
        /// </summary>
        /// <param name="subscriber">Подписчик.</param>
        bool Subscribe(ISubscriber subscriber);

        /// <summary>
        /// Удаление подписки.
        /// </summary>
        /// <param name="subscriber">Удаляемый подписчик.</param>
        bool Unsubscribe(ISubscriber subscriber);

        /// <summary>
        /// Опубликовать событие.
        /// </summary>
        void Publish();
    }
}
