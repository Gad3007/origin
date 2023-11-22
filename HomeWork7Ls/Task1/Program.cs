// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// ПРИМЕР 
// M = 1 ; N = 5 > "1,2,3,4,5"
// M = 4 ; N = 8 > "4,5,6,7,8"

Console.Write("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

//----------------------МЕТОД ВЫВОДА НАТУРАЛЬНЫХ ЧИСЕЛ В ЗАДАННОМ С КЛАВИАТУРЫ ИНТЕРВАЛЕ------------------

int NaturalNumbers(int numberM, int numberN)
{
    if(numberM > numberN) // если М окажется больше N то приходится менять их местами
    {
        int numberX = numberM; 
        numberM = numberN; 
        numberN = numberX; 
    }
    if(numberM == numberN ) // Условие остановки вызова метода 
    {
         return numberN;   
        
    }
    Console.Write($"{numberM}, ");
    return NaturalNumbers(numberM += 1 ,numberN); // Возвращаем метод вызывая метод и увеличиваем число М
    
}
Console.Write($"{NaturalNumbers(M ,N)}");


