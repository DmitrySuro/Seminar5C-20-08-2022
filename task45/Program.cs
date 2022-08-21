// Задача 45: Напишите программу, которая будет создавать 
//копию заданного массива с помощью поэлементного копирования.

void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}

int[] CreateArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];
    
    return copyArray;
}

Console.Write("Укажите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] copyArray = new int[n];
NewArray(array);
Console.WriteLine("Исходный массива [" + string.Join(", ", array) + "]");
copyArray = CreateArray(array);
copyArray[0] = 20;
Console.WriteLine("Исходный массива [" + string.Join(", ", copyArray) + "]");
