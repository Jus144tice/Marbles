string stringVariable = "Hello world";
double doubleVariable = 123.456;
bool boolVariable = true;

int intVariable;


Console.WriteLine("Enter an integer:");
intVariable = int.Parse(Console.ReadLine());

if (intVariable > 0)
{
    Console.WriteLine("It's positive");
}
else if (intVariable < 0)
{
    Console.WriteLine("It's negative");
}
else
{
    Console.WriteLine("It's exactly 0");
}

char charVariable;

Console.WriteLine("Enter a character: ");
charVariable = char.Parse(Console.ReadLine());
Console.WriteLine("You entered: " + charVariable);

int counter = 10;

while (counter > 0)
{
    Console.WriteLine("Counter is now: " + counter);
    --counter;

    if (counter == 5)
    {
        Console.WriteLine("Ending the loop early");
        break;
    }
}

/*
stringVariable = "Goodbye";
intVariable = 5678;


Console.WriteLine(intVariable);
*/