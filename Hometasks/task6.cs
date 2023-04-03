

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите количество чисел: ");
// int m = int.Parse(Console.ReadLine());

// int countPositive = 0;
// double[] numbers = new double[m];

// for (int i = 0; i < m; i++)
// {
//     Console.Write($"Введите число {i+1}: ");
//     numbers[i] = double.Parse(Console.ReadLine());

//     if (numbers[i] > 0)
//     {
//         countPositive++;
//     }
// }
// Console.WriteLine($"Количество чисел больше 0: {countPositive}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine("Введите значения k1, b1, k2, b2:");
// Console.Write("b1 = ");

// double b1 = double.Parse(Console.ReadLine() ?? "0");
// Console.Write("k1 = ");

// double k1 = double.Parse(Console.ReadLine() ?? "0");
// Console.Write("b2 = ");

// double b2 = double.Parse(Console.ReadLine() ?? "0");

// Console.Write("k2 = ");
// double k2 = double.Parse(Console.ReadLine() ?? "0");

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine($"Точка пересечения: ({x}, {y})");
  

// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// *Пример:*
// - для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

// Console.Write("Введите k: ");
// int k = int.Parse(Console.ReadLine() ?? "0");

// int[] negaFibonacci = new int[Math.Abs(k) + 1];

// if (k > 0)
// {
//     for (int i = 1; i <= k; i++)
//     {
//         if (i == 1)
//         {
//             negaFibonacci[i] = 0;
//         }
//         else if (i == 2)
//         {
//             negaFibonacci[i] = 1;
//         }
//         else
//         {
//             negaFibonacci[i] = negaFibonacci[i - 2] - negaFibonacci[i - 1];
//         }
//     }
// }
// else if (k < 0)
// {
//     for (int i = 1; i <= Math.Abs(k); i++)
//     {
//         if (i == 1)
//         {
//             negaFibonacci[i] = 0;
//         }
//         else if (i == 2)
//         {
//             negaFibonacci[i] = -1;
//         }
//         else if (i % 2 == 0)
//         {
//             negaFibonacci[i] = negaFibonacci[i - 2] - negaFibonacci[i - 1];
//         }
//         else
//         {
//             negaFibonacci[i] = negaFibonacci[i - 2] + negaFibonacci[i - 1];
//         }
//     }
// }

// int[] result = new int[negaFibonacci.Length * 2 - 2];

// for (int i = negaFibonacci.Length - 1; i >= 1; i--)
// {
//     result[negaFibonacci.Length - i - 1] = -negaFibonacci[i];
//     if (i != 1)
//     {
//         result[result.Length - (negaFibonacci.Length - i)] = negaFibonacci[i];
//     }
// }

// Console.WriteLine("Результат: [" + string.Join(", ", result) + "]");
