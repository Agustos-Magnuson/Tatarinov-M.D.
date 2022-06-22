Console.Write("Вводите меньшее основание b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Вводите большее основание a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Вводите угол при большем основании x: ");
double x = Convert.ToDouble(Console.ReadLine());
double f = (a - b) / 2;
double h = f * Math.Sin(x * Math.PI / 180) / 
    Math.Sin((90 - x) * Math.PI / 180);
double S = (a + b) * h / 2;
Console.Write("Площадь равнобедренной тропеции: ");
Console.Write(S);