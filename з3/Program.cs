using System;

class Program
{
    static void PowerA3(double A, out double B)
    {
        if (double.IsNaN(A) || double.IsInfinity(A))
            throw new ArgumentException("Некорректное значение A.");
        B = Math.Pow(A, 3);
    }

    static void Main()
    {
        try
        {
            double[] numbers = new double[5];
            Console.WriteLine("Введите 5 чисел:");

            for (int i = 0; i < 5; i++)
                numbers[i] = double.Parse(Console.ReadLine());

            foreach (double num in numbers)
            {
                PowerA3(num, out double result);
                Console.WriteLine($"Число {num} в третьей степени: {result}");
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: деление на ноль.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: некорректный ввод.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
