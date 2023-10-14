Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 && number < 1000)
{
    int lastnumber = number % 10;
    Console.WriteLine(lastnumber);
}
else
{
    Console.WriteLine("Введите число меньше 1000, но больше 100");
}