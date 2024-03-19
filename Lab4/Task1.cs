using System;

class Task1
{
    public static void Execute()
    {
        // Введення розміру масиву
        Console.WriteLine("Введiть розмiр масиву:");
        int n = int.Parse(Console.ReadLine());

        // Створення масиву
        int[] array = new int[n];

        // Введення елементів масиву
        Console.WriteLine("Введiть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Елемент[{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Обчислення добутку елементів з парними номерами
        double product = CalculateProductOfEvenIndexedElements(array);
        Console.WriteLine($"Добуток елементiв з парними номерами: {product}");

        // Обчислення суми елементів між першим і останнім нульовими елементами
        double sumBetweenZeros = CalculateSumBetweenZeros(array);
        Console.WriteLine($"\nСума елементiв мiж першим i останнiм нульовими елементами: {sumBetweenZeros}");

        // Виведення початкового масиву
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        // Перетворення масиву
        ConvertArray(ref array);

        // Виведення перетвореного масиву
        Console.WriteLine("\nМасив пiсля перетворення:");
        PrintArray(array);
    }

    // Функція для виведення масиву на консоль
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // Функція для обчислення добутку елементів з парними номерами
    static double CalculateProductOfEvenIndexedElements(int[] array)
    {
        double product = 1;
        for (int i = 0; i < array.Length; i += 2)
        {
            product *= array[i];
        }
        return product;
    }

    // Функція для обчислення суми елементів між першим і останнім нульовими елементами
    static double CalculateSumBetweenZeros(int[] array)
    {
        int firstZeroIndex = -1;
        int lastZeroIndex = -1;

        // Пошук першого нульового елемента
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                firstZeroIndex = i;
                break;
            }
        }

        // Пошук останнього нульового елемента
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == 0)
            {
                lastZeroIndex = i;
                break;
            }
        }

        // Обчислення суми елементів між першим і останнім нульовими елементами
        double sum = 0;
        if (firstZeroIndex != -1 && lastZeroIndex != -1 && lastZeroIndex != firstZeroIndex)
        {
            int start = Math.Min(firstZeroIndex, lastZeroIndex);
            int end = Math.Max(firstZeroIndex, lastZeroIndex);
            for (int i = start + 1; i < end; i++)
            {
                sum += array[i];
            }
        }
        return sum;
    }

    // Функція для перетворення масиву
    static void ConvertArray(ref int[] array)
    {
        // Сортування масиву таким чином, щоб спочатку розміщувались усі додатні елементи, а потім - усі від'ємні
        Array.Sort(array, (x, y) => Math.Sign(x) == Math.Sign(y) ? 0 : Math.Sign(x) < Math.Sign(y) ? -1 : 1);
    }
}
