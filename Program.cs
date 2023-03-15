// Задача
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] CreateStringArray(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input element {i + 1}: ");
        newArray[i] = (Console.ReadLine())!;
    }
    return newArray;
}

string[] OnlyShortElements(string[] array, int maxLength)
{
    string[] result = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Array is empty!");
    }
    else
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++) Console.Write(array[i] + ", ");
        Console.WriteLine("\b\b]");
    }
}

Console.Write("Input the size of your array: ");
int user_size = Convert.ToInt32(Console.ReadLine());
string[] ourArray = CreateStringArray(user_size);

int maximumLength = 3;
string[] shortArray = OnlyShortElements(ourArray, maximumLength);
Console.WriteLine($"The resulting array (words are less than or equal to {maximumLength} characters):");
PrintArray(shortArray);
