int number = 645;
Console.WriteLine("Число: " + number);

if (number < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    string str = number.ToString();
    Console.Write("Третья цифра числа: " + str[2]);
}