//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

/// Комментарий к методу
/// m - кол-во строк, n - столбцов
/// min, max
int[,] Get2DArray(int m, int n, int min, int max)
{
    int[,] matrixOne = new int[m, n];
    for (int i = 0; i < m; i++) // по строчкам m
    {
        for (int j = 0; j < n; j++) // по столбцам n
        {
            matrixOne[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrixOne;
}
/// Печать массива. На вход
/// принимает массив для печати
void Print2DArray(int[,] matrixOne)
{
    for (int i = 0; i < matrixOne.GetLength(0); i++) // по строчкам 
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++) // по столбцам 
        {
            Console.Write(matrixOne[i, j] + "\t"); // "\t" = Tab   
        }
        Console.WriteLine();
    }
}
int[,] Get22DArray(int m, int n, int min, int max)
{
    int[,] matrixTwo = new int[m, n];
    for (int i = 0; i < m; i++) // по строчкам m
    {
        for (int j = 0; j < n; j++) // по столбцам n
        {
            matrixTwo[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrixTwo;
}
/// Печать массива. На вход
/// принимает массив для печати
void Print22DArray(int[,] matrixTwo)
{
    for (int i = 0; i < matrixTwo.GetLength(0); i++) // по строчкам 
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++) // по столбцам 
        {
            Console.Write(matrixTwo[i, j] + "\t"); // "\t" = Tab   
        }
        Console.WriteLine();
    }
}

int[,] Print33DArray(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrixTT = new int[matrixOne.GetLength(0),matrixOne.GetLength(1)];//1 меняем на тво 
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
             matrixTT[i, j] += matrixOne[i, j] * matrixTwo[i, j]; 
        }
    } 
    return matrixTT;  
}

int[,] result = Get2DArray(rows, columns, 0, 9); // Массив rows * columns, от 0 до 9 
Console.WriteLine("Первая матрица");
Print2DArray(result);
int[,] pasol = Get22DArray(rows, columns, 11, 19); // Массив rows * columns, от 11 до 19 
Console.WriteLine("Вторая матрица");
Print22DArray(pasol);
int[,] ressol = Print33DArray(result, pasol);
Console.WriteLine("Третья матрица");
Print2DArray(ressol);
