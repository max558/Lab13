using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    /*
     * Задан класс Building, который описывает здание. Класс содержит следующие элементы: 
     *      адрес здания; 
     *      длина здания; 
     *      ширина здания; 
     *      высота здания. 
     *      
     * В классе Building нужно реализовать следующие методы: 
     *      конструктор с 4 параметрами; 
     *      свойства get/set для доступа к полям класса; 
     *      метод Print(), который выводит информацию о здании. 
     *      
     * Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать 
     * следующие элементы: 
     *      конструктор с 5 параметрами – реализует вызов конструктора базового класса; 
     *      свойство get/set доступа к внутреннему полю класса; 
     *      метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса. 
     *      
     * Класс MultiBuilding сделать таким, что не может быть унаследован.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Спб, ул.Пример, д.0", 40, 12.5, 9);
            MultiBuilding multiBuilding = new MultiBuilding("Спб, ул.Пример, д.1", 25, 15, 7, 2);
            building.Print();
            Console.WriteLine();
            multiBuilding.Print();
            Console.ReadKey();
        }
    }

    public class Building
    {
        public string Adress { get; set; }
        double length;
        double width;
        double height;

        public Building(string adress, double length, double width, double height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! не верный ввод длины.");
                }
            }
            get
            {
                return length;
            }
        }
        public double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! не верный ввод ширины.");
                }
            }
            get
            {
                return width;
            }
        }
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! не верный ввод высоты.");
                }
            }
            get
            {
                return height;
            }
        }

        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", Adress);
            Console.WriteLine("           Длина здания: {0}", length);
            Console.WriteLine("           Ширина здания: {0}", width);
            Console.WriteLine("           Высота здания: {0}", height);
        }
    }
    sealed class MultiBuilding : Building
    {
        int level;
        public MultiBuilding(string adress, double length, double width, double height, int level)
            : base(adress, length, width, height)
        {
            Level = level;
        }
        public int Level
        {
            set
            {
                if (value >= 0)
                {
                    level = value;
                }
                else
                {
                    Console.WriteLine("Ошибка, ввода номера этажа.");
                }
            }
            get
            {
                return level;
            }
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("           Этажность здания: {0}", level);
        }
    }
}
