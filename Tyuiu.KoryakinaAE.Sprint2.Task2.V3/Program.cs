using Tyuiu.KoryakinaAE.Sprint2.Task2.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Корякина А.Э. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнила: Корякина Алина Эльдаяговна | ИСТНб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*Написать программу, которая запрашивает целые значения с клавиатуры и    *");
        Console.WriteLine("*вычисляет находится ли точка с координатами X,Y в заштрихованной области *");
        Console.WriteLine("***************************************************************************");

        int x;
        int y;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(" Введите значение переменной х: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Введите значение переменной y: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool res = ds.CheckDotInShadedArea(x, y);

        if (res == true)
            Console.WriteLine("Точка с данными координатами является заштрихованной");
        else
            Console.WriteLine("Точка с данными координатами не является заштрихованной");

        Console.ReadKey();
    }
}