using System;
using System.Collections.Generic;

namespace Magazin
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Buyer buyer = new Buyer(
                "Vanya",
                "Pushkina street, Kolotushkino home",
                10000,
                550
            );
            Console.WriteLine("Список товаров");
            Candies Chocolate = new Candies(
                "Щедрая душа",
                700,
                "Россия",
                "Шоколадные конфеты",
                50,
                14
            );
           
            Console.WriteLine("Конфеты");
            Console.WriteLine("Название: " + Chocolate.Name);
            Console.WriteLine("Цена за штуку: " + Chocolate.Pr_1);
            Console.WriteLine("ПРоизводитель: " + Chocolate.Manufacture);
            Console.WriteLine("Вид: " + Chocolate.Type);
            Console.WriteLine("Кол-во: " + Chocolate.Quantity);
            Console.WriteLine("Итог: " +  Chocolate.Price);
            Console.WriteLine(new String('-', 25));
            Candies Chocolate2 = new Candies(
                "Аленка",
                720,
                "Россия",
                "Карамельные конфеты",
                55,
                12
            );

            Console.WriteLine("Конфеты");
            Console.WriteLine("Название: " + Chocolate2.Name);
            Console.WriteLine("Цена за штуку: " + Chocolate2.Pr_1);
            Console.WriteLine("ПРоизводитель: " + Chocolate2.Manufacture);
            Console.WriteLine("Вид: " + Chocolate2.Type);
            Console.WriteLine("Кол-во: " + Chocolate2.Quantity);
            Console.WriteLine("Итог: " + Chocolate.Price);
            Console.WriteLine(new String('-', 25));
            Candies Chocolate3 = new Candies(
                "Вираж",
                650,
                "Казахстан",
                "грильяжные конфеты",
                55,
                11
            );

            Console.WriteLine("Конфеты");
            Console.WriteLine("Название: " + Chocolate3.Name);
            Console.WriteLine("Цена за штуку: " + Chocolate3.Pr_1);
            Console.WriteLine("ПРоизводитель: " + Chocolate3.Manufacture);
            Console.WriteLine("Вид: " + Chocolate3.Type);
            Console.WriteLine("Кол-во: " + Chocolate3.Quantity);
            Console.WriteLine("Итог: " +  Chocolate3.Price);
            Console.WriteLine(new String('-', 25));


            Socks Abibas = new Socks(
                "Abibas",
                200,
                "Китай",
                "Черный",
                49
            );
            Console.WriteLine("Носки");
            Console.WriteLine("Название: " + Abibas.Name);
            Console.WriteLine("Цена: " + Abibas.Price);
            Console.WriteLine("Страна Производитель: " + Abibas.Manufacture);
            Console.WriteLine("Цвет: " + Abibas.Color);
            Console.WriteLine("Размер: " + Abibas.Size);
            Console.WriteLine(new String('-', 25));

            Socks Puma = new Socks(
                "Puma",
                300,
                "Китай",
                "Черный",
                42
            );
            Console.WriteLine("Носки");
            Console.WriteLine("Название: " + Puma.Name);
            Console.WriteLine("Цена: " + Puma.Price);
            Console.WriteLine("Страна Производитель: " + Puma.Manufacture);
            Console.WriteLine("Цвет: " + Puma.Color);
            Console.WriteLine("Размер: " + Puma.Size);
            Console.WriteLine(new String('-', 25));

            Socks Nike = new Socks(
                "Nike",
                800,
                "Китай",
                "Черный",
                32
            );
            Console.WriteLine("Носки");
            Console.WriteLine("Название: " + Nike.Name);
            Console.WriteLine("Цена: " + Nike.Price);
            Console.WriteLine("Страна Производитель: " + Nike.Manufacture);
            Console.WriteLine("Цвет: " + Nike.Color);
            Console.WriteLine("Размер: " + Nike.Size);
            Console.WriteLine(new String('-', 25));

            Parfume Dparfume = new Parfume(
                "Шанель",
                2000,
                "Где-то рядом с францией",
                "Весенних цветов"
            );
            Console.WriteLine("Духи");
            Console.WriteLine("Название: " + Dparfume.Name);
            Console.WriteLine("Цена: " + Dparfume.Price);
            Console.WriteLine("Страна Производитель: " + Dparfume.Manufacture);
            Console.WriteLine("Запах: " + Dparfume.Smell);
            Console.WriteLine(new String('-', 25));

            Parfume Dparfume1 = new Parfume(
                "Ferrari",
                3000,
                "Италия",
                "Поленых покрышек"
            );
            Console.WriteLine("Духи");
            Console.WriteLine("Название: " + Dparfume1.Name);
            Console.WriteLine("Цена: " + Dparfume1.Price);
            Console.WriteLine("Страна Производитель: " + Dparfume1.Manufacture);
            Console.WriteLine("Запах: " + Dparfume1.Smell);
            Console.WriteLine(new String('-', 25));

            Parfume Dparfume2 = new Parfume(
                "Adidas",
                5000,
                "USA",
                "Спорта"
            );
            Console.WriteLine("Духи");
            Console.WriteLine("Название: " + Dparfume2.Name);
            Console.WriteLine("Цена: " + Dparfume2.Price);
            Console.WriteLine("Страна Производитель: " + Dparfume2.Manufacture);
            Console.WriteLine("Запах: " + Dparfume2.Smell);
            Console.WriteLine(new String('-', 25));

            Flower Rose = new Flower(
                "Роза не комнатная",
                150,
                "Галандия",
                "Не комнатный",
                "Белые"
            );
            Console.WriteLine("Роза");
            Console.WriteLine("Название: " + Rose.Name);
            Console.WriteLine("Цена: " + Rose.Price);
            Console.WriteLine("Страна Производитель: " + Rose.Manufacture);
            Console.WriteLine("Тип: " + Rose.Type);
            Console.WriteLine("Цвет: " + Rose.Color);
            Console.WriteLine(new String('-', 25));

            Flower Tulp = new Flower(
                "Тюлпан",
                90,
                "Галандия",
                "Не комнатный",
                "Желтые"
            );
            Console.WriteLine("Роза");
            Console.WriteLine("Название: " + Tulp.Name);
            Console.WriteLine("Цена: " + Tulp.Price);
            Console.WriteLine("Страна Производитель: " + Tulp.Manufacture);
            Console.WriteLine("Тип: " + Tulp.Type);
            Console.WriteLine("Цвет: " + Tulp.Color);
            Console.WriteLine(new String('-', 25));
            Flower Pion = new Flower(
                "Пион",
                130,
                "Галандия",
                "Не комнатный",
                "Белые"
            );
            Console.WriteLine("Роза");
            Console.WriteLine("Название: " + Pion.Name);
            Console.WriteLine("Цена: " + Pion.Price);
            Console.WriteLine("Страна Производитель: " + Pion.Manufacture);
            Console.WriteLine("Тип: " + Pion.Type);
            Console.WriteLine("Цвет: " + Pion.Color);
            Console.WriteLine(new String('-', 25));
            Cosmetics Carcass = new Cosmetics(
               "?????",
               150,
               "Зимбабве",
               "Для ресниц",
               "Черный"
           );
            Console.WriteLine("Туш");
            Console.WriteLine("Название: " + Carcass.Name);
            Console.WriteLine("Цена: " + Carcass.Price);
            Console.WriteLine("Страна Производитель: " + Carcass.Manufacture);
            Console.WriteLine("Тип: " + Carcass.Type);
            Console.WriteLine("Цвет: " + Carcass.Color);
            Console.WriteLine(new String('-', 25));
            Cosmetics Carcass1 = new Cosmetics(
               "******",
               350,
               "Зимбабве",
               "Для ресниц",
               "Черный"
           );
            Console.WriteLine("Туш");
            Console.WriteLine("Название: " + Carcass1.Name);
            Console.WriteLine("Цена: " + Carcass1.Price);
            Console.WriteLine("Страна Производитель: " + Carcass1.Manufacture);
            Console.WriteLine("Тип: " + Carcass1.Type);
            Console.WriteLine("Цвет: " + Carcass1.Color);
            Console.WriteLine(new String('-', 25));
            Cosmetics Carcass2 = new Cosmetics(
               "/_(-_-)_/ ",
               250,
               "Зимбабве",
               "Для ресниц",
               "Черный"
           );
            Console.WriteLine("Туш");
            Console.WriteLine("Название: " + Carcass2.Name);
            Console.WriteLine("Цена: " + Carcass2.Price);
            Console.WriteLine("Страна Производитель: " + Carcass2.Manufacture);
            Console.WriteLine("Тип: " + Carcass2.Type);
            Console.WriteLine("Цвет: " + Carcass2.Color);
            Console.WriteLine(new String('-', 25));


            Product[] products = new Product[]
            {
                Chocolate,Chocolate2,Chocolate3, Abibas,Puma,Nike, Carcass,Carcass1,Carcass2,Dparfume,Dparfume1,Dparfume2,Rose,Tulp,Pion
            };

            


            Informer informer = new Informer();
            ///как надо делать маркетинг!!!!
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуй {buyer.Name} ваш баланс {buyer.Balance}");

                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter:");
                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);
                if (productNumber >= 0 && productNumber < products.Length)
                {
                    if (products[productNumber].Price < buyer.Balance)
                    {
                        informer.Buy(buyer, products[productNumber]);

                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");

                    }
                }
                else
                {
                    Console.WriteLine("Такого товара нет");
                }
            }
        }
    }
}
