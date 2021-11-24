using System;
using Norbit.Crm.Kiselev.Patterns.Observer;
using Norbit.Crm.Kiselev.Patterns.Decorator;
using Norbit.Crm.Kiselev.Patterns.Adapter;
using Norbit.Crm.Kiselev.Patterns.Models;
using Norbit.Crm.Kiselev.Patterns.Singleton;
using Norbit.Crm.Kiselev.Patterns.AbstractFactory;

namespace Norbit.Crm.Kiselev.Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adapter();
            //Decorator();
            //Observer();
            //Singleton();
            AbstractFactory();
        }

        static void AbstractFactory()
        {
            var unknownMarketExchange = new MoscowExchangeFactory() as IStockMarketFactory;
            Console.WriteLine($"Создадим на бирже акцию компании - {unknownMarketExchange.CreateStock().Title}");

            unknownMarketExchange = new NasdaqFactory();
            Console.WriteLine($"Создадим на другой бирже акцию компании - {unknownMarketExchange.CreateStock().Title}");

            Console.ReadLine();
        }

        static void Singleton()
        {
            var instance = DapperProvider.GetInstance("test connection string");
            Console.WriteLine($"Создан провайдер со строкой подключения: {instance.ConnectionString}");
            var instance2 = DapperProvider.GetInstance("test another connection string");
            Console.WriteLine($"Попытка создать нового провайдера. Полученная строка подключения: {instance2.ConnectionString}");

            Console.ReadLine();
        }

        static void Observer()
        {
            var billy = new BillyHerrington();
            var gachiFanOne = new GachiFan();
            var gachiFanTwo = new GachiFan();
            billy.Subscribe(gachiFanOne);
            billy.Subscribe(gachiFanTwo);

            billy.Publish();

            billy.Unsubscribe(gachiFanOne);

            billy.Publish();

            Console.ReadLine();
        }

        static void Decorator()
        {
            var baseAuth = new AuthorizeDecorator(new BaseAuthorizer());
            var punctuationPart = new PunctuationChecker(baseAuth);
            var lengthPart = new LengthChecker(punctuationPart, 5);
            var emptyPart = new NullChecker(lengthPart);

            User.Users.ForEach(u =>
            {
                var result = emptyPart.Verification(u.Name, u.Password);
                var outputResult = result ? "Подходит" : "Не подходит";
                Console.WriteLine($"Пароль {u.Password} {outputResult}");
            });
            
            Console.ReadLine();
        }

        static void Adapter()
        {
            Tv tv = new Tv();
            Monitor monitor = new Monitor();
            VgaAdapter vgaAdapter = new VgaAdapter(monitor);
            HdmiAdapter hdmiAdapter = new HdmiAdapter(tv);

            Pc pc = new Pc(vgaAdapter);
            pc.ShowWithAdapter("Смотрим видео по монитору");
            pc.Video = hdmiAdapter;
            pc.ShowWithAdapter("Смотрим видео по телику");
        }
    }
}
