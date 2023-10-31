//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//4 3 1 => 4 6 2
//2 6 9 => 2 6 9
//4 6 2 => 4 3 1

// 1.Задать двумерный массив 
// 2.Вывести двумерный массив 
// 3.Элементы первой строки записать в новую переменную 
// 4.Элементы последней строки перезаписать в первую строку 
// 5.Элементы записанные в новую переменную записать в последнюю строку
// 6.Вывести получившийся массив 


int [,] GenerateArray()
{

    int[,] array = new int[3,3];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}        

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ReverseFirstAndLaststring(int [,] array)
{
    int number = 0;
    for(int j = 0;j < array.GetLength(1);j++) 
    {
        number = array[0,j]; //переменна для хранения значений чтобы не потерять вовремя замены элементов
        array[0,j] = array[array.GetLength(0) - 1,j]; //элементу первой строки присваиваем значение элемента последней строки 
        array[array.GetLength(0) - 1,j] = number; //элементу последней строки присваиваем значение переменной в которую записывали значения элемента первой строки
    }
    return array;

}

int [,] mass = GenerateArray();
PrintArray(mass);
ReverseFirstAndLaststring(mass);
Console.WriteLine("-----------");
PrintArray(mass);

