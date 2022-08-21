//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

System.Console.Clear();

string check(int n)
{
    string? result = "";
    while (n > 0)
    {
        int x = n % 2;
        result = Convert.ToString(x) + result;
        n /= 2;
    }
    return result;

}
Console.Write("Введите число, которое необходимо перевести в 2-ую систему: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(check(n));
