using Dapper;
using Norbit.Crm.Kiselev.Patterns.Models;
using Npgsql;
using System;
using System.Data;

namespace Norbit.Crm.Kiselev.Patterns.Singleton
{
    /// <summary>
    /// Провайдер к БД через Dapper.
    /// </summary>
    public class DapperProvider
    {
        /// <summary>
        /// Единственный экземпляр сервиса.
        /// </summary>
        private static DapperProvider Instance;

        /// <summary>
        /// Строка подключения к БД.
        /// </summary>
        public string ConnectionString { get; }

        /// <summary>
        /// Инициализирует провайдера со строкой подключения.
        /// </summary>
        /// <param name="connectionString">Строка подключения.</param>
        private DapperProvider(string connectionString)
        {
            ConnectionString = connectionString;
        }

        /// <summary>
        /// Возвращает существующий или создает новый экземпляр провайдера.
        /// </summary>
        /// <param name="connectionString">Строка подключения.</param>
        /// <returns>Экземпляр провайдера.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static DapperProvider GetInstance(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException($"Пустая строка подключения {nameof(connectionString)}");
            }
            if (Instance != null)
            {
                return Instance;
            }

            Instance = new DapperProvider(connectionString);
            return Instance;
        }

        /// <summary>
        /// Возвращает ценную бумагу по её id.
        /// </summary>
        /// <param name="figi">Id ценной бумаги.</param>
        /// <returns>Ценная бумага.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Security GetSecurity(string figi)
        {
            if (string.IsNullOrEmpty(figi))
            {
                throw new ArgumentNullException($"Пустая строка подключения {nameof(figi)}");
            }

            string query = "SELECT \"Figi\", \"Isin\", \"Ticker\", \"CurrencyId\" as Currency, \"Name\", \"InstrumentTypeId\" as InstrumentType " +
                "FROM \"Stock\" " +
                "WHERE \"Figi\" like @Figi";

            using (IDbConnection db = new NpgsqlConnection(ConnectionString))
            {
                return db.QuerySingle<Security>(query, new { Figi = figi });
            }
        }
    }
}
