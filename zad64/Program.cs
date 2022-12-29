//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
Console.Write("Введите число  ");
int N = Convert.ToInt32(Console.ReadLine());
int i =1;
RevArray(N,i);
void RevArray(int N, int i)
{
    if(N>i)
    {
        return;
    }

    else
    {
        RevArray (N, i  +  1 );
        Console. WriteLine ( i +  "  " );
    }
}
*/

Console. WriteLine ( " Введите натуральное число больше 1: " );
int n =  Convert.ToInt32( Console.ReadLine ( )) ;


void  NumberCounter ( int n )
{
    if ( n <  0 ) Console. WriteLine( $" { n } не натуральное число " );
    if ( n  ==  0 ) return;// вернуть ;
    Console . Write ( " {0,1} " , n );
     NumberCounter ( n  -  1 );
}

 NumberCounter ( n );



//int PrintRevArray( int N)
//{
 //for(int i = N; i > 0; i--)
     //  Console.Write(i + " ");
///}
//Console.WriteLine( PrintRevArray(int N));
//PrintRevArray( int N);
//public static void Main(String[] args)
//{
    //int N = 5;
 
  //  PrintRevArray(N);
//}
