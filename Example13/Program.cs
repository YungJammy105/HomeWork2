Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

if (num < 99)
{
    Console.WriteLine("No third digit. Enter another number");
}
else
{
    while(num > 1000)
    {
       num = num / 10;
    }
    num = num % 10;
    Console.WriteLine(num);
}