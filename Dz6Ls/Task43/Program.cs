// Задача 43. Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1,k1,b2 и k2
// задаются пользователем. 

// Пример 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 (-0,5;-0,5) 


//в общем, приравниваем правые части данных равенств: 
// k1*x+b1=k2*x+b2 
// выразим отсюда x: 
// x=(b2-b1)/(k1-k2) 
// затем подставим полученное значение х в выражение для у (для любого, например первого) : 
// y=k1(b2-b1)/(k1-k2)+b1 
// ответ: x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1


double[] EnterNumbers() //метод ввода чисел через , 
{
    Console.Write("Введите через , b1,k1,b2,k2 ");
    string input = Console.ReadLine();
    string[] arrayNumbers = input.Split(","); // .Split метод разделения текста (символ которым разделяют | , # и тд .)
    double[] numbers = new double[arrayNumbers.Length];
    for(int i  = 0; i < arrayNumbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(arrayNumbers[i]);
    }
    return numbers;
}

void LinearEquation(double [] array)
{
//x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1 
double b1 = array[0]; // 0
double k1 = array[1]; // 1 
double b2 = array[2]; // 2
double k2 = array[3]; // 3 
double x = (b2-b1)/(k1-k2);
double y = k1*(b2-b1)/(k1-k2)+b1;
Console.WriteLine($"Прямые пересекаются в точке x = {x} y = {y}");
}
double[] num = EnterNumbers();
LinearEquation(num);