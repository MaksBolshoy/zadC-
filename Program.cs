//Задача 29: Напишите программу, которая задаёт массив из 8 элементов
	// и выводит их на экран.
	//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
	//6, 1, 33 -> [6, 1, 33]
// array[i] = new Random().Next Double();
	
//Next(0, array.Length)
//new Random().
int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, array.Length);
    }
    return array;
}
var str = string.Join(" ", GetArray());
Console.WriteLine(str);