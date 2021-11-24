using System;

namespace Norbit.Crm.Kiselev.Patterns.Decorator
{
    /// <summary>
    /// Базовый декоратор, с кодом обертывания.
    /// </summary>
    public class AuthorizeDecorator : IAuthorization
    {
        /// <summary>
        /// Обертываемый объект.
        /// </summary>
        private IAuthorization _baseAuth;

        /// <summary>
        /// Создание обертки.
        /// </summary>
        /// <param name="authorization">Обертываемый объект.</param>
        public AuthorizeDecorator(IAuthorization authorization)
        {
            
            _baseAuth = authorization ?? throw new ArgumentNullException(nameof(authorization));
        }

        /// <summary>
        /// Проверяет введенные пользователем данные авторизации.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="password">Пароль.</param>
        /// <returns>True - в случае прохождения проверки, false - в случае непрохождения.</returns>
        public virtual bool Verification(string name, string password)
        {
            return _baseAuth.Verification(name, password);
        }
    }
}
