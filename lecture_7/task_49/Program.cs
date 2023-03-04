// **Задача 49:** Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса чётные,
//   и замените эти элементы на их квадраты.
using System;
using static System.Console;

Write("Введите количество строк : ");
int m=int.Parse(ReadLine()!);
Write("Введите количество столбиков : ");
int n=int.Parse(ReadLine()!);
int [,] array = GetArray(m, n, 2, 3);
PrintArray(array);
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

WriteLine();

arrayIndexPow(array);
PrintArray(array);
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
int [,] arrayIndexPow(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {if (i % 2 == 1){
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if (j % 2 == 1 ){
            array[j, i] *= array[j, i];
        }
        }
        }
        
    }
    return array;
}
