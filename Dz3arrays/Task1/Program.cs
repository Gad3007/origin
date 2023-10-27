// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
// массив [10 21 14 93 23] => 2

// 1.Задать одномерный массив из 10 целых чисел от 1 до 100 
// 2.Задать диапозон поиска элементов
// 3.Выдать кол-во найденных элементов


int[] GenerateArray()
{
    int[] array = new int[10];
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

int KolvoElem(int[] array)
{
    int Kolvo = 0;
    int index = 0;
    while(index < array.Length)
    {
        if(array[index] >= 20 && array[index] <= 90)
        {
            Kolvo++;
        }
        index++;
    }
    return Kolvo;
}
int[] mass = GenerateArray();
PrintArray(mass);
// int N = KolvoElem(mass);
Console.Write($"КОЛИЧЕСТВО ЭЛЕМЕНТОВ = {KolvoElem(mass)}");
