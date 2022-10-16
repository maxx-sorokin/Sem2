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

int DeleteSecondDigit(int number)
{
    int lastNumber = number % 10;
    number = number / 100;
    
    int newNumber = number * 10 + lastNumber;

    return newNumber;
}

int randomNumber = GetRandomNumber(100, 1000);
Console.WriteLine(randomNumber);

int number2 = DeleteSecondDigit(randomNumber);
Console.WriteLine(number2);


// int array = new int[5];

// for (int i = 0; i < array.Length; i++)
// {
//     int lastValue = number % 10;
//     array[i] = lastValue;
//     number = number / 10;
// }