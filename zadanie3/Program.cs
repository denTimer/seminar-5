// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


        int[,] array = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        
        int minSum = int.MaxValue;
        int minSumRow = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }

        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRow} (сумма = {minSum})");
    

    
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

