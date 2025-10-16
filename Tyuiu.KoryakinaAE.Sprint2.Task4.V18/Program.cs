using Tyuiu.KoryakinaAE.Sprint2.Task4.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Корякина А.Э. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнила: Корякина Алина Эльдаяговна  | ИСТНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием*");
        Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных x,y    *");
        Console.WriteLine("* с клавиатуры,                                                            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                            x - 1                                        *");
        Console.WriteLine("* при x * 3 < y - 2:    (6 + -------)^x                                   *");
        Console.WriteLine("*                             y^3                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                      1                                                  *");
        Console.WriteLine("* иначе:    x + 10y - ---                                                 *");
        Console.WriteLine("*                      x                                                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x;

        Console.WriteLine("Введите значение x:");
        x = Convert.ToInt32(Console.ReadLine());

        int y;

        Console.WriteLine("Введите значение x:");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));

        Console.ReadLine();
    }
}