
// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void CheckKoord(int x, int y)
// {
//     if (x > 0 && y > 0)
//         Console.WriteLine("Четверть № 1");
//     else if (x < 0 && y > 0)
//         Console.WriteLine("Четверть № 2");
//     else if (x < 0 && y < 0)
//         Console.WriteLine("Четверть № 3");
//     else if (x > 0 && y < 0)
//         Console.WriteLine("Четверть № 4");
//     else
//         Console.WriteLine("Точка находится на координатной оси");
// }

// int CheckKoord2(int x, int y)
// {
//     int res = 0;
//     if (x > 0 && y > 0)
//         res = 1;
//     else if (x < 0 && y > 0)
//         res = 2;
//     else if (x < 0 && y < 0)
//         res = 3;
//     else if (x > 0 && y < 0)
//         res = 4;
//     return res;
// }


// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x, y);
// Console.WriteLine(CheckKoord2(x, y));


// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y). 
 
 
 
 
// string CheckKoord2(int quarterNum) 
// { 
//     string res; 
//     if (quarterNum == 1) 
//         res = "x > 0 , y > 0"; 
//     else if (quarterNum == 2) 
//         res = "x < 0 , y > 0"; 
//     else if (quarterNum == 3) 
//         res = "x < 0 , y < 0"; 
//     else if (quarterNum == 4) 
//         res = "x > 0 , y < 0"; 
//     else res = "Введено недопустимое значение"; 
//     return res; 
// } 
 
 
 
 
// try 
// { 
//     Console.WriteLine("Введите номер четверти : "); 
//     int quarterNum = Convert.ToInt32(Console.ReadLine()); 
//     Console.WriteLine(CheckKoord2(quarterNum)); 
// } 
// catch 
// { 
//     Console.WriteLine("Введено не целое число"); 
// }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// double Dist(int x1, int y1, int x2, int y2)
// {
//     double res = 0;  
//     res = Math.Sqrt( (x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) );
//     return res;

// }
// try
// {
//     Console.Write("Введите Х1: ");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Y1: ");
//     int y1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Х2: ");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Y2: ");
//     int y2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(Math.Round(Dist(x1, y1, x2, y2), 3));
// }
// catch
// {
//     Console.WriteLine("Ввели неправильные данные");
// }





// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// string NumbKvad(int numb, string res = "1")
// {
//     if(numb <= 0)
//     {
//         return "Вы ввели неправильное число!";
//     }

//     int i = 2;    
//     while(i <= numb)
//     {
//         res =  res + ", " + Convert.ToString(i*i);
//         i++;
//     }
//     return res;
// }

// try
// {
//     Console.Write("Введите N: ");
//     int numb = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(NumbKvad(numb));
// }
// catch
// {
//     Console.WriteLine("Ввели неправильные данные");
// }