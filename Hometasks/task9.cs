// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine() ?? "0");

//         Console.Write(NumbersToString(n));
    

//     static string NumbersToString(int n)
//     {
//         if (n == 1)
//         {
//             return "1";
//         }
//         else
//         {
//             return n + ", " + NumbersToString(n - 1);
//         }
//     }



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

   
//         Console.Write("Введите m: ");
//         int m = int.Parse(Console.ReadLine() ?? "0");
//         Console.Write("Введите n: ");
//         int n = int.Parse(Console.ReadLine() ?? "0");
        
//         int sum = SumNaturalNumbers(m, n);
        
//         Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {sum}");
        
//     static int SumNaturalNumbers(int start, int end){ 
//         if (end == start) {
//             return end;
//         }
        
//         return start + SumNaturalNumbers(start + 1, end);
//     }





// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// static int Ackermann(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (n == 0) return Ackermann(m - 1, 1);
//     return Ackermann(m - 1, Ackermann(m, n - 1));
// }
// int m = 2, n = 3;
// int result = Ackermann(m, n);
// Console.WriteLine($"A({m}, {n}) = {result}"); 

// m = 3; n = 2;
// result = Ackermann(m, n);
// Console.WriteLine($"A({m}, {n}) = {result}"); 
