// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// 1. Копирую свои готовые функции для создания массива и вывода в терминал 

int[] GenerateArray()
{
    int[] array = new int[8];     // меняю количество элементов на 8 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"Сгенерированный массив размерностью {array.Length} элементов : ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int [] result = GenerateArray(); // инициализирую переменную для хранения сгенерированного случайно массива из 8 элементов
PrintArray(result); // вызываю метод вывода массива result 