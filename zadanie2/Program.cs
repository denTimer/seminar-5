// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


        int[,] array = new int[3, 3] { { 3, 2, 1 }, { 4, 5, 6 }, { 7, 8, 9 } };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        
        int rowLength = array.GetLength(0);
        int colLength = array.GetLength(1);

        for (int i = 0; i < colLength; i++)
        {
            int temp = array[0, i];
            array[0, i] = array[rowLength - 1, i];
            array[rowLength - 1, i] = temp;
        }

        Console.WriteLine("\nМассив после замены:");
        PrintArray(array);
    
    
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
