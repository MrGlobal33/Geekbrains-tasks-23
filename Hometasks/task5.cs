

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2     
       
      //   Random rnd = new Random();
      //  int[] numbers = new int[8];
      //   int evenCount = 0;
      //   for (int i = 0; i < numbers.Length; i++)
      //   {
      //       numbers[i] = rnd.Next(100, 1000); 
      //       if (numbers[i] % 2 == 0) 
      //       {
      //           evenCount++; 
      //       }
      //   }
      //   Console.WriteLine("Массив случайных чисел:");
      //   foreach (int number in numbers)
      //   {
      //       Console.Write(number + " ");
      //   }
      //   Console.WriteLine("Количество четных чисел в массиве: " + evenCount);
      //   Console.ReadKey();
    

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

      //   int[] array = new int[5];
      //   Random random = new Random();

      //   Console.Write("Массив: ");
      //   for (int i = 0; i < array.Length; i++)
      //   {
      //       array[i] = random.Next(1, 49);
      //       Console.Write(array[i] + " ");
      //   }
      //   Console.WriteLine();

      //   int sum = 0;
      //   for (int i = 1; i < array.Length; i += 2)
      //   {
      //       sum += array[i];
      //   }
      //   Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Random random = new Random();
// double[] array = new double[10];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round(random.NextDouble() * 100, 3); 
// }

// double min = array[0];
// double max = array[0];

// for (int i = 1; i < array.Length; i++)
// {
//     if (array[i] < min)
//     {
//         min = array[i];
//     }
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }

// double difference = max - min;

// Console.WriteLine($"Массив: {string.Join("; ", array)}");
// Console.WriteLine($"Минимальный элемент: {min}");
// Console.WriteLine($"Максимальный элемент: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным элементами ({max:F3} - {min:F3}): {difference:F3}");
