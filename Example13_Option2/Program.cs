Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
Console.Write("What digit to display? ");
int searchDigit = int.Parse(Console.ReadLine());
int countDigit = 0;
int findDigit = 0;
int num1 = num;
while(num1 != 0)
{
    num1 = num1 / 10;
    countDigit++;
}
if(searchDigit <= countDigit)
{
    Console.Write("Count digit: ");
    Console.WriteLine(countDigit);

    findDigit = countDigit - searchDigit;
    while(findDigit != 0)
    {
        num = num / 10;
        findDigit = findDigit - 1; 
    }

    num = num % 10;
    Console.Write("Your digit: ");
    Console.Write(num);
}
else
{
    Console.WriteLine("Invalid value!");
}