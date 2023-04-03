
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine($"Возведене числа A в натуральную степень B");

// int Exponent(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }

//    return result;
// }

//   Console.Write("Введите число A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());

//   int exponent = Exponent(numberA, numberB);
//   Console.WriteLine("Ответ: " + exponent);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine($"Выдаёт сумму цифр в числе");
// Console.Write("Введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

//   int SumAllnumb(int numberA){

//     int counter = Convert.ToString(numberA).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++){
//       advance = numberA - numberA % 10;
//       result = result + (numberA - advance);
//       numberA = numberA / 10;
//     }
//    return result;
//   }

// int sumAllnumb = SumAllnumb(numberA);
// Console.WriteLine("Сумма цифр в числе: " + sumAllnumb);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int Prompt(string message)
// {
// System.Console.WriteLine(message);
// string ReadInput = System.Console.ReadLine();
// int result = int.Parse(ReadInput);
// return result;
// }
// int[] GenerateArray(int Length, int minValue, int maxValue)
// {
//       int[] array = new int[Length];
//       Random random = new Random();
//       for (int i = 0; i < Length; i++)
//       {
//             array[i] = random.Next(minValue, maxValue + 1);
//       }
//       return array;
// }

// void PrintArray(int[] array)
// {
//       System.Console.Write("[");
//       for (int i = 0; i < array.Length - 1; i++)
//       {
//             System.Console.Write($"{array[i]}, ");
//       }
//       System.Console.Write($"{ array[array.Length - 1]}");
// System.Console.WriteLine("]");
// }

// int length = Prompt(" Длина массива: ");
// int min = Prompt ("Начальное значение:");
// int max = Prompt ("Конечное значение:");
// int[] array = GenerateArray(length, min, max);
// PrintArray(array);
