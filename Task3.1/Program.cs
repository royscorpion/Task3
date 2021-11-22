using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Поиск координат четвертой вершины по введенным целочисленным координатам трех вершин с проверкой параллельности сторон прямоугольника координатным осям
            #region Ввод исходных данных
            Console.WriteLine("Введите координаты трех вершин прямугольника со сторонами параллельными координатным осям");
            Console.Write("x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x4 = 0, y4 = 0;
            #endregion

            #region Проверка координат
           if ((x2-x1)*(x3-x1)+(y2-y1)*(y3-y1)==0)
            {
                x4 = x3 + x2 - x1;
                y4 = y3 + y2 - y1;
            }
            else
            {
                if ((x1 - x2) * (x3 - x2) + (y1 - y2) * (y3 - y2) == 0)
                {
                    x4 = x3 + x1 - x2;
                    y4 = y3 + y1 - y2;
                }
                else
                {
                    if ((x1 - x3) * (x2 - x3) + (y1 - y3) * (y2 - y3) == 0)
                    {
                        x4 = x1 + x2 - x3;
                        y4 = y1 + y2 - y3;
                    }
                }
            }
            #endregion

            #region Вывод результатов
            if (x1==x2&&x2==x3||y1==y2&&y2==y3)
            {
                Console.WriteLine("Ошибка: Точки лежат на одной прямой.");
            }
            else
            {
                if (x4 != 0 && y4 != 0)
                {
                    Console.WriteLine("Координаты четвертой вершины прямоугольника: x4 = {0}, y4 = {1}", x4, y4);
                }
                else
                {
                    Console.WriteLine("Ошибка: Стороны прямоугольника не параллельны координатным осям.");
                }
            }
           
            #endregion

            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
