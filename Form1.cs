using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__4
{
    public partial class Form1 : Form
    {
        List<Drink> drinksList = new List<Drink>(); // поле под список напитков, нет объектов типа Drink
        public Form1()
        {
            InitializeComponent();
            ShowInfo(); // при запуске приложения вызывается метод для
                        // вывода информации о количестве напитков на форму
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.drinksList.Clear();
            Random rnd = new Random();
            for (int i=0;i<10;++i)
            {
                switch(rnd.Next() % 3) // // генерируем случайное число от 0 до 2 (остаток от деления на 3)
                {
                    case 0: // если 0, то кладем в drinkList объект класса Сок
                        this.drinksList.Add(new Juice
                        {
                            Volume = rnd.Next() % 101
                        });
                        break;
                    case 1: // если 1, то кладем в drinkList объект класса Газировка
                        this.drinksList.Add(new Soda
                        {
                            Volume = rnd.Next() % 101
                        });
                        break;
                    case 2: // если 2, то кладем в drinkList объект класса Алкоголь
                        this.drinksList.Add(new Alcohol
                        {
                            Volume = rnd.Next() % 101
                        });
                        break;
                }               
            }
            ShowInfo(); // метод для вывода информации о количестве напитков на форму
        }

        // метод для вывода информации о количестве напитков на форму
        private void ShowInfo()
        {
            // счетчики под каждый тип
            int juiceCount = 0;
            int sodaCount = 0;
            int alcoholCount = 0;

            // пройдемся по всему списку
            foreach(Drink drink in this.drinksList)
            {
                // в списке у нас лежат напитки, то есть объекты типа Drink,
                // поэтому чтобы проверить какой именно напиток
                // мы в данный момент обозреваем, мы используем ключевое слово is

                if(drink is Juice) // если drink есть Сок
                {
                    juiceCount += 1;
                }
                else if (drink is Soda) // если drink есть Газировка
                {
                    sodaCount += 1;
                }
                else if (drink is Alcohol) // если drink есть Алкоголь
                {
                    alcoholCount += 1;
                }
            }

            // выводим это все на форму
            txtInfo.Text = "Сок\tГазировка\tАлкоголь";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", juiceCount, sodaCount, alcoholCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.drinksList.Count == 0)
            {
                txtOut.Text = "Пусто";
                return;
            }

            Drink drink = this.drinksList[0]; // взяли первый напиток

            this.drinksList.RemoveAt(0); //  взятие это на самом деле создание указателя на область в памяти,
                                         // где хранится экземпляр класса, так что если удаляем, то сами

            txtOut.Text = drink.GetInfo(); // предложим покупателю его напиток

            ShowInfo(); // обновим информацию о количестве товара на форме
        }
    }
}
