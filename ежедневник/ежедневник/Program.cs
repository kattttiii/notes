using Notes;
using System;
using System.Collections.Generic;

namespace ежедневник
{
    class NotesApp
    {
        public static Dictionary<string, List<Notess>> Config = new Dictionary<string, List<Notess>>
    {
        {"25.10.2023", new List<Notess>{
            new Notess("Приехать в колледж", "Подать доки на отчисление", "25.10.2023", "11:00")
        } },
        {"26.10.2023", new List<Notess>{
            new Notess("Уборка", "Моем пол и вытираем пыль", "26.10.2023", "12:00")
        } },
        {"27.10.2023", new List<Notess>{
            new Notess("Сходить на тренировку", "Сделать кардио", "27.10.2023", "12:00")
        } },
        {"28.10.2023", new List<Notess>{
             new Notess("Сходить в кино", "Смотрим астрал", "28.10.2023", "21:00")
        } },
        {"29.10.2023", new List<Notess>{
             new Notess("Релакс", "Смотрим сериальчик", "29.10.2023", "22:00")
        } },
        {"30.10.2023", new List<Notess>{
             new Notess("День рождения мамы", "Купить цветы и забрать подарок", "30.10.2023", "16:00")
        } },
         {"31.10.2023", new List<Notess>{
             new Notess("Поход в театр", "Портрет Дориана Грея", "31.10.2023", "12:00")
        } },

    };

        public static List<Notess> NotesConfigList = new List<Notess>();
        public static List<string> DateList = new List<string>()
    {
        "25.10.2023",
        "26.10.2023",
        "27.10.2023",
        "28.10.2023",
        "29.10.2023",
        "30.10.2023",
        "31.10.2023"
    };
        public static int SelectedNote = 0;
        public static int SlectedList = 0;
        public static bool ConfihUpdate = false;
        public static void Main()
        {
            SelectedDate(DateList[SelectedNote]);
            int pos = 1;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (SlectedList == 0) return;
                    if (pos == 1) return;
                    pos--;
                    SlectedList--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    SlectedList++;
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (SelectedNote == 0) return;
                    SelectedDate(DateList[SelectedNote--]);
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (SelectedNote == DateList.Count - 1) return;
                    SelectedDate(DateList[SelectedNote++]);
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    ConfihUpdate = true;
                    OpenSelectedPage(SlectedList);
                    return;
                }

                SelectedDate(DateList[SelectedNote]);
                Console.SetCursorPosition(0, pos);

                Console.WriteLine("->");
            }

        }

        public static void SelectedDate(string date)
        {
            Console.Clear();
            Console.WriteLine($"Дата: {date}");
            var i = 1;
            int top = 1, left = 2;
            foreach (var item in Config[date])
            {
                Console.SetCursorPosition(left, top++);
                Console.WriteLine($"{i++}.{item.Name}");
            }
            return;
        }

        public static void OpenSelectedPage(int name)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            while (key.Key != ConsoleKey.Escape)
            {
                Console.WriteLine($"---------------- {Config[DateList[SelectedNote]][name].Name} ------------------");
                Console.WriteLine($"Задача: {Config[DateList[SelectedNote]][name].Description}");
                Console.WriteLine($"Дата: {Config[DateList[SelectedNote]][name].Date} {Config[DateList[SelectedNote]][name].Time}");

                Console.ReadLine();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
            }
        }

    }
}

