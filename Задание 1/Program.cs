int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int[] mn = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
bool f = false;
if (c % 400 == 0 || c % 100 != 0 && c % 4 == 0) mn[2] += 1;
if (b > 0 && b < 13 && a > 0 && a <= mn[b])
{
    Console.WriteLine("Дата введена корректно");
    int pr = a, ost = mn[b] - a;
    for (int i = 1; i < b; i++)
        pr += mn[i];
    for (int i = b + 1; i < 13; i++)
        ost += mn[i];
    Console.Write("С начала года прошло ");
    Console.Write(pr);
    Console.WriteLine(" дней");
    Console.Write("До конца года осталось: ");
    Console.Write(ost);
    Console.WriteLine(" дней");
}
else Console.WriteLine("Дата введена некорректно");