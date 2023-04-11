// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите количество строк: ");
//         int rows = int.Parse(Console.ReadLine() ?? "0");

//         Console.Write("Введите количество столбцов: ");
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
//            for (int i = 0; i < arr.GetLength(0); i++)
//         {

//             int[] row = new int[arr.GetLength(1)];
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 row[j] = arr[i, j];
//             }

//             Array.Sort(row);
//             Array.Reverse(row);

//                      for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 arr[i, j] = row[j];
//             }
//         }

//         Console.WriteLine("Отсортированный массив:");
//         Printarr(arr);

//        void Printarr(int[, ] arr)
//     {
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write("{0}\t", arr[i, j]);
//             }
//             Console.WriteLine();
//         }
//     }





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите количество строк: ");
//         int rows = int.Parse(Console.ReadLine() ?? "0");

//         Console.Write("Введите количество столбцов: ");
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

//         int minSumRow = 0;
//         int minSum = int.MaxValue;
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             int rowSum = 0;
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 rowSum += arr[i, j];
//             }
//             if (rowSum < minSum)
//             {
//                 minSum = rowSum;
//                 minSumRow = i;
//             }
//         }
//      Console.WriteLine("Строка с наименьшей суммой элементов: " + (minSumRow + 1));



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


//         int[,] ma1 = { { 2, 4 }, { 3, 2 } };
//         int[,] ma2 = { { 3, 4 }, { 3, 3 } };

//         Console.WriteLine("Матрица 1:");
//         PrintMatrix(ma1);
//         Console.WriteLine("Матрица 2:");
//         PrintMatrix(ma2);

//         int[,] result = MultiplyMatrices(ma1, ma2);

//         Console.WriteLine("Результирующая матрица:");
//         PrintMatrix(result);

//         int[,] MultiplyMatrices(int[,] ma1, int[,] ma2) {
//         int rows1 = ma1.GetLength(0);
//         int cols1 = ma1.GetLength(1);
//         int rows2 = ma2.GetLength(0);
//         int cols2 = ma2.GetLength(1);

//         int[,] result = new int[rows1, cols2];

//         for (int i = 0; i < rows1; i++) {
//             for (int j = 0; j < cols2; j++) {
//                 int sum = 0;
//                 for (int k = 0; k < cols1; k++) {
//                     sum += ma1[i, k] * ma2[k, j];
//                 }
//                 result[i, j] = sum;
//             }
//         }

//         return result;
//     }

//      void PrintMatrix(int[,] matrix) {
//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);

//         for (int i = 0; i < rows; i++) {
//             for (int j = 0; j < cols; j++) {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] arr = new int[2, 2, 2];
// Random rnd = new Random();

// for (int i = 0; i < 2; i++)
// {
//       for (int j = 0; j < 2; j++)
//       {
//             for (int k = 0; k < 2; k++)
//             {
//                   int num;
//                   do
//                   {
//                         num = rnd.Next(10, 100);
//                   }
//                   while (CheckNumberExistence(num, arr));

//                   arr[i, j, k] = num;
//             }
//       }
// }
//       for (int i = 0; i < 2; i++)
//       {
//             for (int j = 0; j < 2; j++)
//             {
//                   for (int k = 0; k < 2; k++)
//                   {
//                         Console.Write(arr[i, j, k] + "(" + i + "," + j + "," + k + ") ");
//                   }
//                   Console.WriteLine();
//             }
//       }

//       Console.ReadLine();

//       static bool CheckNumberExistence(int num, int[,,] arr)
//       {
//             for (int i = 0; i < arr.GetLength(0); i++)
//             {
//                   for (int j = 0; j < arr.GetLength(1); j++)
//                   {
//                         for (int k = 0; k < arr.GetLength(2); k++)
//                         {
//                               if (arr[i, j, k] == num)
//                                     return true;
//                         }
//                   }
//             }
//             return false;
//       }





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int n = 4;
// int[,] arr = new int[n, n];
// int num = 1;
// int row = 0;
// int col = 0;
// int lastRow = n - 1;
// int lastCol = n - 1;

// while (row <= lastRow && col <= lastCol)
// {
//        for (int i = col; i <= lastCol; i++)
//     {
//         arr[row, i] = num;
//         num++;
//     }
//     row++;

//     for (int i = row; i <= lastRow; i++)
//     {
//         arr[i, lastCol] = num;
//         num++;
//     }
//     lastCol--;

//       if (row <= lastRow)
//     {
//         for (int i = lastCol; i >= col; i--)
//         {
//             arr[lastRow, i] = num;
//             num++;
//         }
//         lastRow--;
//     }

//         if (col <= lastCol)
//     {
//         for (int i = lastRow; i >= row; i--)
//         {
//             arr[i, col] = num;
//             num++;
//         }
//         col++;
//     }
// }

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write($"{arr[i, j]:D2} ");
//     }
//     Console.WriteLine();
// }

