// Заполните массив на  N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 

// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший – на последнем. 

// Пример
// [1 3 2 4 2 3] => 132423 100000 + 30000 + 2000 + 400 + 20 + 3 = 132423
// [2 3 1] => 231
Console.WriteLine("Введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = GenerateArray(n);
PrintArray(array);
SumNumbersRanks(array);



int[] GenerateArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//     array[i] = new Random().Next(1, 10);
// }


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
// for (int i = 0; i < n; i++)
// {
//     Console.Write(array[i] + " ");
// }

void SumNumbersRanks(int[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i] * Math.Pow(10, array.Length - i - 1);
    }
    Console.WriteLine(sum);
}

// double sum = 0;
// for (int i = 0; i < n; i++)
// {
//     sum += array[i] * Math.Pow(10, n - i - 1);
// }
// Console.WriteLine(sum);