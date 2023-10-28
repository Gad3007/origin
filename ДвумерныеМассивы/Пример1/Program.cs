// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] array = GenerateArray2D();
PrintArray(array);
Console.WriteLine("___________");
Square(array);
PrintArray(array);
Console.WriteLine("___________");


int[,] GenerateArray2D()
{
    int[,] array = new int[6, 6];
    for (int i = 0; i < array.GetLength(0); i++)//8
    {
        for (int j = 0; j < array.GetLength(1); j++)//6
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//8
    {
        for (int j = 0; j < array.GetLength(1); j++)//6
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Square(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//8
    {
        for (int j = 0; j < array.GetLength(1); j++)//6
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
}