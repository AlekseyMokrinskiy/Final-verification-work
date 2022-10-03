/*
Задача: Написать программу, которая из имеющегося массива строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. Используем массивы.
Пример

["hello", "2", "world", ";-)"] -> ["2", ";-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Danmark", "Kazan"] -> []
*/

int size = new Random().Next(3,7);
Console.WriteLine($"The size will be consits of {size} elements");

string[] CreateArray()
{
    string[] newArray = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} element: ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void ShowArray(string[] array) 
{   
    for(int i = 0; i < size; i++) Console.Write(array[i] + " ");
}

string[] CheckArray(string[] array)
{
    string[] newArray = new string[array.Length];
    for(int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
    }
    return newArray;
}

string[] MyArray = CreateArray();
ShowArray(MyArray);
Console.Write("->");
ShowArray(CheckArray(MyArray));