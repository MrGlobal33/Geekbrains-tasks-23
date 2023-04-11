// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.WriteLine("Введите количество строк m:");
//         int m = int.Parse(Console.ReadLine() ?? "0");

//         Console.WriteLine("Введите количество столбцов n:");
//         int n = int.Parse(Console.ReadLine() ?? "0");

//         Random random = new Random();
//         double[,] array = new double[m, n];

//         for (int i = 0; i < m; i++) {
//             for (int j = 0; j < n; j++) {
//                 array[i, j] = random.NextDouble() * 10; 
//             }
//         }

//         Console.WriteLine("Сгенерированный массив:");
//         for (int i = 0; i < m; i++) {
//             for (int j = 0; j < n; j++) {
//                 Console.Write($"{array[i, j]:F2}  "); 
//             }
//             Console.WriteLine();
//         }


// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.Write("Введите количество строк в массиве: ");
//         int rows = int.Parse(Console.ReadLine() ?? "0");

//         Console.Write("Введите количество столбцов в массиве: ");
//         int cols = int.Parse(Console.ReadLine() ?? "0");

//         int[,] arr = new int[rows, cols];
//         Random rand = new Random();
//                 for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 arr[i, j] = rand.Next(1, 20); 
//                 Console.Write("{0}\t", arr[i, j]);
//             }
//             Console.WriteLine();
//         }
//         Console.Write("Введите значение элемента: ");
//         int value = int.Parse(Console.ReadLine() ?? "0");
      
//         bool found = false;
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 if (arr[i, j] == value)
//                                 {
//                     Console.WriteLine("Позиция элемента: {0}, {1}", i + 1, j + 1);
//                     found = true;
//                     break;
//                 }
//             }
//             if (found) break;
//         }

//         if (!found)
//         {
//             Console.WriteLine("Элемент {0} не найден в массиве", value);
//         }

//         Console.ReadKey();



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] myarr = new int[4, 3];
//         Random rnd = new Random();

//                for (int i = 0; i < 4; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 myarr[i, j] = rnd.Next(1, 11);
//             }
//         }

//             Console.WriteLine("Массив:");
//         for (int i = 0; i < 4; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 Console.Write("{0,4}", myarr[i, j]);
//             }
//             Console.WriteLine();
//         }

//             for (int j = 0; j < 3; j++)
//         {
//             double sum = 0;
//             for (int i = 0; i < 4; i++)
//             {
//                 sum += myarr[i, j];
//             }
//             double avg = sum / 4;
//             Console.WriteLine("Среднее арифметическое столбца {0}: {1}", j + 1, avg);
//         }

//         Console.ReadLine();



// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10


//         Console.Write("Введите количество строк: ");
//         int rows = int.Parse(Console.ReadLine() ?? "0");

//         Console.Write("Введите количество столбцов: ");
//         int cols = int.Parse(Console.ReadLine() ?? "0");

//         int[,] array = new int[rows, cols];
//         Random random = new Random();
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 array[i, j] = random.Next(100);
//             }
//         }
//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         SortArray(array);
//         Console.WriteLine("Отсортированный массив:");
//         PrintArray(array);
      // void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write("{0,3}", array[i, j]);
//             }
//             Console.WriteLine();
//         }
//     }

//        void SortArray(int[,] array)
//     {
//         int[] flattened = new int[array.GetLength(0) * array.GetLength(1)];
//         int index = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 flattened[index] = array[i, j];
//                 index++;
//             }
//         }

//               Array.Sort(flattened);

//              index = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = flattened[index];
//                 index++;
//             }
//         }
//     }





