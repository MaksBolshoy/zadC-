
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
// здесь мы присваиваем переменные строк и столбцов и объявляем массив
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
// это метод созданию массива с нулями  на печать его не выводим
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
// это метод по заполнению массива числами выводим на печать 

Console.WriteLine("Введите позицию строки"); 
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца");
int b = Convert.ToInt32(Console.ReadLine());
//здесь с клавы заводим значение элемента
void GetValue(int[,] matr)
{
    if (a < m && b < n)
    {
        Console.WriteLine(matrix[a,b]);
        //object c =  matrix.GetValue(a, b);// не печатает значение элемента на введенную позицию 
        // если эта позиция есть в массиве ???? как сделать .
        //Console.WriteLine(c); 
    }

    else
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    //это метод по нахождению позиции элемента в массиве 
    //или указываем что такого элемента нет в массиве
}

FillArray(matrix); // вывод заполненного массива 
Console.WriteLine();// пустая 
PrintArray(matrix);//вывод заполненного массива 
GetValue(matrix); // вывод элемента массива 
