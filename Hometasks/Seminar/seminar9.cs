
// посчитаем сумму всех целых чисел от 1 до N, где N вводится пользователем

// int Summa(int num)
// {
//     int sum = 0;
//     while (true)
//         {
//             if (num==0) break;
//             sum = sum + num;
//             num = num-1;
//         }
//     return sum;
// }

// int SummaRec(int num)
// {
//     if (num==0) return 0;   // строчка 8
//     return num + SummaRec(num-1);   // строчки 9 и 10 и 12 вместе
// }

// //SummaRec(5)

// // 5 + ( 4 + (3 + (2 + (1 + 0)) ))


// Console.WriteLine("Введите натуральное число");
// int num = Convert.ToInt32(Console.ReadLine());
// //Console.WriteLine(Summa(num));
// Console.WriteLine($"Сумма всех целых чисел от 1 до {num} равна {Summa(num)}");
// Console.WriteLine($"Сумма рекурсией всех целых чисел от 1 до {num} равна {SummaRec(num)}");


// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

//     string Values(int num)
//     {
//         int count = 1;
//         string result = String.Empty;
//         while (true)
//         {
//         result += $"{count} ";
//         if (num==count) break;
//         count++;
//         }
//         return result;
//     }

//     string ValuesRec(int num, int count = 1)
//     {
//         if (count == num) return Convert.ToString(count);
//         return Convert.ToString(count) + " " + ValuesRec(num, count+1);
//     }

//     Console.WriteLine("Введите натуральное число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(ValuesRec(num, 5));



// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

//     string Values(int num)
//     {
//         int count = 1;
//         string result = String.Empty;
//         while (true)
//         {
//         result += $"{count} ";
//         if (num==count) break;
//         count++;
//         }
//         return result;
//     }

//     string ValuesRec(int num, int count = 1)
//     {
//         if (count == num) return Convert.ToString(count);
//         return Convert.ToString(count) + " " + ValuesRec(num, count+1);
//     }

//     Console.WriteLine("Введите натуральное число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(ValuesRec(num, 5));



// // Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// // M = 1; N = 5 -> "1, 2, 3, 4, 5"
// // M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Александр, [04.04.2023 11:04]
// Добавил комментарии через гпт

// // Определяем функцию Numb, которая принимает целое число и возвращает строку
// string Numb(int n)
// {
//     // Инициализируем пустую строку a
//     string a = "";

//     // Запускаем бесконечный цикл
//     while (true)
//     {
//         // Проверяем, равно ли значение n нулю. Если да, выходим из цикла.
//         if (n == 0) break;

//         // Преобразуем значение n в строку и добавляем его в начало строки a
//         a = Convert.ToString(n) + a;

//         // Уменьшаем значение n на единицу
//         n--;
//     }

//     // Возвращаем получившуюся строку a
//     return a;
// }

// // Определяем функцию NumbRec, которая принимает целое число и возвращает строку
// string NumbRec(int n)
// {
//     // Если значение n равно нулю, возвращаем пустую строку
//     if(n == 0) return "";

//     // Рекурсивно вызываем функцию NumbRec с аргументом n-1 и добавляем значение n в конец результата
//     return NumbRec(n-1)+" "+n;
// }

// // Запрашиваем у пользователя целое число и сохраняем его в переменной n
// Console.Write("Введите значение N ");
// int n = Convert.ToInt32(Console.ReadLine());

// // Выводим на экран результат вызова функции NumbRec с аргументом n
// Console.Write(NumbRec(n));

// Александр, [04.04.2023 11:06]
// // Определяем функцию Values, которая принимает целое число num и возвращает строку
// string Values(int num)
// {
//     // Инициализируем переменную count со значением 1 и переменную result со значением пустой строки
//     int count = 1;
//     string result = String.Empty;

//     // Запускаем бесконечный цикл
//     while (true)
//     {
//         // Добавляем в конец строки result текущее значение переменной count с пробелом
//         result += $"{count} ";

//         // Если значение переменной num равно значению переменной count, выходим из цикла
//         if (num==count) break;

//         // Увеличиваем значение переменной count на единицу
//         count++;
//     }

//     // Возвращаем получившуюся строку result
//     return result;
// }

// // Определяем функцию ValuesRec, которая принимает целые числа num и count (count по умолчанию равен 1) и возвращает строку
// string ValuesRec(int num, int count = 1)
// {
//     // Если значение переменной count равно значению переменной num, возвращаем текущее значение count в виде строки
//     if (count == num) return Convert.ToString(count);

//     // Рекурсивно вызываем функцию ValuesRec с аргументом num и count+1, а затем добавляем текущее значение count в виде строки и пробел
//     return Convert.ToString(count) + " " + ValuesRec(num, count+1);
// }

