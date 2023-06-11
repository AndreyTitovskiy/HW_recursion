// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите неотрицательное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = Ackermann(numberM, numberN);
Console.WriteLine($"Результат функции Аккермана для m = {numberM} и n = {numberN} равен {result}");

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}
