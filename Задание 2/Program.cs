int p = Convert.ToInt32(Console.ReadLine());
int first_day;
int[] mon = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
if (p % 400 == 0 || p % 100 != 0 && p % 4 == 0) mon[1] += 1;
if (p == 0)
{
    first_day = 6;
}
else
{
    first_day = (p + (p - 1) / 4 - (p - 1) / 100 + (p - 1) / 400) % 7;
    if (first_day == 0) first_day = 7;
}
for (int i = 0; i < mon.Length; i++)
{
    first_day = (first_day + mon[i] - 1) % 7;
    if (first_day == 0) first_day = 7;
    if (first_day >= 4) Console.WriteLine(mon[i] + 4 - first_day);
    else Console.WriteLine(mon[i] - first_day - 3);
    first_day++;
}