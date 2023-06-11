// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM <= 0 || numberN <= 0) Console.WriteLine("Числa не являются натуральными.");
else if (numberM < numberN)
{
    int sumNumbers = SumNaturalNumbers(numberM, numberN);
    Console.Write($"M = {numberM} ; N = {numberN}. -> {sumNumbers}");
}
else
{
    int sumNumbers = SumNaturalNumbers(numberN, numberM);
    Console.Write($"M = {numberM} ; N = {numberN}. -> {sumNumbers}");
}

int SumNaturalNumbers(int numM, int numN)
{
    if (numM == numN) return numM;
    return numM + SumNaturalNumbers(numM + 1, numN);
}
