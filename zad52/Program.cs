//Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.//

//Console.WriteLine("Введите количество строк");
int m = 3;// Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов");
int n = 4;//Convert.ToInt32(Console.ReadLine());


// iiiiii
// j12345
// j101234,3,5,7,9
// это метод созданию массива с нулями  на печать его не выводим
int[,] FillArray()
{
  int[,] matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
  
  return matr;
}

void GetAbsColumn(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(1); i++) { // обходим столбцы
    int abs = 0;
    int sum = 0;
    for (int j = 0; j < matr.GetLength(0); j++) { // обходим строки
      abs += matr[j,i] / matr.GetLength(0);
      sum += matr[j,i];
    }
    Console.Write($"{(abs)} ");//Line (abs);
    //Console.WriteLine();
    //Console.WriteLine(sum);
  }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = FillArray(); // вывод заполненного массива 
PrintArray(matrix);
Console.WriteLine();
GetAbsColumn(matrix);



/*
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

// присваиваем значение переменным и обьявляем их

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
// создаем массив с нулевыми значениями 
//void FillArray(int[,] matr)
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
// заполняем массив значениями и выводим на печать
//int []sum=new int [m];
void GetValue(int[,] matr)
{
    int sum = 0;
    //int[] sum=new int [m];
    float arf = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            //int sum = 0;
            //float arf = 0;
            //sum= matrix[i,j];
            //matrix[i, j] = Next(0, 100);
            //matrix[i, j]= new int [m];
            //int []sum=new int [m];
            sum += matrix[i, j];
            arf = sum / (m);
            Console.Write(matrix[i, j] + "\t");

        }
        Console.WriteLine();

    }
    Console.WriteLine("arf=" + arf);

    Console.ReadLine();

}
FillArray(matrix);// массив
Console.WriteLine();// пустая 
PrintArray(matrix);// печатаем массив 
GetValue(matrix);// среднеарифметическое значение
*/
/*
Console.WriteLine("введите колличество строк n :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите колличество столбцов m:");
int m = Convert.ToInt32(Console.ReadLine());
int [,]matrix=new int [n, m];
int []sum=new int [m];
Random ran = new Random();

for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        matrix[i, j] = ran.Next(0, 100);

        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
        sum[i] += matrix[j, i];
    }
}

for (int i=0; i<m; i++)
{
    Console.Write((sum[i] / n)  + " ");
}
Console.ReadLine();
*/