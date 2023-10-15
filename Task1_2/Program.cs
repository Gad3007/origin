Console.Write("Number - ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 7 == 0 && number % 23 == 0 )
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}