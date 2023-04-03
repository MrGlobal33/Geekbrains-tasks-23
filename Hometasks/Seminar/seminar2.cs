
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает 
//наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10,100);
// Console.WriteLine($"Было сгенерировано случайное число {num}");
// int x1 = num/10;
// int x2 = num%10;
// if (x1>x2)
//     Console.WriteLine($"Наибольшая цифра в этом числе это {x1} ");
// else if (x1<x2)
//     Console.WriteLine($"Наибольшая цифра в этом числе это {x2} ");
// else
//     Console.WriteLine("Обе цифры равны друг другу");



//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно  
//  Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int ost = number1%number2;
// if (ost==0) {Console.WriteLine("Второе число кратно первому");}
//  else Console.WriteLine($"Остаток от деления {ost} "); */

 // Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
// int numb = new Random().Next(100,1000);
// // string numb = Convert.ToString(numb);
// int num1 = numb/100;
// int num2 = numb%10;
// Console.WriteLine($"Задано число {numb} Получилось число {num1}{num2} ");


/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да*/

/*Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int ost1 = number1%7;
int ost2 = number1%23;
if (ost1 ==0 && ost2 ==0) {Console.WriteLine("Да");}
else Console.WriteLine("Нет");

/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int ost1 = number1*number1;
int ost2 = number2*number2;
if (ost1 ==number2 || ost2 ==number1) {Console.WriteLine("Да");}
else Console.WriteLine("Нет"); */