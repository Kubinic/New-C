Console.Write("Введите число А: ");
double a = double.Parse(Console.ReadLine()!);
double numberA = a;
double b = new Random().Next(1, 11);
Console.WriteLine("Число b " + b);
double numberB = b;
double resalt = numberA / numberB;

Console.WriteLine("Ответ " + resalt);