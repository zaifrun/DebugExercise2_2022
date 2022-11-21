// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool numberNotFound = false;
int number = 2520;

while (numberNotFound)
{
    for (int divider = 0; divider < 20; divider++)
    {
        if (number % divider != 0)
            break;
        else
            numberNotFound = true;
    }
    number += 2;
}

// 232792600 er svaret vi leder efter
Console.WriteLine(number);

Console.ReadLine();
