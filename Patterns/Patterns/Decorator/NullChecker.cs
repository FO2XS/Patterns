namespace Norbit.Crm.Kiselev.Patterns.Decorator
{
    /// <summary>
    /// Валидирует входные данные на пустые значения.
    /// </summary>
    internal class NullChecker : AuthorizeDecorator
    {
        /// <summary>
        /// Создает обертку базового авторизатора.
        /// </summary>
        /// <param name="authorization">Обертываемый объект.</param>
        public NullChecker(IAuthorization authorization) : base(authorization)
        {
        }

        /// <summary>
        /// Проверяет данные на пустые значения и передает на проверку базовому авторизатору.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="password">Пароль.</param>
        /// <returns>True - в случае прохождения проверки, false - в случае непрохождения.</returns>
        public override bool Verification(string name, string password)
        {
            return (!string.IsNullOrEmpty(name)
                || !string.IsNullOrEmpty(password))
                && base.Verification(name, password);
        }
    }
}
