// // 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine()!);

int Count_number(int num){
int count = 0;
while(num != 0){
    num = num / 10;
    count++;
}
return count;
}


int answer = Count_number(num);
Console.Write($"{answer} цифар в числе {num}");

