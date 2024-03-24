//Создать массив и заполнить его целыми числами от 1 до N  (N - произвольное натуральноне число). Вывести элементы массива на экран.

System.Console.Write("Введи целое натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;
int[] arr42 = new int[n];

while (i < n)
{
    arr42[i] = i + 1;
    System.Console.Write(arr42[i] + " ");
    i++;
}
