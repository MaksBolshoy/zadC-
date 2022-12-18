//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


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
        if (size[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int[] resultArray = GetArray(7, -100, 100);
Console.WriteLine($"Array: [{String.Join("; ", resultArray)}]");
Console.WriteLine($"Количество положительных  элементов  : {GetCountElements(resultArray, -100, 100)}");
