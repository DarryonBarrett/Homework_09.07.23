// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int PrintNumber (int start, int end)
{
    if (start == end) return start;
    return start + PrintNumber(start + 1, end);
}

int m = InputNum("Введите число M: ");
int n = InputNum("Введите число N: ");
Console.WriteLine(PrintNumber(m, n));