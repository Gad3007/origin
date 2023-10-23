// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).

// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

// Пример

// [1 5 11 21 81 4 0 91 2 3]

// => 2
int[] GenerateArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


int CountNumbers(int[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1 && array[i] % 7 == 0)
            j++;
    }
    return j;
}

Console.Write("Введите длинну массива:  ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = GenerateArray(N);
PrintArray(array);
int j = CountNumbers(array);
Console.WriteLine("Кол-во чисел: " + j);

bool IsSimple (int number) {
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0 || number == 1)
        {
            return false;
        }
    }
    return true;
}

int CountSimpleNumbers (int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsSimple(array[i]))
        {
            count++;
        }
    }
    return count;
}