void FillArray(int[] collection){
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArry(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count){
        Console.Write($"{col[position]}, ");
        position++;
    }
}


int [] arry = new int[10];
FillArray(arry);
PrintArry(arry);
