int[] mn = { 24, 34, 13, 23, 18, 49, 46, 45, 35, 21, 67, 64 };
int[] mns = mn;
for (int i = 0; i < mn.Length; i++)
{
    Console.Write($" {mn[i]}");
}
Console.WriteLine();
Random rand = new Random();
int k = 0;
for (int i = 0; i < 12; i++)
{
    k = rand.Next(11);
    while (k == i) k = rand.Next(11);
    int m = mn[i]; 
    mn[i] = mn[k];
    mn[k] = m;
}

for (int i = 0; i < 12; i++)
{
    Console.Write($" {mn[i]}");
}
