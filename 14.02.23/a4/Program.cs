
int num1 = new Random().Next(0, 101);
int num2 = new Random().Next(0, 101);
Console.WriteLine($"{num1} {num2}");
if(num1 == num2*num2){
    Console.WriteLine($"{num2}Квадрат числа{num1}");
}
if(num2 == num1*num1){
    Console.WriteLine($"{num2}Квадрат числа{num1}");

}

else
{Console.WriteLine("Не одно число не является квадратом другого");}