Console.Write("Введите последовательность " +
    "n вещественных чисел, начинающиеся " +
    "с отрицательного числа: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] N = new double[n];
for(int i = 0; i < n; i++)
    N[i] = Convert.ToDouble(Console.ReadLine());
int j = 0, count = 1;
while(j < n)
{
    if (N[j] < 0)
    {
        count++;
    }
    j++;
}
Console.WriteLine(count);
