﻿string [] ArrayInput (int resultArrayLength)
{
    string[] resultArray = new string[resultArrayLength];
    for(int index = 0; index < resultArrayLength; index++)
    {
        Console.WriteLine($"Введите {index + 1} эллемент массива");
        resultArray[index] = Console.ReadLine()!;
    }
    return resultArray;
}

void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"< {Array[i]} > ");
    }
}

int CheckInt(string message)
{
    System.Console.Write($"{message} > ");
    string InputStr = Console.ReadLine()!;
    int value;
    if (int.TryParse(InputStr, out value))
    {
        return value;
    }
    Console.WriteLine("Извините, но вы ввели не целое число");
    Environment.Exit(0);
    return 0;
}


int inputArrayLength = CheckInt("Введите число элементов массива");
string [] inputArray = ArrayInput(inputArrayLength);
Console.WriteLine("Все элементы введенного вами массива (< element >): ");
PrintArray(inputArray);
