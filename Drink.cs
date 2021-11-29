using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__4
{
    // используемый фрукт в соке
    public enum JuiceType { apple, orange, cherry, apricot, grapes };

    // Сок
    public class Juice
    {
        public JuiceType type = JuiceType.apple; // используемый фрукт
        public bool WithPulp = false; // наличие мякоти
    }

    // вид газировки
    public enum SodaType { lemonade, mineral };

    // Газировка
    public class Soda
    {
        public SodaType type = SodaType.lemonade; // вид
        public int BubblesNumber = 0; // количество пузырьков

    }

    // крепость алкоголя
    public enum AlcoholFortressType { low, medium, strong };

    // тип алкоголя
    public enum AlcoholType { whiskey, rum, wine, liqueur };
    // Алкоголь
    public class Alcohol
    {
        public AlcoholFortressType fortressType = AlcoholFortressType.low; // крепость
        public AlcoholType type = AlcoholType.whiskey; // тип 
    }
}