using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__4
{
    public class Drink
    {
        public int Volume = 0; // объём, общее поле для всех напиток

        // метод для вывода информации о напитке
        public virtual String GetInfo() // ключевое слово virtual нужно, чтобы
                                        // переопределить функцию в классах-наследниках
        {
            return "Я напиток";
        }
        // за счет того, что наследовали классы Juice, Soda, Alcohol от типа Drink,
        // все они неявно сделали метод GetInfo частью себя

        // это одно из свойств наследования, которое позволяет выносить логику,
        // не являющиеся специфичной для типа в родительский класс
    }

    // используемый фрукт в соке
    public enum JuiceType { apple, orange, cherry, apricot, grapes };

    // Сок, наследуется от класса-родителя Drink
    public class Juice : Drink
    {
        public JuiceType type = JuiceType.apple; // используемый фрукт
        public bool WithPulp = false; // наличие мякоти

        // переопределим метод класса-родителя Drink
        public override string GetInfo()
        {
            String str = "Я сок";
            str += String.Format("\nОбъём: {0}", this.Volume);
            return str;
        }
    }

    // вид газировки
    public enum SodaType { lemonade, mineral };

    // Газировка, наследуется от класса-родителя Drink
    public class Soda : Drink
    {
        public SodaType type = SodaType.lemonade; // вид
        public int BubblesNumber = 0; // количество пузырьков

        // переопределим метод класса-родителя Drink
        public override string GetInfo()
        {
            String str = "Я газировка";
            str += String.Format("\nОбъём: {0}", this.Volume);
            return str;
        }
    }

    // крепость алкоголя
    public enum AlcoholFortressType { low, medium, strong };

    // тип алкоголя
    public enum AlcoholType { whiskey, rum, wine, liqueur };

    // Алкоголь, наследуется от класса-родителя Drink
    public class Alcohol : Drink
    {
        public AlcoholFortressType fortressType = AlcoholFortressType.low; // крепость
        public AlcoholType type = AlcoholType.whiskey; // тип 

        // переопределим метод класса-родителя Drink
        public override string GetInfo()
        {
            String str = "Я алкоголь";
            str += String.Format("\nОбъём: {0}", this.Volume);
            return str;
        }
    }
}