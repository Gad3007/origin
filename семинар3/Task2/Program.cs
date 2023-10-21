int[] array = new int[10];
int len_arr = array.Length;

for(int i = 0; i < len_arr; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i] + " ");
}


Console.WriteLine("Преобразованный массив:  ");
for(int i = 0; i < len_arr; i++)
{
    array[i] = -array[i];
    Console.Write(array[i] + " ");
}

