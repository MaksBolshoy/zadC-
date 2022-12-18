//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
            
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int GetArraySum(int[] size, int minValue, int maxValue)
{
    int sum = 0;
    for (int i = 0; i < size.Length; i++)
    {
        if (i % 2 != 0) ///подумать над условием  1/2 целочисленное и 0/2
        {
            sum+= size[i];
            //sum++;
        }
    }
    return sum;

}
int[] resultArray = GetArray(4, 1, 15);
Console.WriteLine($"Array: [{String.Join("; ", resultArray)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве [array]: {GetArraySum(resultArray, 1, 15)}");









