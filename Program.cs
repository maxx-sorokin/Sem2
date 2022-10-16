int GetRandomNumber(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}

int FindMaxValue(int number)
{
    int max = number % 10;
    number = number / 10;

    while (number > 0)
    {
        int lastNumber = number % 10;
        if (lastNumber > max)
        {
            max = lastNumber;
        }
        number = number / 10;
    }
    return max;
}

int randomNumber = GetRandomNumber(10, 100);
Console.WriteLine(randomNumber);

int maxValue = FindMaxValue(randomNumber);
Console.WriteLine(maxValue);