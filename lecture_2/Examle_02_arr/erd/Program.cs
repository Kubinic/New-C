//Задача 13: Напишите программу, которая выводит
 //третью цифру заданного числа или сообщает, 
 //что третьей цифры нет
Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine()!);
if (number > 99 ){
    number = number % 10;
    Console.WriteLine(number);
}
else
{Console.WriteLine("Третьей цифры нет");}
