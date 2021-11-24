using System;

namespace Norbit.Crm.Kiselev.Patterns.Decorator
{
    /// <summary>
    /// Проверяет длину пароля.
    /// </summary>
    public class LengthChecker : AuthorizeDecorator
    {
        /// <summary>
        /// Минимальная длина пароля.
        /// </summary>
        private int _passwordLength;
        /// <summary>
        /// Создает обертку базового авторизатора.
        /// </summary>
        /// <param name="authorization">Обертываемый объект.</param>
        /// <param name="length">Минимальная длина пароля.</param>
        public LengthChecker(IAuthorization authorization, int length) : base(authorization)
        {
            if(length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length) + "Длина не может быть меньше 1");
            }
            _passwordLength = length;
        }

        /// <summary>
        /// Проверяет пароль на соответствие минимальной длине и передает на проверку базовому авторизатору.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="password">Пароль.</param>
        /// <returns>True - в случае прохождения проверки, false - в случае непрохождения.</returns>
        public override bool Verification(string name, string password)
        {
            return password.Length >= _passwordLength && base.Verification(name, password);
        }
    }
}
