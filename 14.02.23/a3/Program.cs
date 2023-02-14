// Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.

int num1 = new Random().Next(50, 100);
Console.WriteLine($"{num1}");
if((num1 % 7==0)&&(num1%23==0)){
    Console.WriteLine("Кратное");
}
else
{Console.WriteLine("не Кратное");}