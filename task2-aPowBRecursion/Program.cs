/* 
Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 
*/

int APowerB(int a, int b)
{
    if (b == 1)
        return a;
    if (b < 1)
        return 0;
    return a * APowerB(a, b - 1);
}
Console.Write("Введите число которое нужно возвести в степень: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень в которую нужно возвести число: ");
int b = int.Parse(Console.ReadLine()!);

int result = APowerB(a, b);
Console.WriteLine($"Ответ: {a} в степени {b} = {result}.");


