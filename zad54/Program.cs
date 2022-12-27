//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

/// Комментарий к методу
/// m - кол-во строк, n - столбцов
/// min, max
int[,] Get2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++) // по строчкам m
    {
        for (int j = 0; j < n; j++) // по столбцам n
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;  // заполненый массив случайными числами 
}
/// Печать массива. На вход
/// принимает массив для печати
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам 
        {
            Console.Write(matrix[i, j] + "\t"); // "\t" = Tab   
        }
        Console.WriteLine();
    }
}
/// функция которая находит сумму каждой строки через новый массив 
///и сравнивает суммы между собой в последнем цикле через условие
void New2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j​​++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];// назначили переменную и присвоили 
                    matrix[i, k + 1] = matrix [i, k];
                    matrix[i, k] = temp;//  j вместо i??
                }
            }
        }
    }
}


int[,] result = Get2DArray(rows, columns, 0, 10); // Массив rows * columns, от 0 до 10 зали коридор от 1до 10
Console.WriteLine("Исходный массив");// печать название строки
Print2DArray(result);// печать заполненного массива 
Console.WriteLine("Измененный массив ");// печать название строки
//PrintArray ( таблица );
New2DArray( result);// вызов функции нового массива
Print2DArray(result);// печать измененного массива 