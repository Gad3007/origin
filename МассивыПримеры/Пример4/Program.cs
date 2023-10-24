

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray (int[] arr) 
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{arr[position]} ");
        position++;
    }

}

int IndexOf(int[] collect, int find)
{
    int count = collect.Length;
    int index = 0;
    int pos = -1;

    while (index < count)
    {
        if(collect[index] == find)
        {
            pos = index;
            break;
        }
        index++;
    }
    return pos;
}

int[] mass = new int[10];//new int[10] создай новый массив в котором 10 элементов
FillArray(mass);
PrintArray(mass);
Console.WriteLine();

int pos = IndexOf(mass, 4);
Console.WriteLine(pos);