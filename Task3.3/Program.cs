using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывод строки-описания введенного возраста из указанного диапазона
            Console.Write("Введите возраст в годах (20-69): ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Проверка введенного возраста на соответствие допустимому диапазону и вывод результата
            if (age>=20&&age<=69) 
            {
                // Вывод текстом десятков лет
                switch ((int)(age/10))
                {
                    case 2:
                        {
                            Console.Write("Двадцать ");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Тридцать ");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Сорок ");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Пятьдесят ");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("Шестьдесят ");
                            break;
                        }
                }
                // Вывод текстом единиц лет с согласованием числа со словом год.
                switch (age-(int)(age/10)*10)
                {
                    case 1:
                        {
                            Console.WriteLine("один год");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("два года");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("три года");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("четыре года");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("пять лет");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("шесть лет");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("семь лет");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("восемь лет");
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("девять лет");
                            break;
                        }
                    default:
                        Console.WriteLine("лет");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введен возраст, выходящий за пределы указанного диапазона.");
            }

            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
