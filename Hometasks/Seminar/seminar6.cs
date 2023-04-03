
// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// void FillArray(int[] array)
// {
//     for (int i=0; i<array.Length;i++)
//         array[i]=new Random().Next(-9,10);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         Console.Write($"{item} ");
//     Console.WriteLine();
// }

// void ReverseArray(int[] array)
// {
//     for (int i=0; i<array.Length/2; i++)
//         (array[i] , array[array.Length-1-i]) = (array[array.Length-1-i], array[i] );
        // (x,y) = (y,x)
        // {
        //     int temp = array[i];
        //     array[i] = array[array.Length-1-i];
        //     array[array.Length-1-i] = temp;
        // }
// }



// Console.WriteLine("Введите размерность массива ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [size];
// FillArray(array);
// PrintArray(array);
// ReverseArray(array);
// PrintArray(array);

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// bool IsTryangle(int a, int b, int c)
// {
//     if(a > b + c  b > a + c  c > a + b) return false;    
//     else return true;
// }

//Console.WriteLine(IsTryangle(5, 6, 7));



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// 
// string ConvertToBin(int numb)
// {
//     string res = "";
//     while(numb >= 1)
//     {
//         res = numb%2 + res;
//         numb = numb/2;
//     }
//     return res;
// }

// System.Console.Write("Число для перевода в bin: ");
// System.Console.WriteLine($"{ConvertToBin(Convert.ToInt32(Console.ReadLine()))}");


// double[] Fibon(int count)
// {
//     double[] res = new double[count];
//     res[0] = 0;
//     res[1] = 1;
//     for (int i = 2; i < res.Length; i++)
//     {
//         res[i] = res[i - 2] + res[i - 1];
//     }
//     return res;
// }

// System.Console.WriteLine("Введите номер числа фиббоначи: ");
// PrintArray(Fibon(Convert.ToInt32(Console.ReadLine())));