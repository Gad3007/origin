Console.WriteLine("Введите первое число ");
string? number1_str = Console.ReadLine();
int number1 = Convert.ToInt32(number1_str);
Console.WriteLine("Введите второе число ");
string? number2_str = Console.ReadLine();
int number2 = Convert.ToInt32(number2_str);
int kvadrat2 = number2 * number2;
int kvadrat1 = number1 * number1;
if(kvadrat2 == number1 || kvadrat1 == number2)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}  