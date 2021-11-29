using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__4
{
    public class Drink
    {
    }

    // используемый фрукт в соке
    public enum JuiceType { apple, orange, cherry, apricot, grapes };

    // Сок, наследуется от класса-родителя Drink
    public class Juice : Drink
    {
        public JuiceType type = JuiceType.apple; // используемый фрукт
        public bool WithPulp = false; // наличие мякоти
    }

    // вид газировки
    public enum SodaType { lemonade, mineral };

    // Газировка, наследуется от класса-родителя Drink
    public class Soda : Drink
    {
        public SodaType type = SodaType.lemonade; // вид
        public int BubblesNumber = 0; // количество пузырьков

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
    }
}