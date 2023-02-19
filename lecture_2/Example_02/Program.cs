int [] arry = {12, 32, 5, 4, 76, 4, 13, 9, 16};
int n = arry.Length;
int index = 0;
int find = 4;
while(index < n){
  if (find == arry[index]){
    Console.WriteLine(index);
    index++;
  }
}
