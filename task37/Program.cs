
//Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(5);

    return array;
}

void NumbersInArray (int[] array)
{
    int lastIndex = array.Length -1;
    int sqr = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sqr = array[i] * array[lastIndex];
        lastIndex --;
        System.Console.Write(sqr);
    }
    
} 


int[] array = new int[5];
array = NewArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
NumbersInArray(array);