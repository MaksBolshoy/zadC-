//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

 
Console. Write ( " Введите число M: " );
int  m  =  Convert. ToInt32 ( Console.ReadLine ( ) ) ;

Console . Write ( " Введите число N: " );
int  n  =  Convert . ToInt32 ( Console.ReadLine ( ) ) ;

SumMNRT ( m , n );

// вызов функции "сумма чисел от M до N"
void SumMNRT ( int  m , int  n )
{
    Console . Write ( SumMN ( m  -  1 , n ));
}

// функция колличества чисел от M до N
int  SumMN ( int  m , int  n )
{
   //int  n =1 ;
    if ( m  ==  n )
        return  0 ;
    else
    {
        int res=m;
        m ++ ;
        res  =  m  +  SumMN ( m , n );
        return  res ;
    }
}
//SumMNRT ( int  m , int  n );
//SumMN ( int  m , int  n );
//SumMN ( res);