//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//4 3 1 (1,2) => 9
//2 6 9 

// 1.Создать двумерный массив 
// 2.Заполнить его случайными числами 
// 3.Написать метод который принимает позиции элемента (0,0) (0,1) (0,2) и возвращает значение элемента из позиции или выдаёт ошибку при отстутствии позиции
                                                    // (1,0) (1,1) (1,2)

int [,] GenerateArray()
{

    int[,] array = new int[2,3];
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

void ElementPosition(int [,] array, int [] array2) //метод проверки существует ли позиция в нашем массиве который принимает двумерный и одномерный массивы
{
    if ( array2[0] < array.GetLength(0) && array2[1] < array.GetLength(1))  
    {
        Console.Write($"ЭЛЕМЕНТ МАССИВА {array[array2[0],array2[1]]}");    
    }
        else 
        {
                Console.Write("Такого элемента не сущестует");
        }   
}

int[] EnterNumbers() //метод ввода чисел через , позиции элемента массива
{
    Console.Write("Введите номер позиции массива через , ");
    string input = Console.ReadLine();
    string[] arrayNumbers = input.Split(","); // .Split метод разделения текста (символ которым разделяют | , # и тд .)
    int[] numbers = new int[arrayNumbers.Length];
    for(int i  = 0; i < arrayNumbers.Length; i++)
    {
        numbers[i] = Convert.ToInt32(arrayNumbers[i]);
    }
    return numbers;
}

int[,] mass = GenerateArray(); //инициализируем двумерный массив
PrintArray(mass); //выводим массив на экран 
int [] mass1 = EnterNumbers(); //чтобы прочитать два числа введенных через , создадим одномерный массив 
ElementPosition(mass,mass1); //выдаём в терминал число которое хранится в данном элементе или получаем ошибку если позиция введена не правильно
