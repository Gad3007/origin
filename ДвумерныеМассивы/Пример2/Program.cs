//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


int [,] array = new int[6,6];

for (int i = 0; i < array.GetLength(0); i++)//8
    {
        for (int j = 0; j < array.GetLength(1); j++)//6
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

for (int i = 0; i < array.GetLength(0); i++)//8
    {
        for (int j = 0; j < array.GetLength(1); j++)//6
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

int result = 0;
// for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if( i == j)
//             {
//                 result = result  + array[i,j];

//             }
             
//         }    
//     }    
for (int i = 0, j = 0; i < array.GetLength(0) && j < array.GetLength(1); j++, i++)
{
    result = result  + array[i,j];
} 

Console.Write($"Cумма элементов: {result}");

