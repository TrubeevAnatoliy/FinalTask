// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;
Console.Clear();
int len = new Random().Next(1, 11); // случайная длина массива от 1 до 10
Console.WriteLine("Массив состоит из " + len + " элементов.");
Console.WriteLine("Введи, пожалуйста, все элементы массива.");
string[] firstArray = ReadArray(len);
Console.Clear();
Console.WriteLine("Ваш массив:");
WriteArray(firstArray);
string[] secondArray = NewArrayByElementLengh(firstArray, 3); // задается исходный массив и длина строки не более 3 символов
Console.WriteLine("Полученный массив из строк, длина которых меньше, либо равна 3 символам:");
WriteArray(secondArray);

string[] ReadArray(int arg)
{
    string[] massiv = new string[arg];
    for (int i = 0; i < arg; i++)
    {
        Console.WriteLine((i + 1) + " элемент массива.");
        massiv[i] = Console.ReadLine();
    }
    return massiv;
}

void WriteArray(string[] arg)
{
    Console.Write("{ ");
    for (int i = 0; i < arg.Length; i++)

    {
        if (i < arg.Length - 1)
        {
            Console.Write("\"" + arg[i] + "\"" + ", ");
        }
        else
        {
            Console.Write("\"" + arg[i] + "\"" + " }");
        }
    }
    Console.WriteLine();
}

string[] NewArrayByElementLengh(string[] arr, int lenElement)
{
    int count = 0;
    string[] newArray = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i].Length <= lenElement)
        {
            newArray[count] = arr[i];
            count++;
        }
    }
    Array.Resize(ref newArray, count);
    return newArray;
}