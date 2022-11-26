Console.Write("Enter a three-digit number: ");
int num = int.Parse(Console.ReadLine());

if (num > 99 & num <= 999)
{
    Console.WriteLine(num / 10 % 10);
}
else
{
    Console.WriteLine("invalid value");
}