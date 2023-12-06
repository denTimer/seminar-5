//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


        int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        
        Console.WriteLine("Введите позицию элемента (строка, столбец): ");
        string input = Console.ReadLine();
        string[] positions = input.Split(',');
        int row = Convert.ToInt32(positions[0].Trim());
        int column = Convert.ToInt32(positions[1].Trim());

        
        if (row < array.GetLength(0) && column < array.GetLength(1))
        {
            int value = array[row, column];
            Console.WriteLine($"Значение элемента: {value}");
        }
        else
        {
            Console.WriteLine("Указанный элемент отсутствует в массиве.");
        }
    