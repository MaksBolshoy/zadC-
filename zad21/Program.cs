// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите координату x1: ");
int x1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату u1: ");
int u1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
int z1 =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: ");
int x2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату u2: ");
int u2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
int z2 =Convert.ToInt32(Console.ReadLine());
double d =Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(u2-u1, 2)+Math.Pow(z2-z1, 2));
Console.WriteLine("Растояние между двумя точками: " +d);
