using Tyuiu.KoryakinaAE.Sprint2.Task3.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Корякина А.Э. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                      *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #27                                                            *");
        Console.WriteLine("* Выполнила: Корякина Алина Эльдаяговна | ИСТНб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*Написать программу, которая вычисляет требуемое значение функции Y       *");
        Console.WriteLine("*с использованием вложенных оператор if-else, где пользователь вводит     *");
        Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до трех *");
        Console.WriteLine("*знаков после запятой                                                     *"); 
        Console.WriteLine("***************************************************************************");

     
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(" Введите значение переменной х: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Значение функции " + res);

        Console.ReadKey();
    }
}