using Tyuiu.KoryakinaAE.Sprint2.Task7.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 |Выполнила: Корякина А.Э.| ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнила: Корякина Алина Эльдаяговна | ИСТНб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*Написать программу на C#, которая запрашивает исходные данные,           *");
        Console.WriteLine("*вычисляет, находится ли точка с координатами X,Y в заштрихованной области.*");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Введите X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите Y: ");
        double y = Convert.ToDouble(Console.ReadLine());


        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey(); 
    }
}