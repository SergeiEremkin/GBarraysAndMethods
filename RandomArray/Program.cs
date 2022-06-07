int[] array = new int[10];

void FillArray(int[] arr)
{
    int lenght = arr.Length;
    int index = 0;

    while (index < lenght)
    {
        arr[index] = new Random().Next(1, 10);

        index++;
    }
}

void PrintArray(int[] array)
{
    int lenght = array.Length;
    int index = 0;
    while (index < lenght)
    {
        Console.WriteLine(array[index]);
        index++;
    }
}
int FindElementByIndex(int[] array, int index)
{
    int lenght = array.Length;
    int element = 0;
    while (element < lenght)
    {
        if (array[element] == index)
        {
            element++;
            break;
        }
    }
    return array[element];
}

FillArray(array);
PrintArray(array);
FindElementByIndex(array, 3);

