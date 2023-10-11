Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "сергей")
{
    Console.WriteLine("*_*");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}