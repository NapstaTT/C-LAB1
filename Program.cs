using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            while (true)
            {
                Console.WriteLine("Введите номер задания от 1 до 4 или 0 для выхода");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 0: Environment.Exit(0); break;
                    case 1: pupupu(x); break;
                    case 2: pupupu(x); break;
                    case 3: pupupu(x); break;
                    case 4: pupupu(x); break;
                    default: Console.WriteLine("Номер задания введён неверно"); break;
                }
            }
        }
        public static void pupupu(int x)
        {
            Console.WriteLine("Выберите номер метода: 2, 4, 6, 8, 10 или -1 для возврата к выбору задания");
            int y;
            y = Convert.ToInt32(Console.ReadLine());
            Program job = new Program();
            switch (x)
            {
                case 1:
                    {
                        switch (y)
                        {
                            case -1: 
                                {
                                    Main(null); break; 
                                }
                            case 2: 
                                { 
                                    Console.WriteLine("Введите число имеющее больше двух знаков");
                                    Console.WriteLine("Сумма двух последних знаков :" + job.sumLastNums(Convert.ToInt32(Console.ReadLine())));
                                    break;
                                }
                            case 4:
                                {

                                    Console.WriteLine("Введите число");
                                    Console.WriteLine("Положительность числа - " + job.isPositive(Convert.ToInt32(Console.ReadLine())));
                                    break;
                                }
                            case 6:
                                { 
                                    Console.WriteLine("Введите символ");
                                    Console.WriteLine("Регистр верхний - " + job.isUpperCase(Convert.ToChar(Console.ReadLine())));
                                    break;
                                }
                            case 8:
                                {
                                    Console.WriteLine("Введите последовательно 2 числа для проверки");
                                    Console.WriteLine("Одно число является делителем другого - " + job.isDivisorr(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                                    break;
                                }
                            case 10:
                                {
                                    Console.WriteLine("Введите последовательно два числа");
                                    Console.WriteLine("Сумма последних цифр: " + job.lastNumSum(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Неверный номер задания.");
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        switch (y)
                        {
                            case 2:
                                {
                                    Console.WriteLine("Введите последовательно два числа для деления");
                                    Console.WriteLine("Результат деления :" + job.safeDiv(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Введите последовательно числа для сравнения");
                                    Console.WriteLine(job.makeDecision(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine("Введите последовательно три числа");
                                    Console.WriteLine(job.sum3(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                                    break;
                                }
                            case 8:
                                {
                                    Console.WriteLine("Введите количество лет");
                                    Console.WriteLine(job.age(Convert.ToInt32(Console.ReadLine())));
                                    break;
                                }
                            case 10:
                                {
                                    Console.WriteLine("Введите день недели");
                                    job.printDays(Convert.ToString(Console.ReadLine()));
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Неверный номер задания.");
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        switch (y)
                        {
                            case 2:
                                {
                                    Console.WriteLine("Введите число");
                                    Console.WriteLine("Числа от нуля до x :" + job.reverseListNums(Convert.ToInt32(Console.ReadLine())));
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Введите последовательно число и его степень");
                                    Console.WriteLine("Результат - "+job.pow(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine("Введите число для проверки");
                                    Console.WriteLine(job.equalNum(Convert.ToInt32(Console.ReadLine())));
                                    break;
                                }
                            case 8:
                                {
                                    Console.WriteLine("Введите число столбцов");
                                    job.leftTriangle(Convert.ToInt32(Console.ReadLine()));
                                    break;
                                }
                            case 10:
                                {
                                    job.guessGame();
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Неверный номер задания.");
                                    break;
                                }
                        }
                        break;
                    }
                case 4:
                    {
                        switch (y)
                        {
                            case 2:
                                {
                                    Console.WriteLine("Введите число х");
                                    int a=int.Parse(Console.ReadLine());
                                    Console.Write("Введите элементы массива (через пробел): ");
                                    Console.WriteLine("Количество вхождений x :" + job.findLast(job.writing(Console.ReadLine()), a));
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Введите число х");
                                    int a = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Введите позицию");
                                    int pos = int.Parse(Console.ReadLine());
                                    Console.Write("Введите элементы массива (через пробел): ");
                                    Console.WriteLine("Отредактированный массив" + job.add(job.writing(Console.ReadLine()), a, pos));
                                    break;
                                }
                            case 6:
                                {
                                    Console.Write("Введите элементы массива (через пробел): ");
                                    job.reverse(job.writing(Console.ReadLine()));
                                    break;
                                }
                            case 8:
                                {
                                    Console.Write("Введите элементы первого массива (через пробел): ");
                                    int[] arr1= job.writing(Console.ReadLine());
                                    Console.Write("Введите элементы второго массива (через пробел): ");
                                    Console.WriteLine("Объеденённый массив" + job.concat(arr1,job.writing(Console.ReadLine())));
                                    break;
                                }
                            case 10:
                                {
                                    Console.Write("Введите элементы массива (через пробел): ");
                                    Console.WriteLine("Отредактированный массив" + job.deleteNegative(job.writing(Console.ReadLine())));
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Неверный номер задания.");
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
        public int sumLastNums(int x)
        {
            return ((x % 10) + ((x / 10) % 10));
        }
        public bool isPositive(int x)
        {
            return (x >= 0);
        }
        public bool isUpperCase(char x)
        {
            return (char.IsUpper(x));
        }
        public bool isDivisorr(int a, int b)
        {
            return (a % b == 0 || b % a == 0);
        }
        public int lastNumSum(int a, int b)
        {
            b = a % 10 + b % 10;
            Console.WriteLine("Введите следующее число");
            b = b % 10 + int.Parse(Console.ReadLine())%10;

            Console.WriteLine("Введите следующее число");
            b = b % 10 + int.Parse(Console.ReadLine())%10;

            Console.WriteLine("Введите следующее число");
            b = b % 10 + int.Parse(Console.ReadLine())%10;
            return b;
        }
        public double safeDiv(int x, int y)
        {
            if (y == 0)
                return 0;
            else
                return (x / y);
        }
        public String makeDecision(int x, int y)
        {
            if (x == y)
                return (Convert.ToString(x) + "==" + Convert.ToString(y));
            if (x > y)
                return (Convert.ToString(x) + ">" + Convert.ToString(y));
            else
                return (Convert.ToString(x) + "<" + Convert.ToString(y));
        }
        public bool sum3(int x, int y, int z)
        {
            if (x + y == z || x + z == y || y + z == x)
                return true;
            else
                return false;
        }
        public String age(int x)
        {
            if (x % 10 == 1)
                return (Convert.ToString(x) + "год");
            else
            {
                if (x % 10 == 2 || x % 10 == 3 || x % 10 == 4)
                    return (Convert.ToString(x) + "года");
                else
                    return (Convert.ToString(x) + "лет");
            }
        }
        public void printDays(String x)
        {
            switch (x.ToLower())
            {
                case "понедельник":
                    Console.WriteLine("Понедельник");
                    Console.WriteLine("Вторник");
                    Console.WriteLine("Среда");
                    Console.WriteLine("Четверг");
                    Console.WriteLine("Пятница");
                    Console.WriteLine("Суббота");
                    Console.WriteLine("Воскресенье");
                    break;
                case "вторник":
                    Console.WriteLine("Вторник");
                    Console.WriteLine("Среда");
                    Console.WriteLine("Четверг");
                    Console.WriteLine("Пятница");
                    Console.WriteLine("Суббота");
                    Console.WriteLine("Воскресенье");
                    break;
                case "среда":
                    Console.WriteLine("Среда");
                    Console.WriteLine("Четверг");
                    Console.WriteLine("Пятница");
                    Console.WriteLine("Суббота");
                    Console.WriteLine("Воскресенье");
                    break;
                case "четверг":
                    Console.WriteLine("Четверг");
                    Console.WriteLine("Пятница");
                    Console.WriteLine("Суббота");
                    Console.WriteLine("Воскресенье");
                    break;
                case "пятница":
                    Console.WriteLine("Пятница");
                    Console.WriteLine("Суббота");
                    Console.WriteLine("Воскресенье");
                    break;
                case "суббота":
                    Console.WriteLine("Суббота");
                    Console.WriteLine("Воскресенье");
                    break;
                case "воскресенье":
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Это не день недели");
                    break;
            }//visual studio не разрешил использовать fall-through :(
        }
        public String reverseListNums(int x)
        {
            string d = "";
            for (int i = x; i >= 0; i--)
            {
                d += i.ToString() + " ";
            }
            return d;
        }
        public int pow(int x, int y)
        {
            int s = x;
            y = y - 1;
            for (int i = y; i >= 1; i--)
            {
                s *= x;
            }
            return s;
        }
        public bool equalNum(int x)
        {
            if (x == 0)
                return true;
            int lastDigit = x % 10;
            x /= 10;
            while (x != 0)
            {
                if (x % 10 != lastDigit)
                    return false;
                x /= 10;
            }
            return true;
        }
        public void leftTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void guessGame()
        {
            Random random = new Random();
            int targetNumber = random.Next(0, 10);
            int attempts = 0;

            while (true)
            {
                Console.Write("Введите число от 0 до 9: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int userNumber))
                {
                    attempts++;

                    if (userNumber == targetNumber)
                    {
                        Console.WriteLine("Вы угадали!");
                        Console.WriteLine($"Вы отгадали число за " + attempts + " попытки");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Вы не угадали, попробуйте еще раз.");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное значение. Попробуйте еще раз.");
                }
            }
        }
        public int findLast(int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        public int[] add(int[] arr, int x, int pos)
        {
            int[] result = new int[arr.Length + 1];
            for (int i = 0; i < pos; i++)
            {
                result[i] = arr[i];
            }
            result[pos] = x;
            for (int i = pos; i < arr.Length; i++)
            {
                result[i + 1] = arr[i];
            }
            return result;
        }
        public void reverse(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
        public int[] concat(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                result[i + arr1.Length] = arr2[i];
            }
            return result;
        }
        public int[] deleteNegative(int[] arr)
        {
            int positiveCount = 0;
            foreach (int num in arr)
            {
                if (num >= 0)
                {
                    positiveCount++;
                }
            }
            int[] result = new int[positiveCount];
            int resultIndex = 0;
            foreach (int num in arr)
            {
                if (num >= 0)
                {
                    result[resultIndex++] = num;
                }
            }
            return result;
        }
        public int[] writing(String enter)
        {
            string[] elements = enter.Split(' ');
            int[] arr = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                arr[i] = int.Parse(elements[i]);
            }
            return arr;
        }
    }
}
