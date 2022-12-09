
//// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
//


Console.Write("Введите  пятизначное число : ");
int [] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray(); 

if ( array[0] == array[4] &&  array[1] == array[3])
{
    Console.WriteLine("Это число палиндром");
}
else Console.WriteLine("Это число НЕ палиндром");
