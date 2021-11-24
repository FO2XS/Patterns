namespace Norbit.Crm.Kiselev.Patterns.Observer
{
    //В данной реализации паттерна Наблюдатель
    //подписчик получает обновленное состояние издателя
    //через передачу всего объекта издателя.
    /// <summary>
    /// Интерфейс подписчика.
    /// </summary>
    public interface ISubscriber
    {
        /// <summary>
        /// Метод, используемый издателем для оповещения подписчиков.
        /// </summary>
        /// <param name="publisher">Экземпляр издателя.</param>
        void GetEvent(IPublisher publisher);
    }
}