// // Выводим на экран сообщение с запросом ввода натурального числа
// Console.WriteLine("Введите натуральное число");

// // Считываем введенное пользователем значение и сохраняем его в переменной num
// int num = Convert.ToInt32(Console.ReadLine());

// // Выводим на экран результат вызова функции ValuesRec с аргументами num и 5
// Console.WriteLine(ValuesRec(num, 5));


// Илья, [04.04.2023 10:56]
// // Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// // N = 5 -> "1, 2, 3, 4, 5"
// // N = 6 -> "1, 2, 3, 4, 5, 6"

//     string Values(int num)
//     {
//         int count = 1;
//         string result = String.Empty;
//         while (true)
//         {
//         result += $"{count} ";
//         if (num==count) break;
//         count++;
//         }
//         return result;
//     }

//     string ValuesRec(int num, int count = 1)
//     {
//         if (count == num) return Convert.ToString(count);
//         return Convert.ToString(count) + " " + ValuesRec(num, count+1);
//     }

//     Console.WriteLine("Введите натуральное число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(ValuesRec(num, 5));



// // Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// // M = 1; N = 5 -> "1, 2, 3, 4, 5"
// // M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Александр, [04.04.2023 11:04]
// Добавил комментарии через гпт

// // Определяем функцию Numb, которая принимает целое число и возвращает строку
// string Numb(int n)
// {
//     // Инициализируем пустую строку a
//     string a = "";

//     // Запускаем бесконечный цикл
//     while (true)
//     {
//         // Проверяем, равно ли значение n нулю. Если да, выходим из цикла.
//         if (n == 0) break;

//         // Преобразуем значение n в строку и добавляем его в начало строки a
//         a = Convert.ToString(n) + a;

//         // Уменьшаем значение n на единицу
//         n--;
//     }

//     // Возвращаем получившуюся строку a
//     return a;
// }

// // Определяем функцию NumbRec, которая принимает целое число и возвращает строку
// string NumbRec(int n)
// {
//     // Если значение n равно нулю, возвращаем пустую строку
//     if(n == 0) return "";

//     // Рекурсивно вызываем функцию NumbRec с аргументом n-1 и добавляем значение n в конец результата
//     return NumbRec(n-1)+" "+n;
// }

// // Запрашиваем у пользователя целое число и сохраняем его в переменной n
// Console.Write("Введите значение N ");
// int n = Convert.ToInt32(Console.ReadLine());

// // Выводим на экран результат вызова функции NumbRec с аргументом n
// Console.Write(NumbRec(n));

// Александр, [04.04.2023 11:06]
// // Определяем функцию Values, которая принимает целое число num и возвращает строку
// string Values(int num)
// {
//     // Инициализируем переменную count со значением 1 и переменную result со значением пустой строки
//     int count = 1;
//     string result = String.Empty;

//     // Запускаем бесконечный цикл
//     while (true)
//     {
//         // Добавляем в конец строки result текущее значение переменной count с пробелом
//         result += $"{count} ";

//         // Если значение переменной num равно значению переменной count, выходим из цикла
//         if (num==count) break;

//         // Увеличиваем значение переменной count на единицу
//         count++;
//     }

//     // Возвращаем получившуюся строку result
//     return result;
// }

// // Определяем функцию ValuesRec, которая принимает целые числа num и count (count по умолчанию равен 1) и возвращает строку
// string ValuesRec(int num, int count = 1)
// {
//     // Если значение переменной count равно значению переменной num, возвращаем текущее значение count в виде строки
//     if (count == num) return Convert.ToString(count);

//     // Рекурсивно вызываем функцию ValuesRec с аргументом num и count+1, а затем добавляем текущее значение count в виде строки и пробел
//     return Convert.ToString(count) + " " + ValuesRec(num, count+1);
// }

// // Выводим на экран сообщение с запросом ввода натурального числа
// Console.WriteLine("Введите натуральное число");

// // Считываем введенное пользователем значение и сохраняем его в переменной num
// int num = Convert.ToInt32(Console.ReadLine());

// // Выводим на экран результат вызова функции ValuesRec с аргументами num и 5
// Console.WriteLine(ValuesRec(num, 5));

// Илья, [04.04.2023 11:35]
// // Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// // 453 -> 12
// // 45 -> 9

// int Sum(int num)
// {
//     if (num / 10 == 0) return num%10;
//     return num%10 + Sum(num/10);
// }


// Console.WriteLine("Введите натуральное число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Sum(num));

// // Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// // A = 3; B = 5 -> 243 (3⁵)
// // A = 2; B = 3 -> 8

// int Stepen(int a, int b)
// {
//     if (b == 1) return a;
//     return a * Stepen(a, b - 1);
// }

// Console.WriteLine("Введите натуральное число");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Stepen(numA, numB));
