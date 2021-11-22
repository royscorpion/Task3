using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Поиск ближайшей точки из двух (B и C) к точке A, расположенных на числовой оси.
            #region Ввод исходных данных
            Console.WriteLine("Введите координаты трех точек, расположенных на одной числовой оси");
            Console.Write("A: ");
            double pointA = Convert.ToDouble(Console.ReadLine());
            Console.Write("B: ");
            double pointB = Convert.ToDouble(Console.ReadLine());
            Console.Write("C: ");
            double pointC = Convert.ToDouble(Console.ReadLine());
            double AB = 0, AC = 0;
            #endregion

            #region Поиск решения и вывод результатов
            if (pointA!=pointB)
            {
                if (pointA != pointC)
                {
                    if (pointB != pointC)
                    {
                        if ((AB = Math.Abs(pointA - pointB)) != (AC = Math.Abs(pointA - pointC)))
                        {
                            if (AB < AC)
                            {
                                Console.WriteLine("Точка B расположена ближе к точке A, расстояние между точками составляет {0} единиц(у,ы)",AB);
                            }
                            else
                            {
                                Console.WriteLine("Точка С расположена ближе к точке A, расстояние между точками составляет {0} единиц(у,ы)",AC);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Точки B и C находятся на равном расстоянии от точки A.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Точка B совпадает с точкой C.");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Точка C совпадает с точкой A.");
                }
            }
            else
            {
                Console.WriteLine("Точка B совпадает с точкой A.");
            }
            #endregion

            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
