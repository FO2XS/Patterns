using System.Linq;

namespace Norbit.Crm.Kiselev.Patterns.Decorator
{
    /// <summary>
    /// Проверяет наличие знаков пунктуации в пароле.
    /// </summary>
    public class PunctuationChecker : AuthorizeDecorator
    {
        /// <summary>
        /// Создает обертку базового авторизатора.
        /// </summary>
        /// <param name="authorization">Обертываемый объект.</param>
        public PunctuationChecker(IAuthorization authorization) : base(authorization)
        {
        }

        /// <summary>
        /// Проверяет наличие знаков пунктуации в пароле и передает на проверку базовому авторизатору.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="password">Пароль.</param>
        /// <returns>True - в случае прохождения проверки, false - в случае непрохождения.</returns>
        public override bool Verification(string name, string password)
        {
            var result = password.FirstOrDefault(x=>char.IsPunctuation(x)) != '\0';
            return result && base.Verification(name, password);
        }
    }
}
