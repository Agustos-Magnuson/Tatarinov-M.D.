Console.Write("Вводите сторону x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Вводите сторону y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Вводите сторону z: ");
double z = Convert.ToDouble(Console.ReadLine());
if ( x >= y + z)
    Console.WriteLine("Треугольника не существует");
else if (y >= z + x)
        Console.WriteLine("Треугольника не существует");
     else if (z >= x + y)
            Console.WriteLine("Треугольника не существует");
          else Console.WriteLine("Треугольник существует");

