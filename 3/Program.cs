﻿Console.Write("Введите колличество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
    a[i] = Convert.ToInt32(Console.ReadLine());
long S = 0, P = 1;
for (int i = 0;i < n; i++)
{
    S += a[i];
    P *= a[i];
}
Console.Write("Сумма элементов массива: ");
Console.WriteLine(S);
Console.Write("Произведение элементов массива: ");
Console.WriteLine(P);
