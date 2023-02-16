int a1 = 13;
int b1 = 15;
int c1 = 11;
int a2 = 2;
int b2 = 9;
int c2 = 19;
int a3 = 33;
int b3 = 14;
int c3 = 72;
int Max(int arg1, int arg2, int arg3)
{
    int resalt = arg1;
    if (arg2 > resalt) resalt = arg2;
    if (arg3 > resalt) resalt = arg3;
    return resalt;
}

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

//int max = Max(Max(a3, b3, c3), Max(a2, b2, c2), Max(a1, b1, c1));


Console.WriteLine(max);