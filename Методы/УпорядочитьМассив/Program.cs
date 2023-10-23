// Было: 1 8 3 2 6 4 5 7
// Стало: 1 2 3 8 6 4 5 7
// Результат: 1 2 3 4 5 6 7 8

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array) //метод Выводит элементы массива 
{
    int count = array.Length;

    for(int i = 0; i < count;i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)//метод который упорядочит массив
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i; //минимальная позиция
        
        for(int j = i + 1 ; j < array.Length;j++)
        {
            if(array[j] < array[minPosition] ) minPosition = j;
        }

        int temporary = array[i]; //рабочая позиция 
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    
}
PrintArray(arr); //выводим массив 
SelectionSort(arr); //сортируем по возрастанию
PrintArray(arr); // выводим результат сортировки