Console.Write("Введите число для размера массива : ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

int check_num = num / 2;
int[] array_new = new int[check_num];

for(int i = 0; i < num; i++)
{
    array[i] = new Random().Next(1, 11);
    Console.Write(array[i]+ " ");
}

Console.WriteLine(" || ");


for(int i = 0; i < num / 2; i++)
{
    array_new[i] = array[i] * array[^(i+1)]; // ^(i+1) - обращаемся к последнему элементу массива
    Console.Write(array_new[i] + " "); 
}

// Console.Write("Введите число для размера массива - ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];

// int check_num = num / 2;
// int[] array_new = new int[check_num];

// for(int i = 0; i < num; i++)
// {
//     array[i] = new Random().Next(1, 11);
//     Console.Write(array[i]+ " ");
// }

// Console.WriteLine(" || ");

// int last_index = num - 1;
// for(int i = 0, j = last_index; i < num / 2; i++, j--)
// {
//     array_new[i] = array[i] * array[j];
//     Console.Write(array_new[i] + " "); 
// }