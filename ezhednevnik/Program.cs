namespace ezhednevnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime();
            data = DateTime.Today;

            string adata = data.ToShortDateString();
            Date(data, adata);

            int b = 1;
            ConsoleKeyInfo a;
            a = Console.ReadKey();
            Information(data, a, adata);
            Console.Clear();

            while (b == 1)
            {

                if (a.Key == ConsoleKey.RightArrow)
                {
                    data = data.AddDays(1);
                }
                if (a.Key == ConsoleKey.LeftArrow)
                {
                    data = data.AddDays(-1);
                }

                adata = data.ToShortDateString();
                Date(data, adata);
                Information(data, a, adata);
                a = Console.ReadKey();
                Console.Clear();
            }

        }

        static void Date(DateTime data, string adata)
        {
            
            if (data.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine(" Понедельник " + adata);
            }
            if (data.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine(" Вторник " + adata);
            }
            if (data.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine(" Среда " + adata);
            }
            if (data.DayOfWeek == DayOfWeek.Thursday)
            {
                Console.WriteLine(" Четверг " + adata);
            }
            if (data.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine(" Пятница " + adata);
            }
            if (data.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine(" Суббота (Выходной день) " + adata);
            }
            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine(" Воскресенье (Выходной день) " + adata);
            }
        }
        static int str(ConsoleKeyInfo a, int p)
        {

            if (a.Key == ConsoleKey.DownArrow)
            {
                p++;
            }
            if (a.Key == ConsoleKey.UpArrow)
            {
                p--;
            }

            if (p == 0)
            {
                p = 1;
            }
            return p;

        }

        static void Information(DateTime data, ConsoleKeyInfo a, string adata)
        {
            ezhd ez = new ezhd();
            ezhd ezh = new ezhd();
            int p = 1;

            if (adata == "20.10.2022")
            {
                ez.Title = "Получить оценку по истории";

                ezh.Title = "Пойти домой";

                Console.SetCursorPosition(2, 1);
                Console.WriteLine(ez.Title);
                Console.SetCursorPosition(2, 2);
                Console.WriteLine(ezh.Title);
                int f = 0;

                if (a.Key == ConsoleKey.DownArrow)
                {
                    while (f == 0)
                    {
                        Console.Clear();
                        int d = str(a, p);
                        Date(data, adata);
                        Console.SetCursorPosition(2, 1);
                        Console.WriteLine(ez.Title);
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine(ezh.Title);
                        Console.SetCursorPosition(0, d);
                        Console.WriteLine("->");

                        a = Console.ReadKey();
                        if (a.Key == ConsoleKey.Enter)
                        {
                            if (d == 1)
                            {
                                ez.Title = "Получить оценку по истории";
                                ez.Information = "Выступить с докладом";
                                ez.Time = "12:15";
                                Viv(a, ez);
                            }
                            if (d == 2)
                            {
                                ez.Title = "Пойти домой";
                                ez.Information = "Взять одежду из гардероба и проверить все вещи в рюкзаке на их наличие";
                                ez.Time = "15:30";
                                Viv(a, ez);
                            }
                        }
                        if (a.Key == ConsoleKey.Escape)
                        {
                            f++;
                        }
                    }

                }
            }
            if (adata == "22.10.2022")
            {
                ez.Title = "Проснуться";

                ezh.Title = "Сделать домашнее задание";

                Console.SetCursorPosition(2, 1);
                Console.WriteLine(ez.Title);
                Console.SetCursorPosition(2, 2);
                Console.WriteLine(ezh.Title);
                int f = 0;

                if (a.Key == ConsoleKey.DownArrow)
                {
                    while (f == 0)
                    {
                        Console.Clear();
                        int d = str(a, p);
                        Date(data, adata);
                        Console.SetCursorPosition(2, 1);
                        Console.WriteLine(ez.Title);
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine(ezh.Title);
                        Console.SetCursorPosition(0, d);
                        Console.WriteLine("->");

                        a = Console.ReadKey();
                        if (a.Key == ConsoleKey.Enter)
                        {
                            if (d == 1)
                            {
                                ez.Title = "Проснуться";
                                ez.Information = "Проснуться, умыться и застелить постель и приготовить себе что-то на завтрак";
                                ez.Time = "9:00";
                                Viv(a, ez);
                            }
                            if (d == 2)
                            {
                                ez.Title = "Сделать домашнее задание";
                                ez.Information = "Открыть блокнот, посмотреть что было задано и выполнить задания";
                                ez.Time = "12:00";
                                Viv(a, ez);
                            }
                        }
                        if (a.Key == ConsoleKey.Escape)
                        {
                            f++;
                        }
                    }

                }
            }
            if (adata == "23.10.2022")
            {
                ez.Title = "Погулять";
                ez.Information = "Написать другу, договориться о встрече и затем встретиться в назначенном месте и в назначенное время";
                ez.Time = "14:00";

                Console.SetCursorPosition(2, 1);
                Console.WriteLine(ez.Title);


                if (a.Key == ConsoleKey.Enter)
                {
                    Viv(a, ez);
                }
            }
            if (adata == "25.10.2022")
            {
                ez.Title = "Подготовиться к практической работе по дискретной математике";
                ez.Information = "Открыть тетрадь по дискретной математике и повторить нужные лекции";
                ez.Time = "17:00";

                Console.SetCursorPosition(2, 1);
                Console.WriteLine(ez.Title);


                if (a.Key == ConsoleKey.Enter)
                {
                    Viv(a, ez);
                }
            }
            if (adata == "03.12.2022")
            {
                ez.Title = "День рождения!";
                ez.Information = "Получить поздравления и подарки от друзей";
                ez.Time = "10:00";

                Console.SetCursorPosition(2, 1);
                Console.WriteLine(ez.Title);


                if (a.Key == ConsoleKey.Enter)
                {
                    Viv(a, ez);
                }
            }

        }
        static void Viv(ConsoleKeyInfo a, ezhd ez)
        {
            List<ezhd> list = new List<ezhd>();
            list.Add(ez);
            int d = 1;
            while (d == 1)
            {
                Console.Clear();
                foreach (ezhd info in list)
                {
                    Console.WriteLine(info.Title);
                    Console.WriteLine(info.Information);
                    Console.WriteLine(info.Time);
                    Console.WriteLine("<><><><><><><><>");
                }

                a = Console.ReadKey();

                if (a.Key == ConsoleKey.Escape)
                {
                    d = 0;
                }

            }
        }
    }
}