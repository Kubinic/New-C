//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5
Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine()!);


int Faktorial_num(int num){
    int Faktorial = 1;
for(int i = 1; i <= num; i++){
    Faktorial = Faktorial * i;
    
}
return Faktorial;
}
int f = Faktorial_num(num);
Console.Write(f);