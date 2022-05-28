// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}

int[] CreateArray(int size, int minimum, int maximum)
{
    int[] array = new int[size];
    Random random = new Random();
    for(int i=0;i<size;i++)
        array[i] = random.Next(minimum,maximum);
    return array;
}

bool Contains(int[] array, int value)
{
    foreach(var element in array)
        if(element==value)
            return true;
    return false;
}

int[] firstArray = CreateArray(5,-10, 10);
Console.Write("Your array: ");
PrintArray(firstArray);
Console.Write("Enter value to find in array: ");
int value = int.Parse(Console.ReadLine() ?? "0");
//if(Contains(firstArray,value))
//    Console.WriteLine("Contains");
//else
//    Console.WriteLine("Does not contains");
Console.WriteLine(Contains(firstArray, value) ? "Contains" : "Does not contain");