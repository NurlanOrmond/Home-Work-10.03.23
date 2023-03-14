// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber (String msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumOfElements (int m, int n)
{
    if (m==n+1) return 0;
    else
    System.Console.WriteLine($"M -> {m}, N -> {n}");
    return m+SumOfElements(m+1, n);
}

System.Console.WriteLine(SumOfElements
                        (GetNumber("Number M:"),
                        (GetNumber("Number N:")
                        )));