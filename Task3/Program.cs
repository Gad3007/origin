Console.WriteLine("Введите целое число ");
string number_str = Console.ReadLine();
int number = Convert.ToInt32(number_str);
for(int N = -number; N <= number; N++)
{
    Console.Write(N + " ");
}

// int number = Convert.ToInt32(Console.ReadLine());
// int index = 0;
// if (number > 0)
// {
//     index = -number;
// }
// else 
// {
//     index = number;
//     number = - number;
// }
// while (index < number + 1 )
// {
//     Console.Write(index);
//     Console.Write(" ");
//     index = index + 1;
// }