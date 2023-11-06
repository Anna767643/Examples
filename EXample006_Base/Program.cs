int a = 2;
int b = 6;
int c = 1;
int d = 3;
int e = 5;

int max = a;
if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;

Console.Write("max = ");
Console.WriteLine(max);