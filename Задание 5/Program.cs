Console.Write("Введите верхнею границу: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество попыпок (от 1 до 10): ");
int k = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int b = rand.Next(1, n);
for (int i = 0; i < k; i++)
{
    int c = Convert.ToInt32(Console.ReadLine());
    if (c > b)
    {
        Console.WriteLine("Меньше");
    }
    if (c < b)
    {
        Console.WriteLine("Больше");
    }
    if (c == b)
    {
        Console.WriteLine("Вы угадали");
        goto win;
    }
}
Console.WriteLine("Попытки закончились");
win:
Console.WriteLine("Игра окончена");