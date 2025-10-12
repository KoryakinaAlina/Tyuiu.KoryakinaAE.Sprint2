using Tyuiu.KoryakinaAE.Sprint2.Task1.V12.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Корякина А.Э. | ИСТНб-25-1";
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #2                                                              *");
        Console.WriteLine("* Тема: Логические операции                                              *");
        Console.WriteLine("* Задание #1                                                             *");
        Console.WriteLine("* Вариант #12                                                            *");
        Console.WriteLine("* Выполнила: Корякина Алина Эльдаяговна | ИСТНб-25-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Написать программу из операций сравнения и арифметических выражений,   *");
        Console.WriteLine("* которая вернет последовательность(массив):                             *");
        Console.WriteLine("* (True, True, True, False, True, False)                                 *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        int a = 152;
        int b = 116;
        int c = 887;
        int d = 556;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    }
}