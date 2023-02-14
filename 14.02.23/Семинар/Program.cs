//11 Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа
int num = new Random().Next(100, 1000);
int arg1 = num /100;
int arg2 = num /10%10;
int arg3 = num %10;
Console.Write($"было{num} стало{arg1}{arg3}");











