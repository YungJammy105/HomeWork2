Console.Write("Enter number: ");
int day = int.Parse(Console.ReadLine());

if(day >= 1 && day <= 5)
{
    Console.WriteLine("This is weekday");
}
else if(day == 6 | day == 7)
{
    Console.WriteLine("This is weekend");
}
else
{
    Console.WriteLine("Unvaild value");
}
