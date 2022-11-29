/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

// 1 вариант с ручным вводом данных с клавиатуры

using static System.Console;

string ReadString()
{
    WriteLine("Введите буквы, слова, цифры или символы через пробел и нажмите Enter:");
    return ReadLine()!;
}

string[] StringToArray(string s)
{
    string[] stringArray = s.Split(" ");
    return stringArray;
}

string[] CreateMaxThreeDigitsArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] targetArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            targetArray[count] = array[i];
            count++;
        }
    }
    return targetArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string str = ReadString();
string[] array = StringToArray(str);
string[] targetArray = CreateMaxThreeDigitsArray(array);
WriteLine();
PrintArray(targetArray);

// 2 вариант с заданными на старте данными

/*
string[] array = { "Hight", "Hel", "lo", "1234", "1567", "new", "world", "friend", "-52)!", "fri", "Russia", "Denmark", "end", "!" };
string[] FindStringLength(string[] array)
{
    int length = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            count++;
        }
    }

    int index = 0;
    string[] newarray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            newarray[index] = array[i];
            index++;
        }
    }
    return newarray;
}
string[] newarray = FindStringLength(array);
for (int i = 0; i < newarray.Length; i++)
{
    Console.Write($"{newarray[i]} ");
}
*/