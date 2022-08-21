//адача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

System.Console.Clear();


string SumSidesTriangle (int sidesA, int sidesB, int sidesC)
{
 if (sidesA + sidesB > sidesC && sidesB + sidesC > sidesA && sidesA + sidesC > sidesB)
 {
    return ("Можно нарисовать треугольник");
 }
return ("Нельзя нарисовать треугольник");
}

System.Console.WriteLine("Введите сторону А");
int sidesA = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите сторону B");
int sidesB = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите сторону C");
int sidesC = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine(SumSidesTriangle(sidesA,sidesB,sidesC));