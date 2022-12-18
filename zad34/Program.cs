//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
int GetCountElements(int[] size, int minValue, int maxValue)
{
    int count = 0;
    for (int i = 0; i < size.Length; i++)
    {
        if (size[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] resultArray = GetArray(4, 100, 1000);
Console.WriteLine($"Array: [{String.Join("; ", resultArray)}]");
Console.WriteLine($"Количество четных  элементов в массиве [100;1000]: {GetCountElements(resultArray, 100, 1000)}");

/* дубликат исправленный 
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
int GetCountElements(int[] size, int minValue, int maxValue)
{
    int count = 0;
    for (int i = 0; i < size.Length; i++)
    {
        if (size[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}
int[] resultArray = GetArray(4, 100, 1000);
Console.WriteLine($"Array: [{String.Join("; ", resultArray)}]");
Console.WriteLine($"Количество четных  элементов в массиве [100;1000]: {GetCountElements(resultArray, 100, 1000)}");
*/















//int resultPositive = 0;
//int resultNegative = 0;
//for (int i = 0; i < resultArray.Length; i++)
//{
//   if (resultArray[i]/2 = 0) // четное  число
// {
//     resultPositive = resultArray[i]; // resultPositive = resultPositive + resultArray[i]
//  }

//  else resultNegative = resultArray[i];
//}

//Console.WriteLine($"Сумма отр.чисел: {resultNegative}, сумма пол.чисел: {resultPositive}");


