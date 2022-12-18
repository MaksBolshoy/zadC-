//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
int GetResultDiff(int[] inputArray)
{
    int result = 0;
    int resultMax = 0;
    int resultMin = inputArray[0];
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] > resultMax)
        {
            resultMax = inputArray[i];
        }
        if (inputArray[i] < resultMin)
        {
            resultMin = inputArray[i];
        }
    }
    result = resultMax - resultMin;
    return result;
}
//int resultMax = 0;
//int resultMin = 0;

//int GetResultRazn(int size, int minValue, int maxValue)
//{
//    int result = 0;
//   int[] size = new int[4];


//   for (int i = 0; i < size.Length; i++)
//   {
//       if (size[i] >= resultMax && i < size.Length)
//      {
//          resultMax = size[i];
//      }
//     else if (size[i] <= resultMin && i < size.Length)
//      {
//          resultMin = size[i];
//     }

//  }
//   result = resultMax - resultMin;
//  return result;
//}
int[] resultArray = GetArray(4, 1, 15);
Console.WriteLine($"Array: [{String.Join("; ", resultArray)}]");
int resultDiff = GetResultDiff(resultArray);
Console.WriteLine($"разница: {String.Join("; ", resultDiff)}");
//Console.WriteLine($"Минимальное число : {resultMin}, максимальное число : {resultMax}");
//Console.WriteLine($"разница:{String.Join("; ", GetResultRazn(int size, 1, 15))}");