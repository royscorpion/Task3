using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывод строки-описания введенного числа из указанного диапазона
            Console.Write("Введите число в диапазоне 100-999: ");
            int iNumber = Convert.ToInt32(Console.ReadLine());

            // Проверка введенного числа на соответствие допустимому диапазону и вывод результата
            if (iNumber >= 100 && iNumber <= 999)
            {
                Console.Write("Введено число: ");
                // Вывод текстом третьего разряда числа
                switch (Math.DivRem(iNumber, 100, out iNumber))
                {
                    case 2:
                        {
                            Console.Write("Двести");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Триста");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Четыреста");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Пятьсот");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("Шестьсот");
                            break;
                        }
                    case 7:
                        {
                            Console.Write("Семьсот");
                            break;
                        }
                    case 8:
                        {
                            Console.Write("Восемьсот");
                            break;
                        }
                    case 9:
                        {
                            Console.Write("Девятьсот");
                            break;
                        }
                    default:
                        Console.Write("Сто");
                        break;
                }
                // Вывод текстом второго и первого разрядов числа
                switch (iNumber)
                {
                    // Вывод второго и первого разряда числа при втором разряде числа == 1
                    case 10:
                        {
                            Console.WriteLine(" десять");
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine(" одиннадцать");
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine(" двенадцать");
                            break;
                        }
                    case 13:
                        {
                            Console.WriteLine(" тринадцать");
                            break;
                        }
                    case 14:
                        {
                            Console.WriteLine(" четырнадцать");
                            break;
                        }
                    case 15:
                        {
                            Console.WriteLine(" пятнадцать");
                            break;
                        }
                    case 16:
                        {
                            Console.WriteLine(" шестнадцать");
                            break;
                        }
                    case 17:
                        {
                            Console.WriteLine(" семнадцать");
                            break;
                        }
                    case 18:
                        {
                            Console.WriteLine(" восемнадцать");
                            break;
                        }
                    case 19:
                        {
                            Console.WriteLine(" девятнадцать");
                            break;
                        }
                    default:
                        // Вывод второго разряда при втором разряде числа >1
                        switch (Math.DivRem(iNumber, 10, out iNumber))
                        {
                            case 2:
                                {
                                    Console.Write(" двадцать");
                                    break;
                                }
                            case 3:
                                {
                                    Console.Write(" тридцать");
                                    break;
                                }
                            case 4:
                                {
                                    Console.Write(" сорок");
                                    break;
                                }
                            case 5:
                                {
                                    Console.Write(" пятьдесят");
                                    break;
                                }
                            case 6:
                                {
                                    Console.Write(" шестьдесят");
                                    break;
                                }
                            case 7:
                                {
                                    Console.Write(" семьдесят");
                                    break;
                                }
                            case 8:
                                {
                                    Console.Write(" восемьдесят");
                                    break;
                                }
                            case 9:
                                {
                                    Console.Write(" девяносто");
                                    break;
                                }
                            default:
                                Console.Write("");
                                break;
                        }
                        // Вывод первого разряда числа при втором разряде >1
                        switch (iNumber)
                        {
                            case 1:
                                {
                                    Console.WriteLine(" один");
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine(" два");
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine(" три");
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine(" четыре");
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine(" пять");
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine(" шесть");
                                    break;
                                }
                            case 7:
                                {
                                    Console.WriteLine(" семь");
                                    break;
                                }
                            case 8:
                                {
                                    Console.WriteLine(" восемь");
                                    break;
                                }
                            case 9:
                                {
                                    Console.WriteLine(" девять");
                                    break;
                                }
                            default:
                                Console.WriteLine("");
                                break;
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введено число, выходящее за пределы указанного диапазона.");
            }

            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
