Console.WriteLine("Введите первое число ");
string number1_str = Console.ReadLine();
int number1 = Convert.ToInt32(number1_str);
Console.WriteLine("Введите второе число ");
string number2_str = Console.ReadLine();
int number2 = Convert.ToInt32(number2_str);
int kvadrat = number2 * number2;
if(kvadrat == number1)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}  