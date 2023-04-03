
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
// void FillArray(int[,] array)
// {
//     for (int i =0; i<array.GetLength(0);i++)
//         for (int j =0; j<array.GetLength(1);j++)
//             array[i,j] = new Random().Next(-30,31);
// }

// void PrintArray(int[,] array)
// {
//     for (int i =0; i<array.GetLength(0);i++)
//         {
//         for (int j =0; j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],3}\t") ;
//         Console.WriteLine();
//         }       
// }



// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [rows,cols];
// FillArray(array);
// PrintArray(array);


// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 11);
// }

// void FillArrayWithSum(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             // array[i,j] = new Random().Next(-30,31);
//             array[i, j] = i + j;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3}\t");
//         Console.WriteLine();
//     }
// }

// void FillOdd(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             if (i % 2 == 1 && j % 2 == 1) array[i, j] *= array[i, j];
// }





// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [rows,cols];
// FillArray(array);
// PrintArray(array);



// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// FillArrayWithSum(array);
// PrintArray(array);





// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4



// int[,] array = new int[3, 4];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// FillOdd(array);
// PrintArray(array);


// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали  и отдельно сумму элементов обратной диагонали.
// Например, задан массив:
// 1 4 7 
// 5 9 2 
// 8 4 2 
// Сумма элементов главной диагонали: 1+9+2 = 12
// Сумма элементов обратной диагонали: 8+9+7 = 24

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3}\t");
//         Console.WriteLine();
//     }
// }

// int Sum1(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             if (i == j)
//                 sum += array[i, j];
//     return sum;
// }

// int Sum2(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             if (i + j == array.GetLength(0) - 1)
//                 sum += array[i, j];
//     return sum;
// }

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine($"Сумма элементов главной диагонали равна {Sum1(array)}");
// Console.WriteLine($"Сумма элементов обратной диагонали равна {Sum2(array)}");