using Subjects;
using System;

class Program
{
    static void Main()
    {
        Subjects.Math clsmath = new Subjects.Math();

        while (true)
        {
            Console.WriteLine("\nКАЛЬКУЛЯТОР");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1  - Сложение (sum)");
            Console.WriteLine("2  - Вычитание (subtraction)");
            Console.WriteLine("3  - Умножение (mult)");
            Console.WriteLine("4  - Деление (div)");
            Console.WriteLine("5  - Корень (root)");
            Console.WriteLine("6  - Возведение во 2 степень (square)");
            Console.WriteLine("7  - Возведение в 3 степень (cube)");
            Console.WriteLine("8  - Процент (percent)");
            Console.WriteLine("9  - Модуль числа (abs)");
            Console.WriteLine("10 - Факториал (factorial)");
            Console.WriteLine("11 - Логарифм (log)");
            Console.WriteLine("12 - Среднее арифметическое (average)");
            Console.Write("Ваш выбор: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Ошибка: введите число!");
                continue;
            }

            bool needTwoNumbers = (choice == 1 || choice == 2 || choice == 3 ||
                                   choice == 4 || choice == 5 || choice == 8 ||
                                   choice == 11 || choice == 12);

            Console.Write("Введите первое число: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Ошибка: введите целое число!");
                continue;
            }

            int num2 = 0;
            if (needTwoNumbers)
            {
                Console.Write("Введите второе число: ");
                if (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Ошибка: введите целое число!");
                    continue;
                }
            }

            Console.WriteLine("Результат");

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"sum: {clsmath.sum(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"subtraction: {clsmath.subtraction(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"mult: {clsmath.mult(num1, num2)}");
                    break;
                case 4:
                    Console.WriteLine($"div: {clsmath.div(num1, num2)}");
                    break;
                case 5:
                    Console.WriteLine($"root: {clsmath.root(num1, num2)}");
                    break;
                case 6:
                    Console.WriteLine($"square: {clsmath.square(num1)}");
                    break;
                case 7:
                    Console.WriteLine($"cube: {clsmath.cube(num1)}");
                    break;
                case 8:
                    Console.WriteLine($"{num1}% от {num2} = {clsmath.percent(num1, num2)}");
                    break;
                case 9:
                    Console.WriteLine($"abs: {clsmath.abs(num1)}");
                    break;
                case 10:
                    Console.WriteLine($"factorial: {clsmath.factorial(num1)}");
                    break;
                case 11:
                    Console.WriteLine($"log: {clsmath.log(num1, num2)}");
                    break;
                case 12:
                    Console.WriteLine($"average: {clsmath.average(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Неверный выбор! Попробуйте снова.");
                    break;
            }
        }
    }
}