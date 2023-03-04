// **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine()!);
int a = 0;
string r = "";
for(int i = 0;num > 0;i++){
    a = num %2;
    num = num /2;
    r = a +r;
    
    
}
Console.Write(r);
