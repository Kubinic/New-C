//Программа для подсчёта факториала
Console.WriteLine("Введите число : ");
int number = int.Parse(Console.ReadLine()!);
int Factorial(int number){
int answer = 1;
int i = 2;
if(number < 0)
{
    i = number;
    number = -1;
} 
for (; i <= number; i++){
    
    answer*=i;
}
return answer;
}

Console.Write(Factorial(number));


