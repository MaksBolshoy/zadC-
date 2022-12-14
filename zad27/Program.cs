//Задача 27: Напишите функцию и запустите ее, которая
//принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
// 82-> 10
//9012 ->12
/*
int NumberSum(int a)
{
    int sum = 0;
    for (i = 1; i <= a.Length; i++)
    {
        sum += a.Lenght;
        i++;
    }
    return sum;
}
Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(NumberSum(a));
*/
/*
int Count(int A)
{
    int res = 0;
    while (A!= 0)
    {
        A = A / 10;
        res+=A;
    }
    return res;
}
Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(Count(A));
*/
/*
int Multi(int A)
{
    int sum =1;
    for( int i =1; i<=A; i++)
    {
        sum =sum+i;
        i++;
    }
    return sum;
}
Console.WriteLine("Введите число А: ");
int N = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(Multi(N));
*/

Console.WriteLine("Введите число А: ");
int N = Convert.ToInt32(Console.ReadLine()!);
int a1=N%10;
int a2=N/10%10;
int a3=N/100%10;
int a4=N/1000;
N=a1+a2+a3+a4;
Console.Write(N);