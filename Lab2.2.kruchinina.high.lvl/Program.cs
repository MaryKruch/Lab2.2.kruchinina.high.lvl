Console.Write("Введите x:"); double x = double.Parse(Console.ReadLine());
Console.Write("Введите y:"); double y = double.Parse(Console.ReadLine());
Console.WriteLine((x >= -2 && x <= 2 && y > 0 && y <= 2 && y >= x + 2 && y > -x + 2));