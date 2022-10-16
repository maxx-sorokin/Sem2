// int GetRandomNumber(int minValue, int maxValue)
// {
//     Random random = new Random();
//     int randomNumber = random.Next(minValue, maxValue);
//     return randomNumber;
// }

// int FindMaxValue(int number)
// {
//     int max = number % 10;
//     number = number / 10;

//     while (number > 0)
//     {
//         int lastNumber = number % 10;
//         if (lastNumber > max)
//         {
//             max = lastNumber;
//         }
//         number = number / 10;
//     }
//     return max;
// }

// int DeleteSecondDigit(int number)
// {
//     int lastNumber = number % 10;
//     number = number / 100;

//     int newNumber = number * 10 + lastNumber;

//     return newNumber;
// }

// bool CheckMultiplicity(int firstNumber)
// {
//     int remains1 = firstNumber % 7;
//     int remains2 = firstNumber % 23;

//     return remains1 == 0 & remains2 == 0;
// }

bool CheckSquare(int firstNumber)
{
    int square = firstNumber % 7;
    int remains2 = firstNumber % 23;

    return remains1 == 0 & remains2 == 0;
}


// Console.WriteLine("Введите два числа");
// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());

// int remainsNumber = CheckMultiplicity(A, B);

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());

bool result = CheckMultiplicity(A);

if (result)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно");
}

// int randomNumber = GetRandomNumber(100, 1000);
// Console.WriteLine(randomNumber);

// int number2 = DeleteSecondDigit(randomNumber);
// Console.WriteLine(number2);


// int array = new int[5];

// for (int i = 0; i < array.Length; i++)
// {
//     int lastValue = number % 10;
//     array[i] = lastValue;
//     number = number / 10;
// }