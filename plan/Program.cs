using System;
using System.Collections.Generic;

namespace Planirovshik
{
    class Dela
    {
        public string nazva;
        public string date;
        public string time;
        public string description;
    }
    class Program
    {
        List<Dela> spisok = new List<Dela>();
        int j = -1;
        int p;
        public int act;
        public int Act
        {
            get
            {
                return act;
            }
            set
            {
                if (value == 1)
                {
                    Console.WriteLine();
                    if (spisok.Count == 0)
                        Console.WriteLine("Список ваших дел пуст");
                    else
                        for (int i = 0; i < spisok.Count; i++)
                            Console.WriteLine(i + 1 + "). " + spisok[i].nazva);
                }
                if (value == 2)
                {
                    Console.WriteLine();
                    spisok.Add(new Dela());
                    j++;
                    Console.Write("Введите название дела: ");
                    spisok[j].nazva = Console.ReadLine();
                    Console.Write("Введите дату: ");
                    spisok[j].date = Console.ReadLine();
                    Console.Write("Введите время: ");
                    spisok[j].time = Console.ReadLine();
                    Console.Write("Введите описание: ");
                    spisok[j].description = Console.ReadLine();
                }
                if (value == 3)
                {
                    Console.WriteLine();
                    if (spisok.Count == 0)
                        Console.WriteLine("Список ваших дел пуст");
                    else
                    {
                        Console.Write("Введите номер дела: ");
                        p = Convert.ToInt32(Console.ReadLine());
                        if (spisok.Count < p)
                        {
                            Console.WriteLine();
                            Console.WriteLine("В вашем списке всего " + spisok.Count + " дел");
                        }
                        else
                            spisok.RemoveAt(p - 1);
                        
                    }
                }
                if (value == 4)
                {
                    Console.WriteLine();
                    if (spisok.Count == 0)
                        Console.WriteLine("Список ваших дел пуст");
                    else
                    {
                        Console.Write("Введите номер дела: ");
                        p = Convert.ToInt32(Console.ReadLine());
                        if (spisok.Count < p)
                        {
                            Console.WriteLine();
                            Console.WriteLine("В вашем списке всего " + spisok.Count + " дел");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Название: " + spisok[p - 1].nazva);
                            Console.WriteLine("Дата: " + spisok[p - 1].date);
                            Console.WriteLine("Время: " + spisok[p - 1].time);
                            Console.WriteLine("Описание: " + spisok[p - 1].description);
                        }
                    }
                }
                if (value == 5)
                {
                    Console.WriteLine();
                    if (spisok.Count == 0)
                        Console.WriteLine("Список ваших дел пуст");
                    else
                    {
                        
                        Console.Write("Введите номер дела: ");
                        p = Convert.ToInt32(Console.ReadLine());
                        if (spisok.Count < p)
                        {
                            Console.WriteLine();
                            Console.WriteLine("В вашем списке всего " + spisok.Count + " дел");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.Write("Введите название: ");
                            spisok[p - 1].nazva = Console.ReadLine();
                            Console.Write("Введите дату: ");
                            spisok[p - 1].date = Console.ReadLine();
                            Console.Write("Введите время: ");
                            spisok[p - 1].time = Console.ReadLine();
                            Console.Write("Введите описание: ");
                            spisok[p - 1].description = Console.ReadLine();
                        }
                    }
                }
                if (value == 6)
                {
                    Console.WriteLine();
                    if (spisok.Count == 0)
                        Console.WriteLine("Список ваших дел пуст");
                    else
                    {
                        for (int i = 0; i < spisok.Count; i++)
                            spisok.RemoveAt(i);
                        Console.WriteLine("Все дела удалены");
                    }
                }
            }
        }
        public static void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1 - Показать список дел");
            Console.WriteLine("2 - Добавить пункт в список");
            Console.WriteLine("3 - Удалить пункт из списка");
            Console.WriteLine("4 - Открыть подробности дела");
            Console.WriteLine("5 - Изменить дело");
            Console.WriteLine("6 - Удалить все дела");
            Console.WriteLine("Для выхода из программы нажмите Enter");
            Console.WriteLine();
            Console.Write("Ввод: ");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу Планировщик!");
            Print();
            Program vybor = new Program();
            while (true)
            {
                try
                {
                    vybor.Act = Convert.ToInt32(Console.ReadLine());
                    Print();
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

    }
}