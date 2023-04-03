
// Задача 24: Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите натуральное число");
// int A = Convert.ToInt32(Console.ReadLine());
// Summa(A);
// Console.WriteLine($"Сумма по 2 функции  всех чисел от 1 до {A} равна {Summa2(A)}");



// void Summa(int A)
// {
//     int sum=0;
//     for (int i =1; i<=A; i=i+1)
//         sum+=i;
//     Console.WriteLine($"Сумма всех чисел от 1 до {A} равна {sum}");
// }

// int Summa2(int A)
// {
//     int sum=0;
//     for (int i =1; i<=A;i++)
//         sum+=i;
//     return sum;
// }



// Задача 26: Напишите программу,
// которая принимает на вход вещественное число и выдаёт сумму цифр в числе.

// int Summ(int A)
// {
//     int sum1 = 0;
//     int a2 = A;
//     while (a2 > 0)
//     {
//         sum1 = sum1 + a2 % 10; // берем остаток от деления 
//         a2 /= 10;
       
//     }
//     return sum1;
// }

// Console.WriteLine("Введите натуральное число");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"сумма цифр в числе = {Summ(A)}");



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int Proizvedenie(int n)
// {
//     int res = 1;
//     for(int i = 1; i <= n; i++)
//     {
//         res*=i;
//     }
//     return res;
// }

// Console.Write("Введите натуральное число:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат: {Proizvedenie(n)}");


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// void FillArray(int[] arr)
// {
    //int[] arr = new int[count];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0,2);
//     }
    
// }

// void PrintArray(int[] arr)
// {
//     foreach(int i in arr)
//     {
//         Console.Write($"{i} ");    
//     }
// }
// bool CountNulls(int[] arr)
// {
//     int nulls = 0;
//     foreach(int i in arr)
//     {
//         if(i == 0) nulls++;
//     }
//     if(nulls >= arr.Length - nulls) 
//     {
//         return false;
//     }    
//     else return true;


// }


// int[] arr = new int[8];
// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine($"Единиц больше:{CountNulls(arr)}");