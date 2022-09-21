int days = new Random().Next(1, 8);
Console.Write("Число обознащающее день недели ");
Console.WriteLine(days);

if (days <= 5)
{
    Console.WriteLine("Рабочий день недели");
}
else
{
    Console.WriteLine("Выходной день недели");
}