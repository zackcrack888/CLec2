﻿// int a1=15, b1=21, c1=39, a2 = 12, b2=23, c2=33, a3=13, b3 =231, c3=333;
int[] array = {11,21,31,41,15,61,17,181,19};
array[0]=12;
Console.WriteLine(array[4]);
//int max=a1;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}

// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);
// int max = Max(max1,max2,max3);

int max = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8]));

// if (b1>max) max=b1;
// if (c1>max) max=c1;
// if (a2>max) max=a2;
// if (b2>max) max=b2;
// if (c2>max) max=c2;
// if (a3>max) max=a3;
// if (b3>max) max=b3;
// if (c3>max) max=c3;

Console.WriteLine(max);