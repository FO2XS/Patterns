using System.Collections.Generic;

namespace Norbit.Crm.Kiselev.Patterns.Models
{
    /// <summary>
    /// Пользователь системы.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Логин.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Пароль.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Создает нового пользователя.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="password">Пароль.</param>
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        /// <summary>
        /// Существующие пользователи.
        /// </summary>
        public static List<User> Users = new List<User>() 
        { 
            new User("Ivan", "qwerty123"),
            new User("Nagibator99", "12345."),
            new User("Dendi", "A.o,Na][Vi"),
            new User("Solo", "322zxcvbA.")
        };
    }
}
