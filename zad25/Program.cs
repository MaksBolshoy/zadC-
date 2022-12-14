//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
Console.WriteLine("Введите число А: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите число В: ");
int b =Convert.ToInt32(Console.ReadLine());
int n =0;
while (n<=b)
{
    Console.WriteLine(Math.Pow(a, b));
   break;
   
}
*/

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine()!);
int Getstep(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
       result*= a;
      
    }
    return result;

}
Console.WriteLine(Getstep(a, b));
