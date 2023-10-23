//Вид 1 
void Method1() //void (пустой) тип данных который ничего не возвращает
{
    Console.WriteLine("Автор ..."); //Тело метода
}

// Method1(); //вызов метода

//Вид 2 

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения"); // 1 вариант вызова 
// Method2(msg : "Текст сообщения"); // 2 вариант вызова 

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4); // 1 вариант вызова
// Method21(msg: "Another text", count: 4); // 2 вариант явно указываем что вызвать

//Вид 3 

int Method3()
{
    return DateTime.Now.Year; //return (вернуть) отдает выражение записанное справа тому коду который вызвал метод
}                             //DateTime.Now.Year - значение текущего года
// int year = Method3(); //присваиваем целочисленной переменной year(год) вызов метода3
// Console.WriteLine(year); // выводим в консоль год : 2023

//Вид4
string Method4(int count, string text) //string (строка) 
{
    int i = 0;
    string result = String.Empty; // String.Empty (пустая строка)

    while (i < count) //while(пока) пока счётчик меньше количества 
    {
        result = result + text; // переменной результат присваиваем результат + текст
        i++; //увеличиваем счетчик на 1 
    }
    return result; // возвращаем переменную результат
}
// string res = Method4(10, "!"); //строковой переменной res присваиваем вызов метода4(количество раз, текст)
// Console.WriteLine(res); // выводим в консоль результат вызова метода4 :! ! ! ! ! ! ! ! ! ! 

//Вид 4-1
string Method41(int count, string text) 
{
    string result = String.Empty; 
    for (int i = 0; i < count;i++)
    {
        result = result + text; 
    }    
    return result; 
}

// string res = Method41(10, "Z");
// Console.WriteLine(res);

//Пример таблицы умножения при помощи цикла в цикле

// for (int i = 2; i <= 10;i++)
// {
//     for (int j = 2; j <= 10;j++)
//     {            
//         Console.WriteLine($"{i} x {j} = {i*j}"); //выводим результат используя интерполяцию строк
//     }
//     Console.WriteLine();
// }

