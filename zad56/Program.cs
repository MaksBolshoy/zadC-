//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
    return matrix;
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
void  NumberRowMinSumElements ( int [,] matrix )
{
     int  minRow =  0 ;
     int minSumRow =  0 ;
    int sumRow  = 0 ;  
    for ( int  i  =  0 ; i  <  matrix . GetLength ( 1 ); i ++ )
    {
        minRow  +=  matrix [ 0 , 0];//j или i или 0
    }
    for ( int  i  =  0 ; i  <  matrix  . GetLength ( 0 ); i ++ )
    {
        for ( int  j  =  0 ; j  <  matrix . GetLength ( 1 ); j ++ ) sumRow  +=  matrix [ i , j ];
        if ( sumRow  <  minRow )
        {
             minSumRow =  sumRow ;
            minSumRow  =   0;//
        }
        sumRow  =  0 ;
    }
    Console . WriteLine ( $" { minSumRow  +  1 } строка " );
}

//int [,] таблица  =  новый  int [ 4 , 4 ];
//FillArrayRandom ( таблица );
//PrintArray ( таблица );
//Console.WriteLine("написать строку");
//NumberRowMinSumElements (result );//result



int[,] result = Get2DArray(rows, columns, 0, 10); // Массив rows * columns, от 0 до 10 
Console.WriteLine("Исходный массив");
Print2DArray(result);
Console.WriteLine("написать строку");
NumberRowMinSumElements (result );//result