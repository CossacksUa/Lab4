using System;

class Task2
{
    public static void Execute()
    {
        Console.WriteLine("Введiть кiлькiсть рядкiв:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введiть кiлькiсть стовпцiв:");
        int columns = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, columns];

        Console.WriteLine("Введiть елементи масиву:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Елемент[{i},{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nПобудований масив:");
        PrintArray(array);

        bool hasEvenInUpperLeftOrLowerLeftCorner = HasEvenInUpperLeftOrLowerLeftCorner(array);
        bool hasNumbersEndingWithZeroInUpperRightOrLowerRightCorner = HasNumbersEndingWithZeroInUpperRightOrLowerRightCorner(array);

        if (hasEvenInUpperLeftOrLowerLeftCorner)
        {
            Console.WriteLine("\nУ верхньому лiвому або нижньому лiвому кутi є парне число.");
        }
        else
        {
            Console.WriteLine("\nУ верхньому лiвому або нижньому лiвому кутi немає парного числа.");
        }

        if (hasNumbersEndingWithZeroInUpperRightOrLowerRightCorner)
        {
            Console.WriteLine("\nУ верхньому правому або нижньому правому кутi є число, що закiнчується нулем.");
        }
        else
        {
            Console.WriteLine("\nУ верхньому правому або нижньому правому кутi немає числа, що закiнчується нулем.");
        }
    }

    static bool HasEvenInUpperLeftOrLowerLeftCorner(int[,] array)
    {
        int rows = array.GetLength(0);

        return array[0, 0] % 2 == 0 || array[rows - 1, 0] % 2 == 0;
    }

    static bool HasNumbersEndingWithZeroInUpperRightOrLowerRightCorner(int[,] array)
    {
        int columns = array.GetLength(1);

        return array[0, columns - 1] % 10 == 0 || array[array.GetLength(0) - 1, columns - 1] % 10 == 0;
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
