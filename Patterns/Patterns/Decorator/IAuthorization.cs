namespace Norbit.Crm.Kiselev.Patterns.Decorator
{
    /// <summary>
    /// Базовый интерфейс авторизации пользователя.
    /// </summary>
    public interface IAuthorization
    {
        /// <summary>
        /// Проверяет введенные пользователем данные для авторизации.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="password">Пароль.</param>
        /// <returns></returns>
        bool Verification(string name, string password);
    }
}
