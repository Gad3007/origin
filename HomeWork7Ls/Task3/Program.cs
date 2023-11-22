// Задача 3 : Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы
// [1,2,5,0,10,34] => 34 10 0 5 2 1 



//              0 1 2 3  4  5
int[] array = { 1,2,5,0,10,34 };
//               6      - 1 = 5 иначе выйдем за массив
int num = array.Length - 1;

  
//  Метод задания элементов массива с конца 

int ArrayNumsRevers(int num,int[] array)
{
    if (num < 0)
    {
        
        return 0;
    }
    Console.Write($"{array[num]},");
    return  ArrayNumsRevers(num - 1 , array);
}
Console.WriteLine($"Исходный массив: [{array[0]},{array[1]},{array[2]},{array[3]},{array[4]},{array[5]}]");
Console.Write("Массив наоборот: [");
ArrayNumsRevers(num, array);
Console.Write("]");





