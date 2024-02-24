using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Практикум 8 - Сакары Анны";

            //практикум по счёту в moodle: 11
            //Задача 1. Используя двузначное случайное число,
            //вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.

            Random rnd = new Random();
            int num = rnd.Next(10, 99);
            Console.WriteLine($"{num} - ваше случайно число");
            string word = num % 2 == 0 ? "чётное" : "нечётное";
            Console.WriteLine($"-{word}");
            Console.ReadKey();

            //Задача 2. Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.
            Random day = new Random();
            int week = day.Next(1, 7);
            switch (week)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
            Console.ReadKey();


            //Задача 3. Даны три целых положительных числа. Если все они четные, каждое число уменьшить в 2 раза, если хотя бы одно из них четное,
            //увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.
            Console.Write("Введите num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите num2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Введите num3: ");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 <= 0 | num2 <= 0 | num3 <= 0)
            {
                Console.WriteLine("error");
            }
            else if (num1 % 2 == 0 & num2 % 2 == 0 & num3 % 2 == 0)
            {
                Console.WriteLine($"num1 = {num1 / 2}, num2 = {num2 / 2}, num3 = {num3 / 2}");
            }
            else if (num1 % 2 != 0 & num2 % 2 != 0 & num3 % 2 != 0)
            {
                Console.WriteLine($"num1 = {num1 + 1}, num2 = {num2 + 1}, num3 = {num3 + 1}");
            }
            else
            {
                Console.WriteLine($"num1 = {num1 * 2}, num2 = {num2 * 2}, num3 = {num3 * 2}");
            }
            Console.ReadKey();


            //Задача 4. Проведен тест, оцениваемый в целочисленных баллах от нуля до ста.
            //Вывести на экран оценку тестируемого в зависимости от набранного количества баллов:
            //от 90 до 100 – «отлично», от 70 до 89 – «хорошо», от 50 до 69 – «удовлетворительно», менее 50 – «неудовлетворительно».

            Console.Write("Введите кол-во баллов: ");
            int point = int.Parse(Console.ReadLine());
            if (point >= 90 & point <= 100)
                Console.WriteLine("Отлично");
            else if (point >= 70 & point <= 89)
                Console.WriteLine("Хорошо");
            else if (point >= 50 & point <= 69)
                Console.WriteLine("Удовлетворительно");
            else if (point < 50 & point >= 0)
                Console.WriteLine("Неудовлетворительно");
            else 
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();

            //Практикум 8
            //    //Задача 5. Дан признак геометрической фигуры на плоскости: к – круг, п – прямоугольник, т - треугольник.
            //    //Вывести на экран периметр и площадь заданной фигуры (данные, необходимые для расчетов, запросить у пользователя).
            Console.Write("Введите первую букву фигуры, признак которой хотите найти. к – круг, п – прямоугольник, т - треугольник. ");
            char d = char.Parse(Console.ReadLine());
            switch (d)
            {
                case 'к':
                    Console.Write("Введите радиус круга: ");//R
                    double R = double.Parse(Console.ReadLine());
                    double Skr, Ppr, Spr, Ptr, Str, Ppol;
                    Skr = 3.14 * R * 2;//площадь круга
                    Console.WriteLine($"Площадь круга равна: {Skr}");
                    break;
                case 'п':
                    Console.Write("Введите длину прямоугольника: ");//length
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Введите ширину прямоугольника: ");//width
                    double width = double.Parse(Console.ReadLine());
                    Ppr = (length + width) * 2;//периметр прямоугольника
                    Spr = length * width;//площадь прямоугольника
                    Console.WriteLine($"Периметр прямоугольника равен: {Ppr}; \nПлощадь прямоугольника равна: {Spr}");
                    break;
                case 'т':
                    Console.Write("Введите сторону 1 треугольника: ");//a
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Введите сторону 2 треугольника: ");//b
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Введите сторону 3 треугольника: ");//c
                    double c = double.Parse(Console.ReadLine());
                    Ptr = a + b + c;//периметр треугольника
                    Ppol = Ptr / 2;//полупериметр треугольника
                    Str = Math.Sqrt(Ppol * (Ppol - a) * (Ppol - b) * (Ppol - c));//площадь треугольника
                    Console.WriteLine($"Периметр треугольника = {Ptr}, Площадь треугольника = {Str:f2}");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();

            ////Задача 6. Написать приложение,
            ////которое позволяет вычислить сумму страхового взноса (SV) для автомобиля. Входные данные будут вводиться с клавиатуры:
            Console.Write("Введите марку автомобиля: ");
            string MA = Console.ReadLine();
            Console.Write("Введите нужный вам срок страхования: ");
            int months = int.Parse(Console.ReadLine());
            double sum = 50, kt = 0, SV;//kt - процент надбавки; sum - сумма; SV - страховой взнос.
            if (months < 3)
            {
                kt = 10;//%
                SV = sum * months * (1 + kt / 100);
                Console.Write($"Ваш автомобиль марки {MA} был застрахован. \nСумма страхового взноса составила {SV} руб.");
            }
            else if (months >= 3 & months < 6)
            {
                kt = 8;//%
                SV = sum * months * (1 + kt / 100);
                Console.Write($"Ваш автомобиль марки {MA} был застрахован. \nСумма страхового взноса составила {SV} руб.");
            }
            else if (months >= 6 & months < 12)
            {
                kt = 5;//%
                SV = sum * months * (1 + kt / 100);
                Console.Write($"Ваш автомобиль марки {MA} был застрахован. \nСумма страхового взноса составила {SV} руб.");
            }
            else
            {
                Console.WriteLine("ошибка");
            }
            Console.ReadKey();



        }
    }
}
