// Дано N гирь с разным весом в случайном порядке. Определть вес самой тяжёлой гири.
int n = 7;
int[] arr = { 5, 7, 1, 78, 34, 2690, 12 };
int i = 1;
int max = arr[0];

while (i < arr.Length)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i++;
}
System.Console.WriteLine(max);

max = arr[0];
for(int j = 0; j < n; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
}
System.Console.WriteLine(max);

max = arr[0];
foreach(int e in arr)
{
    if (e > max)
    {
        max = e;
    }
}
System.Console.WriteLine(max);