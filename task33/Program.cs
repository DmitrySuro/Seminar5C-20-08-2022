//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да


int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);

    return array;
}


string FindNumberInArray(int[] array, int userNumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == userNumber)
            return ("Ваше число есть в массиве");
    
    }
    return ("Вашего числа нет в массиве");
}


System.Console.WriteLine("Введите число которое будем искать");
int userNumber = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите размер массива");
int size = int.Parse(System.Console.ReadLine()!);

int[] array = new int[size];
array = NewArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
System.Console.WriteLine(FindNumberInArray(array,userNumber));