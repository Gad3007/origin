//Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива.

// 1. Задаем двумерный массив int 
// 2. Cоздать одномерный из сумма средних арифметических строк двумерного массива 
    //j
//i [0.0] [0.1] [0.2][0.3] 
//  [0.0] [0.1] [0.2][0.2]
//  [0.0] [0.1] [0.2][0.2]

int [,] array = new int[3,4];
double [] array2 = new double[array.GetLength(0)];

for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

Console.Write("Новый массив: ");

for (int i = 0; i < array.GetLength(0); i++)
    {
        double result = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i,j]; // result = result + array[i,j] 
        }
        result /= array.GetLength(1);// result = result / array.GetLength(1)
        array2[i] = result; 
        Console.Write(array2[i] + " ");
    
    }    
    
    