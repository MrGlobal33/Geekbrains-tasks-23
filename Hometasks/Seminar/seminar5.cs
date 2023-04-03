// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
// равна 29, сумма отрицательных равна -20.

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

// void Summs(int[] array)
// {
//     int sump=0;
//     int sumn=0;
//     foreach (int item in array)
//         if (item < 0)
//             sumn+=item;
//         else 
//             sump+=item;

//     Console.WriteLine($"Сумма положительных элементов равна {sump}");
//     Console.WriteLine($"Сумма отрицательных элементов равна {sumn}");
// }

// int[] Summs2(int[] array)
// {
//     int sump=0;
//     int sumn=0;
//     foreach (int item in array)
//         if (item < 0)
//             sumn+=item;
//         else 
//             sump+=item;
//     int[] results = {sump,sumn};
//     return results;
// }




// int [] array = new int [12];
// FillArray(array);
// PrintArray(array);
// Summs(array);
// int [] res = Summs2(array);
// Console.WriteLine($"Сумма2 положительных элементов равна {res[0]}");
// Console.WriteLine($"Сумма2 отрицательных элементов равна {res[1]}");




      //   {
      //       Console.Write("Введите кол-во элементов в массива: ");
            
      //       int n = Convert.ToInt32(Console.ReadLine());

      //       double[] arr = new double[n];
      //       double mult = 1;

      //       Console.WriteLine();
      //       Console.WriteLine("Введите элементы массива:");
      //       Console.WriteLine();

      //       for (int i = 0; i < arr.Length; i++)
      //           arr[i] = Convert.ToDouble(Console.ReadLine());

      //       for (int i = 0; i < arr.Length; i++)
      //       {
      //           if (arr[i] % 2 == 0)
      //               mult *= arr[i];
      //       }

      //       Console.WriteLine();
      //       Console.WriteLine(mult);
      //           Console.ReadLine();
      //   }


        // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,  
// и наоборот. 
// [-4, -8, 8, 2] -> [4, 8, -8, -2]  
 
// void FillArray(int[] array) 
// { 
//     for (int i=0; i<array.Length;i++) 
//         array[i]=new Random().Next(-4,9); 
// } 
 
// void FactorArray(int[] array) 
// { 
//     for(int i=0; i<array.Length;i++) 
     
// array[i]=array[i]*(-1); 
// } 
// void PrintArray(int[] array2) 
// { 
//     foreach (int item in array2) 
//         Console.Write($"{item} "); 
//     Console.WriteLine(); 
// } 
 
 
 
// int[] newArray = new int [4]; 
// FillArray(newArray); 
// PrintArray(newArray); 
// FactorArray(newArray); 
// PrintArray(newArray);


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// void FillArray(int[] array)
// {
//     for (int i=0; i<array.Length;i++)
//         array[i]=new Random().Next(0,301);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         Console.Write($"{item} ");
//     Console.WriteLine();
// }

// void ChangeZnak(int[] array)
// {    
//     for (int i=0; i<array.Length;i++)
//         array[i] *= -1;    
// }

// bool InArray(int[] array, int n)
// {
//     bool flag = false;
//     foreach (int item in array)
//         if(item == n) 
//         {
//             flag = true;
//             break;
//         }        
//     return flag;
// }
// int CountDigits(int numb, int n)
// {   
//     int count = 0;
//     while(numb > 0)
//     {
//         if(numb % 10 == n)
//             count ++;
//         numb /= 10;
//     }
//     return count;
// }

// int CountInArray(int[] array, int n)
// {
//     int count = 0;

//     foreach(int item in array)
//     {
//         count += CountDigits(item, n);
//     }
//     return count;
// }
// int [] array = new int [4];
// FillArray(array);
// PrintArray(array);
// ChangeZnak(array);
// PrintArray(array);



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int [] array = new int [5];
// FillArray(array);
// PrintArray(array);
// Console.Write("Искать в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountInArray(array, n));


// Задача 35: Задайте одномерный массив из 15 случайных чисел в диапазоне от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].  
// // Пример для массива из 5 элементов 
// // [5, 18, 123, 6, 2] -> 1 
// // [1, 2, 3, 6, 2] -> 0 
// // [10, 11, 12, 13, 14] -> 5 
// void FillArray(int[] array) 
// { 
//     for (int i=0; i<array.Length;i++) 
//         array[i]=new Random().Next(-100,101); 
// } 
// int SearchMassive(int[] array) 
// { 
//     int count = 0; 
//     for (int i=0; i<array.Length;i++) 
//     if(array[i]>=10 && array[i]<=99) 
//     { 
//         count++; 
//     } 
//     return count; 
// } 
// void PrintArray(int[] array) 
// { 
//     foreach (int item in array) 
//         Console.Write($"{item} "); 
//     Console.WriteLine(); 
// } 
// int[] array = new int [15]; 
// FillArray(array); 
// PrintArray(array); 
// Console.WriteLine($"Количество найденных чисел в массиве {SearchMassive(array)}");

// Задача 35: Задайте одномерный массив из 15 случайных чисел в диапазоне от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5 элементов
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int CountInOtr(int[] array, int d1 = 10, int d2 = 99)
// {
//     int count = 0;
//     foreach (int item in array)
//     {
//         if (item >= d1 && item <= d2)
//             count++;
//     }
//     return count;
// }

// int[] SumPairInArray(int[] array)
// {

//     int[] res = new int[array.Length / 2 + array.Length % 2];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         res[i] = array[i] * array[array.Length - 1 - i];
//     }
//     if(array.Length % 2 != 0)
//         res[^1] = array[array.Length/2];
//     return res;
// }

// int [] array = new int [15];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine($"Элементов от 10 до 99 в массиве: {CountInOtr(array)}");


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int arrLenth = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[arrLenth];
// FillArray(array);
// PrintArray(array);
// int[] newArray = SumPairInArray(array);
// PrintArray(newArray);

