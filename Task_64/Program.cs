// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine(ResultNumbers(GetNumber("\n\nInput number to decompose:")));

int GetNumber (String text)
{
    System.Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int ResultNumbers (int n)
{
    if (n == 1) return 1;
    else 
    
    System.Console.Write(n+", ");   
    return ResultNumbers(n-1); 
}
