// int number = 0;

// int FuncExample (string text) 
// {
//     int inside = 0;
//     Console.WriteLine(number)
//     Console.WriteLine(text);
//     return 5;
// }

// // string exm = "message 1-2-3";
// // string text = "another text";
// Console
// FuncExample(text);




// Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.

// Примеры

// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13]  => 3

// 1.Задать одномерный массив 
// 2.Определяем количество простых чисел
// 3.Вывод

// 1. Определить тип функции

int[] GenerateArray () {
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,11);
    }

    return array;
}

void PrintArray (int[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

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



int[] newArray = GenerateArray();
PrintArray(newArray);
int count = CountSimpleNumbers(newArray);
Console.Write("Количество простых чисел:" + count);