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
int  IndexOf(int[] collection, int find){
    int count = collection.Length;
    int index = 0;
    int answer = -1;
    while(index < count)
    {
        if(collection[index] == find){
            
            answer = index;
            break;
            
        }
        index++;
    }
    return answer;
}
int ans = IndexOf(arry, 2);
Console.WriteLine();
Console.WriteLine(ans);

