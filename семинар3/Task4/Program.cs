Console.Write("Введите трехзначное число - ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];



if (num >= 100 && num < 1000)
{
    for(int i = 0; i < 3; i++)
    {
        array[i] = num % 10;
        num /= 10;

        Console.Write(array[i] + " ");
    }

    
}
else Console.WriteLine("Вы ввели не трехзначное число");