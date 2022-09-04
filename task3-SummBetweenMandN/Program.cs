/* 
Задача 66: Задайте значения M и N. Напишите программу, которая найдет сумму натуральных 
элементов в промежутке от M до N.

M = 2; N = 15 -> 120
M = 4; N = 8 -> 30 
*/

 int SummBetweenMandN (int n, int m)
{
    
    if (m > n)
    {
        return 0;
    }
    return m + SummBetweenMandN(n, m + 1);
}

int result = SummBetweenMandN (15, 2);
System.Console.WriteLine(result);
