using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__4
{
    public class Drink
    {
        // статическое поле rnd в базовом классе

        // поле с модификатором доступа protected доступно:
        // • в пределах всех классов, находящихся в том же пакете, что и наш
        // • в пределах всех классов-наследников нашего класса, даже из другого пакета
        // недоступно для внешних классов из других пакетов
        protected static Random rnd = new Random();

        public int Volume = 0; // объём, общее поле для всех напитков

        // метод для вывода информации о напитке
        public virtual String GetInfo() // ключевое слово virtual нужно, чтобы
                                        // переопределить функцию в классах-наследниках
        {
            String str = String.Format("\nОбъём: {0}", this.Volume); // информация об объёме
            return str;
        }
        // за счет того, что наследовали классы Juice, Soda, Alcohol от типа Drink,
        // все они неявно сделали метод GetInfo частью себя

        // это одно из свойств наследования, которое позволяет выносить логику,
        // не являющиеся специфичной для типа в родительский класс
    }

    // используемый фрукт в соке
    public enum JuiceType { Яблоко, Апельсин, Вишня, Абрикос, Виноград };

    // Сок, наследуется от класса-родителя Drink
    public class Juice : Drink
    {
        public JuiceType type = JuiceType.Яблоко; // используемый фрукт
        public bool WithPulp = false; // наличие мякоти

        // переопределим метод класса-родителя Drink
        public override string GetInfo()
        {
            String str = "Я сок";
            str += base.GetInfo(); // вызов метода GetInfo базового класса, т.е. Drink
                                   // с помощью ключевого слова base, чтобы получить информацию об объёме

            str += String.Format("\nИспользуемый фрукт: {0}", this.type);
            str += String.Format("\nНаличие мякоти: {0}", this.WithPulp);
            return str;
        }

        // статический метод генерации случайного сока
        public static Juice Generate()
        {
            return new Juice
            {
                Volume = rnd.Next() % 100, // объём от 0 до 100
                type = (JuiceType)rnd.Next(5), // используемый фрукт
                WithPulp = rnd.Next() % 2 == 0 // наличие мякоти true или false
            };
        }
    }

    // вид газировки
    public enum SodaType { Фруктовая, Минеральная };

    // Газировка, наследуется от класса-родителя Drink
    public class Soda : Drink
    {
        public SodaType type = SodaType.Фруктовая; // вид
        public int BubblesNumber = 0; // количество пузырьков

        // переопределим метод класса-родителя Drink
        public override string GetInfo()
        {
            String str = "Я газировка";
            str += base.GetInfo(); // вызов метода GetInfo базового класса, т.е. Drink
                                   // с помощью ключевого слова base, чтобы получить информацию об объёме

            str += String.Format("\nВид: {0}", this.type);
            str += String.Format("\nКоличество пузырьков: {0}", this.BubblesNumber);
            return str;
        }
        // статический метод генерации случайной газировки
        public static Soda Generate()
        {
            return new Soda
            {
                Volume = rnd.Next() % 100, // объём от 0 до 100
                type = (SodaType)rnd.Next(2), // вид
                BubblesNumber = rnd.Next() % 15000 // количество пузырьков от 0 до 15000
            };
        }
    }

    // крепость алкоголя
    public enum AlcoholFortress { Слабоалкогольный, Среднеалкогольный, Крепкий };

    // тип алкоголя
    public enum AlcoholType { Виски, Ром, Вино, Ликёр };

    // Алкоголь, наследуется от класса-родителя Drink
    public class Alcohol : Drink
    {
        public AlcoholFortress fortress = AlcoholFortress.Слабоалкогольный; // крепость
        public AlcoholType type = AlcoholType.Виски; // тип 

        // переопределим метод класса-родителя Drink
        public override string GetInfo()
        {
            String str = "Я алкоголь";
            str += base.GetInfo(); // вызов метода GetInfo базового класса, т.е. Drink
                                   // с помощью ключевого слова base, чтобы получить информацию об объёме

            str += String.Format("\nКрепость алкоголя: {0}", this.fortress);
            str += String.Format("\nТип: {0}", this.type);
            return str;
        }

        // статический метод генерации случайного алкоголя
        public static Alcohol Generate()
        {
            return new Alcohol
            {
                Volume = rnd.Next() % 100, // объём от 0 до 100
                fortress = (AlcoholFortress)rnd.Next(3), // крепость
                type = (AlcoholType)rnd.Next(4) // тип
            };
        }
    }
}