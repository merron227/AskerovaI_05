using System;

class Program
{
    static double ComputeFunction(double x)
    {
        if (x <= -3 || x > 10) throw new ArgumentOutOfRangeException("x", "Значение x выходит за допустимый диапазон.");
        return x > 3 ? x : x > -1 ? -2 / x : 2 * x;
    }

    static void Main()
    {
        try
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"f(x) = {ComputeFunction(x)}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: деление на ноль.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: некорректный ввод.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
