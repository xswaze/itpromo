
        // Заданный массив целых чисел
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13 };

        // Посчитать сумму нечётных элементов в массиве
        int sumnechet = 0;
        foreach (int num in numbers)
        {
            if (num % 2 != 0)
            {
                sumnechet += num;
            }
        }

        // Найти среднее значение
        double srznach = 0;
        if (numbers.Length > 0)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            srznach = (double)sum / numbers.Length;
        }

        // Найти медиану
        double mediana;
        int length = numbers.Length;
        Array.Sort(numbers);
        if (length % 2 == 0)
        {
            int middle1 = numbers[length / 2 - 1];
            int middle2 = numbers[length / 2];
            mediana = (middle1 + middle2) / 2.0;
        }
        else
        {
            mediana = numbers[length / 2];
        }

        // Вывести полученные значения в консоль
        Console.WriteLine("Сумма нечётных элементов в массиве: " + sumnechet);
        Console.WriteLine("Среднее значение: " + srznach);
        Console.WriteLine("Медиана: " + mediana);

