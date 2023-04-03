// $$
// Console.WriteLine("Введите число : "); 
// int number = Convert.ToInt32(Console.ReadLine()); 
 
// int start = number*(-1); 
 
// while(start<=number) { 
//     Console.Write (start+", "); 
//     start++; 
// }

// $$

// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49


// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(  Console.ReadLine()  );
// int square = num*num;
// Console.WriteLine("Квадрат введенного числа равен "+ square);

// if (num<0)
// {
//     Console.WriteLine("Это отрицательное число");
// }
// else
// {
//      Console.WriteLine("Это неотрицательное число");
// }


// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет*/

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2 * num2)
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }
// else if (num2 == num1 * num1)
// {
//     Console.WriteLine("Второе число является квадратом первого");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница
*/
// try 
// {
// Console.WriteLine("Введите номер недели");
// int num1 = Convert.ToInt32(Console.ReadLine());
// switch (num1)
// {
//     case 1:
//         Console.WriteLine("Понедельник");
//         break;
//     case 2:
//         Console.WriteLine("Вторник");
//         break;

//     case 3:
//         Console.WriteLine("Среда");
//         break;
//     case 4:
//         Console.WriteLine("Четверг");
//         break;
//     case 5:
//         Console.WriteLine("Пятница");
//         break;

//     case 6:
//         Console.WriteLine("Суббота");
//         break;
//     case 7:
//         Console.WriteLine("Воскресенье");
//         break;
//     default:
//         Console.WriteLine("Введите корректное число");
//         break;
// }
// }
// catch
// {Console.WriteLine("Надо вводить целое число");}