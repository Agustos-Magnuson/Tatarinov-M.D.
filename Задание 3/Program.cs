﻿int Square = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < 1000; i++)
    for (int j = 1; j < 1000; j++)
        for (int d = 1; d < 1000; d++)
        {
            if (i * i + j * j == d * d)
            {
                double S = (i * j) / 2;
                if (Square > S)
                {
                    Console.WriteLine($"Треугольник со сторонами a={i} b={j} c={d}");
                    Console.WriteLine($"Площадь треугольника S={S} ");
                }
                if (Square < S) goto end;
            }
        }
    end:
Console.WriteLine();
