//Задача 42: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число B1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число K1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число K2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
double y = k1 * x + b1;
//y = k2 * x + b2;
//x=-b1/b2;
Console.WriteLine(x);
Console.WriteLine(y);
//double x = (y-b2)/k2;
//if(x =-b1/b2) Console.WriteLine(x);
//if(number > 5 && number <=7) Console.WriteLine("Выходной день: ");