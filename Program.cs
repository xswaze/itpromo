using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа, разделяя их пробелами:");
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');

        int[] numbers = new int[numberStrings.Length];
        for (int i = 0; i < numberStrings.Length; i++)
        {
            if (int.TryParse(numberStrings[i], out int num))
            {
                numbers[i] = num;
            }
            else
            {
                Console.WriteLine("Ошибка ввода числа " + numberStrings[i]);
                return;
            }
        }

        // Посчитать сумму нечётных элементов в массиве
        int sumOfOddNumbers = 0;
        foreach (int num in numbers)
        {
            if (num % 2 != 0)
            {
                sumOfOddNumbers += num;
            }
        }

        // Найти среднее значение
        double average = 0;
        if (numbers.Length > 0)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            average = (double)sum / numbers.Length;
        }

        // Найти медиану
        double median = 0;
        int length = numbers.Length;
        if (length > 0)
        {
            Array.Sort(numbers);
            if (length % 2 == 0)
            {
                int middle1 = numbers[length / 2 - 1];
                int middle2 = numbers[length / 2];
                median = (middle1 + middle2) / 2.0;
            }
            else
            {
                median = numbers[length / 2];
            }
        }

        // Вывести полученные значения в консоль
        Console.WriteLine("Сумма нечётных элементов в массиве: " + sumOfOddNumbers);
        Console.WriteLine("Среднее значение: " + average);
        Console.WriteLine("Медиана: " + median);
    }
}
