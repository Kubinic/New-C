// на вход получае число и выдаём количество цифр

Console.WriteLine("Введите число : ");
int number = int.Parse(Console.ReadLine()!);
int count = 0;
if (number < 0)
    number *= -1;
while(number > 0){
    number %=10;
    count++;
}
Console.Write(count);


