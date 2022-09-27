
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1. Вывести на экран число e");
            Console.WriteLine(Math.Round((Math.E), 1));

            Console.WriteLine("Задача 2.Вывести на экран числа 50 и 10 одно под другим.");
            Console.WriteLine("50");
            Console.WriteLine("10");

            Console.WriteLine("Задача 3. Составить программу вывода на экран «столбиком» четырех любых чисел.");
            Console.WriteLine("введите первое число");
            int num3_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int num3_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите третье число");
            int num3_3 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите четвертое число");
            int num3_4 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + num3_1);
            Console.WriteLine(num3_2);
            Console.WriteLine(num3_3);
            Console.WriteLine(num3_4);

            Console.WriteLine("Задача 4.Пользователь вводит число. Выведите на экран число, которое больше введенного 10.");
            int num4_1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num4_1 + 10);

            Console.WriteLine("Задача 5.Дана сторона квадрата. Найти его периметр.");
            Console.WriteLine("введите сторону квадрата");
            int num5_1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num5_1 * 4);

            Console.WriteLine("Задача 6.Дан радиус окружности. Найти длину окружности и площадь круга.");
            Console.WriteLine("введите радиус окружности");
            int radius = int.Parse(Console.ReadLine());
            double dlina = radius * 2 * 3.14;
            double S = radius * 3.14 * radius;

            Console.Write("Длина окружности:");
            Console.WriteLine(dlina);
            Console.Write("Площадь окружности:");
            Console.WriteLine(S);

            Console.WriteLine("Задача 7.Найти значение y=cos(x)");
            Console.Write("введите x: ");
            double x = float.Parse(Console.ReadLine());
            double y = Math.Cos(x);
            Console.WriteLine($"y = {y}");

            Console.WriteLine("Задача 8.Даны основания и высота равнобедренной трапеции. Найти ее периметр.");
            Console.WriteLine("введите большее основание трапеции");
            int osnmax = int.Parse(Console.ReadLine());
            Console.WriteLine("введите меньшее основание трапеции");
            int osnmin = int.Parse(Console.ReadLine());
            Console.WriteLine("введите высоту трапеции");
            int h8 = int.Parse(Console.ReadLine());
            int a = (osnmax - osnmin) / 2;
            double storonatrap = Math.Sqrt(a * a + h8 * h8);
            Console.WriteLine(storonatrap * storonatrap + osnmin + osnmax);

            Console.WriteLine("Задача 9. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.");
            Console.Write("введите массу конфет: ");
            double mass_k = float.Parse(Console.ReadLine());
            Console.Write("введите массу печенья: ");
            double mass_p = float.Parse(Console.ReadLine());
            Console.Write("введите массу яблок: ");
            double mass_a = float.Parse(Console.ReadLine());
            Console.Write("введите стоимость кг конфет: ");
            double stoim_k = double.Parse(Console.ReadLine());
            Console.Write("введите стоимость кг печенья: ");
            double stoim_p = double.Parse(Console.ReadLine());
            Console.Write("введите стоимость кг яблок: ");
            double stoim_a = double.Parse(Console.ReadLine());
            double stoimost = mass_k * stoim_k + mass_p * stoim_p + mass_p * stoim_a;
            Console.Write($"Стоимость всей покупки: {stoimost}");

            Console.WriteLine("Задача 10.Напишите программу, выводит на экран три строки \"Мир\", \"Труд\" и \"Май\"");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("    Труд");
            Console.WriteLine("          Май");

            Console.WriteLine("Задача 11.Программа просит пользователя ввести 2 числовые переменные.");
            Console.WriteLine("введите 2 числа: ");
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            Console.WriteLine(second);
            Console.WriteLine(first);

            Console.WriteLine("Задача 13.Вводимому числу должно предшествовать сообщение «Вы ввели число».");
            Console.WriteLine("Вы ввели число:");
            string vvchislo = Console.ReadLine();
            Console.WriteLine($"Ваше число: {vvchislo}");

            Console.WriteLine("Задача 14.Составить программу вывода на экран следующей информации:");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");

            Console.WriteLine("Задача 15.Составить программу вывода на экран «столбиком» четырех случайных чисел.");
            Random num_15 = new Random();
            int num15_1 = num_15.Next();
            int num15_2 = num_15.Next();
            int num15_3 = num_15.Next();
            int num15_4 = num_15.Next();
            Console.WriteLine(num15_1);
            Console.WriteLine(num15_2);
            Console.WriteLine(num15_3);
            Console.WriteLine(num15_4);

            Console.WriteLine("Задача 16.Найти корни квадратного уравнения");
            Console.Write("введите коэффициент а: ");
            float aa = int.Parse(Console.ReadLine());
            Console.Write("введите коэффициент b: ");
            float b = int.Parse(Console.ReadLine());
            Console.Write("ведите коэффициент с: ");
            float c = int.Parse(Console.ReadLine());
            Console.WriteLine("Корни:");
            float D = b * b - 4 * aa * c; ;
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * aa);
                double x2 = (-b - Math.Sqrt(D)) / (2 * aa);
                Console.WriteLine($"{x1}");
                Console.WriteLine($"{x2}");
            }
            if (D == 0)
            {
                double x1 = -b / (2 * aa);
                Console.WriteLine($"{x1}");
            }
            if (D < 0)
            {
                Console.WriteLine("нет решений");
            }

            Console.WriteLine("Задача 17. Даны два целых числа.");
            Console.Write("введите первое число:");
            int num17_1 = int.Parse(Console.ReadLine());
            Console.Write("введите второе число:");
            int num17_2 = int.Parse(Console.ReadLine());
            double sr_arifm = (num17_1 + num17_2) / 2;
            double sr_geom = Math.Sqrt(num17_1 * num17_2);
            Console.WriteLine($"среднее арифметическое:{sr_arifm}, среднее геометрическое:{sr_geom}");

            Console.WriteLine("Задача 18.Известны координаты на плоскости двух точек.");
            Console.Write("ведите координату х1: ");
            double x1_18 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y1: ");
            double y1_18 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату х2: ");
            double x2_18 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату у2: ");
            double y2_18 = double.Parse(Console.ReadLine());
            double ras = Math.Sqrt((x2_18 - x1_18) * (x2_18 - x1_18) + (y2_18 - y1_18) * (y2_18 - y1_18));
            Console.WriteLine($"Расстояние между точками: {ras}");

            Console.WriteLine("Задача 19.Составить программу обмена значениями");
            Console.WriteLine("введите число a:");
            double a_19 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите число b:");
            double b_19 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите число c:");
            double c_19 = double.Parse(Console.ReadLine());
            double k_19 = a_19;
            a_19 = b_19;
            b_19 = c_19;
            c_19 = k_19;
            Console.WriteLine($"Перестановка 1:{a_19} {b_19} {c_19}");

            Console.WriteLine("введите число a:");
            double a2_19 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите число b:");
            double b2_19 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите число c:");
            double c2_19 = double.Parse(Console.ReadLine());
            double k2_19 = a2_19;
            a2_19 = b2_19;
            b2_19 = c2_19;
            c2_19 = k2_19;
            Console.WriteLine($"Перестановка 1:{a2_19} {b2_19} {c2_19}");

            Console.WriteLine("Задача 20.С начала суток прошло n секунд.");
            Console.Write("Введите число секунд: ");
            int sec = int.Parse(Console.ReadLine());
            int hour20 = sec / 3600;
            int min20 = (sec % 3600) / 60;
            Console.WriteLine(min20);
            int sec20 = sec % 60;
            Console.WriteLine($"Полных часов с начала суток прошло:{hour20}, полных минут с начала часа прошло:{min20}, полных секунд с начала минуты прошло:{sec20}");


            Console.WriteLine("Задача 21. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?");
            Console.Write("Ответ: ");
            Console.WriteLine(543 / 130);


            Console.WriteLine("Задача 22. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.");
            Console.Write("введите трехзначное число: ");
            int chislo_22 = int.Parse(Console.ReadLine());
            int konech_chislo = (chislo_22 % 10) * 100 + (chislo_22 / 10) % 100;
            Console.WriteLine(chislo_22);

            Console.WriteLine("Задача 23. Найти число сотен и тысяч в числе");
            Console.Write("Введите четырехзначное число: ");
            int num_23 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число сотен: {num_23 / 100}");
            Console.WriteLine($"Число тысяч: {num_23 / 1000}");
        }
    }
}
