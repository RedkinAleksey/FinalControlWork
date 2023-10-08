//  Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System.Globalization;

Console.Clear();
int numberRows = 0;
while (numberRows <= 0)
{
    
    Console.WriteLine("Введите количество строк: ");
    numberRows = Convert.ToInt32(Console.ReadLine());

    if (numberRows <= 0) Console.WriteLine("Данные введены некорректно.");  
}


int size = 0;
string[] array = new string[numberRows];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите строку массива: ");
    array[i] = Console.ReadLine();
    if (array[i].Length < 4) size++; 
}


string[] arrayNew = ArrayElementsLessThanFourt(array, size);  


Console.Write("[" + string.Join(", ", array) + "]" + " => ");
Console.Write("[" + string.Join(", ", arrayNew) + "]");

string[] ArrayElementsLessThanFourt(string[] arr, int lengthArr)
{
    string[] arrNew = new string[lengthArr];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            arrNew[j] = arr[i];
            j++; 
        }
    } 
    return arrNew;
}


