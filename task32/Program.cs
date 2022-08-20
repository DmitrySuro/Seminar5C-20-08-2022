//Задача 32: Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);

    return array;
}


int[] TempArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}


int[] array = new int[12];
array = NewArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");