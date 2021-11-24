using Norbit.Crm.Kiselev.Patterns.Models;

namespace Norbit.Crm.Kiselev.Patterns.Decorator
{
    /// <summary>
    /// Класс авторизации с базовой функциональностью.
    /// </summary>
    internal sealed class BaseAuthorizer : IAuthorization
    {
        /// <summary>
        /// Сверяет введенные данные с данными пользователей системы.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="password">Пароль.</param>
        /// <returns>True - в случае нахождения пользователя с идентичными данными, false - в остальных случаях.</returns>
        public bool Verification(string name, string password)
        {
            return User.Users.Find(user => user.Name.Equals(name) && user.Password.Equals(password)) != null;
        }
    }
}
