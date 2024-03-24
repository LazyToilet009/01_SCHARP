// Дано N гирь с разным весом в случайном порядке. Определть вес самой тяжёлой гири.

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
