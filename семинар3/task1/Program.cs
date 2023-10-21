// {1 3 4 19 3}, 8 => Нет
// {-4 3 4 1 }, 3 => Да

// 1.Задать массив 
// 2.Присутствие числа в массиве
// 3.Выдавать ответ в зависимости от результата 

// int number = 5;

// int[] array = {4,5,6,7,3};

int[] array = new int[5];

int checknumber = 5;
bool isEqual = false;

for (int i = 0;i < array.Length; i++)
{
    Console.Write(i);
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
    if(array[i] == checknumber)             //isEqual = true/false
                                            // if (condition = true/false)            
    {
        isEqual = true;
    }
}

if(isEqual)
{
    Console.WriteLine("Da");
}
else
{
    Console.WriteLine("Net");
}