//Поиск идексе элемента "find"
int[] array = {11, 2, 32, 36, 64, 4, 89, 91, 4};
int n = array.Length;
int index = 0;
int find = 4;
while (index < n){
    if (array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index ++;
}
