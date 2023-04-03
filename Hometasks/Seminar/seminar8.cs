

// Стас, [31.03.2023 10:41]
// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 11);
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

// void RemuvArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         (array[0,i], array[array.GetLength(0)-1,i]) = (array[array.GetLength(0)-1,i], array[0,i]);
//     }
// }





// Console.Write($"Введите количество строк ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[n, n];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// RemuvArray(array);
// Console.WriteLine();
// PrintArray(array);

// Стас, [31.03.2023 10:41]
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно,
//  программа должна вывести сообщение для пользователя.

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 11);
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

// void RemuvArray(int[,] array)
// {
// int [,] arrayRes = new int[array.GetLength(0), array.GetLength(0)];
//    for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             arrayRes[j, i] = array[i,j];
//     }
//     PrintArray(arrayRes);
// }

// void RemuvArray2(int[,] array)
// {
// int [,] arrayRes = new int[array.GetLength(0), array.GetLength(0)];
//    for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i; j < array.GetLength(1); j++)
//             (array[i,j], array[j,i]) = (array[j,i], array[i,j]);
//     }
//     PrintArray(array);
// }



// Console.Write($"Введите количество строк ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[n, n];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// RemuvArray2(array);
// Console.WriteLine();

// Георгий Андрюнин, [31.03.2023 10:44]
// Задача 53: 
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(1, 11);
// }

// void PrintArray(int[,] array)
// {
//     Console.WriteLine("Двумерный массив из случаных чисел: ");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],2}\t");
//         Console.WriteLine();
//     }
// }

// void ChangeRows(int[,] array, int rows, int cols)
// {
//         for (int j = 0; j < array.GetLength(1); j++)
//             (array[0, j], array[rows - 1, j]) = (array[rows - 1, j],  array[0, j]);
// }


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// ChangeRows(array, rows, cols);
// PrintArray(array);


// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// пусть будет двумерный массив из случайных чисел от 0 до 9 включительно
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
// }

// void FillCountArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//             array[i] = 0;
// }

// void PrintArray(int[,] array)
// {
//     Console.WriteLine("Двумерный массив из случаных чисел: ");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],2}\t");
//         Console.WriteLine();
//     }
// }

// void Count(int[,] array, int[] counter)
// {
//     //int tmp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             counter[array[i,j]]++;
// }

// void PrintCounter(int[] counter)
// {
//     for (int i = 0; i < counter.Length; i++)
//         if(counter[i] != 0)
//             if(counter[i] == 2 || counter[i] == 3 ||counter[i] == 4)
//                 Console.WriteLine("Число {0} встречается {1} раза.", i, counter[i]);
//             else
//             Console.WriteLine("Число {0} встречается {1} раз.", i, counter[i]);
            
// }



// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// int[] counter = new int[10];
// FillArray(array);
// PrintArray(array);
// FillCountArray(counter);
// Count(array, counter);
// PrintCounter(counter);