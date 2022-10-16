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

int CheckMultiplicity(int firstNumber, int secondNumber)
{
    int remains = firstNumber % secondNumber;

    return remains;
}

bool CheckMultiplicity723(int firstNumber)
{
    int remains1 = firstNumber % 7;
    int remains2 = firstNumber % 23;

    return remains1 == 0 & remains2 == 0;
}

bool CheckSquare(int firstNumber, int secondNumber)
{
    int square1 = firstNumber * firstNumber;
    int square2 = secondNumber * secondNumber;

    return square1 == secondNumber | square2 == firstNumber;
}

Console.Clear();
Console.WriteLine("Введите номер задачи: 11, 12, 14 или 16");
int z = Convert.ToInt32(Console.ReadLine());

// Задача 11
if (z == 11)
{
    int randomNumber = GetRandomNumber(100, 1000);
    Console.WriteLine(randomNumber);

    int number2 = DeleteSecondDigit(randomNumber);
    Console.WriteLine(number2);
}

// Задача 12
if (z == 12)
{
    Console.WriteLine("Введите два числа");
    int A12 = Convert.ToInt32(Console.ReadLine());
    int B12 = Convert.ToInt32(Console.ReadLine());

    int remainsNumber12 = CheckMultiplicity(A12, B12);

    if (remainsNumber12 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine($"Не кратно, остаток {remainsNumber12}");
    }
}

// Задача 14
if (z == 14)
{
    Console.WriteLine("Введите число");
    int A14 = Convert.ToInt32(Console.ReadLine());

    bool result14 = CheckMultiplicity723(A14);

    if (result14)
    {
        Console.WriteLine("Число кратно одновременно 7 и 23");
    }
    else
    {
        Console.WriteLine($"Число НЕ кратно одновременно 7 и 23");
    }
}

// Задача 16
if (z == 16)
{
    Console.WriteLine("Введите два числа");
    int A = Convert.ToInt32(Console.ReadLine());
    int B = Convert.ToInt32(Console.ReadLine());

    bool result = CheckSquare(A, B);

    if (result)
    {
        Console.WriteLine("Одно число является квадратом другого числа");
    }
    else
    {
        Console.WriteLine($"Одно число НЕ является квадратом другого числа");
    }
}

// int array = new int[5];

// for (int i = 0; i < array.Length; i++)
// {
//     int lastValue = number % 10;
//     array[i] = lastValue;
//     number = number / 10;
// }