Console.Write("Введите A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());
for (int i = A + 1; i < B; i++) {
    long N = i * i * i;
    Console.WriteLine(N);
}