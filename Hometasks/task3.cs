

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
//        int number = int.Parse(Console.ReadLine() ?? "0");

//         int x1 = number / 10000;
//         int x2 = (number % 10000) / 1000;
//         int x3 = (number % 1000) / 100;
//         int x4 = (number % 100) / 10;
//         int x5 = number % 10;
//         bool isPalindrome = x1 == x5 && x2 == x4;
//         if (isPalindrome)
//         {
//             Console.WriteLine("Число является палиндромом.");
//         }
//         else
//         {
//             Console.WriteLine("Число не является палиндромом.");
//         }
//         Console.ReadKey();



// Задача 21  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt32(Console.ReadLine());
// }
// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2)
// {
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                     Math.Pow((z2-z1), 2));
//  }
//  double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
// Console.WriteLine($"Длина отрезка  {segmentLength}");



// Задача 23  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//         Console.Write("Введите число N: ");
//         int n = int.Parse(Console.ReadLine() ?? "0");

//         for (int i = 1; i <= n; i++)
//         {
//             int cube = Cube(i);
//             Console.WriteLine($"{i}^3 = {cube}");
//         }

//         Console.ReadKey();
    
//     static int Cube(int x)
//     {
//         return x * x * x;
//     }


// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

// Console.Write("Введите размерность пространства: ");
//         int n = int.Parse(Console.ReadLine() ?? "0");

//         double[] point1 = new double[n];
//         double[] point2 = new double[n];

//         Console.WriteLine("Введите координаты первой точки:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"Координата {i + 1}: ");
//             point1[i] = double.Parse(Console.ReadLine() ?? "0");
//         }

//         Console.WriteLine("Введите координаты второй точки:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"Координата {i + 1}: ");
//             point2[i] = double.Parse(Console.ReadLine() ?? "0");
//         }
//         double distance = 0;
//         for (int i = 0; i < n; i++)
//         {
//             double diff = point1[i] - point2[i];
//             distance += diff * diff;
//         }
//         distance = Math.Sqrt(distance);

//         Console.WriteLine($"Расстояние между точками: {distance}");
