﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//          | n + 1              if m=0;
// A(m, n)  | A(m-1, 1)          if m > 0, n =0;
//          | A(m-1, A(m, n-1))  if m > 0, n > 0; 

int GetNumbers (String msg)
{
    Console.WriteLine (msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int AkkermanFun (int m, int n)
{
     if (m==0) return n+1;
     if (m > 0 && n==0) return AkkermanFun (m-1, 1);
     else
     return AkkermanFun (m-1,AkkermanFun(m, n-1));
}

Console.WriteLine (AkkermanFun
                    (GetNumbers("Input M:"),
                    (GetNumbers("Input N:")
                    )));