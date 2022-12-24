//Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

//Console.WriteLine("Введите число M: ");
//var m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число N: ");
//var n = Convert.ToInt32(Console.ReadLine());
///double[,] GetArray(int m,int n)
//{

//int m =3;
//int n =4;   

/*
string [,] result = new string [3, 4];
String.Empty;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{result[3,4]} ");
    }
}
Console.WriteLine();
*/
    //return result;
//}
//double [,] result = GetArray( m, n);
//Console.WriteLine((GetArray(m,n)));
//double[,] a = new double[5, 10];
 
//Random random = new Random(); 

int m =3;
int n =4;   
double[,] matrix = new double[m, n];
Random random = new Random();
for( int i=0; i < m ;i++)
{
    for(int j=0; j<n;j++)
    {
        matrix[i, j] = random.Next(100);
        Console.Write($"{matrix[i,j]} ");
    }
Console.WriteLine();    
}

