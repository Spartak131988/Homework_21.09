int count = 7;
int[] array = new int[count];
int i = 0;
double sum = 0;
Console.WriteLine("Числа: ");

while (i < count)
{
    array[i] = new Random().Next(1, 100);
    Console.WriteLine(array[i]);
    sum = sum + array[i];
    i++;
}

double m = sum / count;
Console.WriteLine("Среднее арифметическое " + m);