using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Задание номер 1(а)");
            int max = Char.MaxValue;
            Console.WriteLine(max);

            //2
            Console.WriteLine("Задание номер 1(б)");
            Console.WriteLine("Введите число");
            int chislo = Convert.ToInt32(Console.ReadLine()); //проискодит преобразование в int32
            Console.WriteLine("Введенное число приобразованное в тип int32 " + chislo);

            //3
           
            Console.WriteLine("Задание номер 1(в)");
            char[,,] B = {
                   {
                       { 'a', 'a' },
                       { 'a', 'a' }
                   },
                   {
                       { 'a', 'a'},
                       { 'a', 'a'}
                   }
               };
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 2; k++)
                    {
                        Console.WriteLine(B[i, j, k]);
                    }

            //4
            Console.WriteLine("Задание номер 2");
            Time now = new Time(12, 26, 4, 2); //последний параметр - часть дня (1-PM, 2-AM) 
            Console.WriteLine(now.ToString());

            //5
            Console.WriteLine("Задание номер 3");
            House Pasha = new House();
            Pasha.name = "Паша";           // с
            Pasha.Run();
        }
    }

    //5
    public abstract class Mammal
    {
        public string name;

        public abstract void mammal();
    }
    public interface IRun
    {
        void Run();
    }
    class House : Mammal, IRun
    {
        override public void mammal()
        {
            Console.WriteLine("Metod mammal");

        }
        public void Run()
        {
            Console.WriteLine("Interface Irun");
            Console.WriteLine("Количество букв в имени = " + name.Length);
            Console.WriteLine("Само имя: " + name);
        }
    }

    //4
    enum PartOfDay //перечисление 
    {
        PM = 1, AM
    }
    class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        PartOfDay Part; //добавляем перечисление в структуру 

        public Time() { }
        public Time(int h, int m, int s, int p)
        {
            Hours = h;
            Minutes = m;
            Seconds = s;
            Part = (PartOfDay)p;
        }
        public override string ToString() //переопределяем метод 
        {
            return "Время - " + Hours + ':' + Minutes + ':' + Seconds + ' ' + Part;
        }
    }
    
    }
