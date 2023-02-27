// Заполнить массив рандомными числами 
//new Random().Next(нач, кон);

Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine()!);
int []arr= GetBinArry(number);

Console.Write($"{String.Join(", ",arr)}");

int[] GetBinArry(int size)
{
    int[]result = new int[size];
    for(int i = 0;i < size;i++){
        result[i] = new Random().Next(2);   
        }
        return result;
}