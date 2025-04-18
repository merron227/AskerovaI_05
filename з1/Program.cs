using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            double y1 = (Math.Cos(Math.Pow(x, 2)) / (9 * x - 9)) + Math.Pow(Math.Sin(x), 3);

            double y2 = Math.Pow(Math.Sin(x), 3) / Math.Pow(x, 3);

            Console.WriteLine($"Результат y1: {y1}");
            Console.WriteLine($"Результат y2: {y2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: деление на ноль.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: некорректный формат ввода.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
