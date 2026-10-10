using Tyuiu.TashovVD.Sprint2.Task5.V13.Lib;

namespace Tyuiu.TashovVD.Sprint2.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Ташов В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Ташов В. Д. | АСОиУб-26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y, z;
            string res;
            Console.Write("Введите год: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите меcяц: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день: ");
            z = Convert.ToInt32(Console.ReadLine());

            if ((x < 0) || (y <= 0) || (y > 12))
            {
                res = "Неверное значение даты";
            }
            else
            {
                DataService ds = new DataService();
                res = ds.FindDateOfNextDay(x, y, z);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
