// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// 1. Создадим случайное число
// 2. Разложим наше число на десятки сотни тысячи .... 
// 3. Сложим все элементы 
// 4. Выводим результат в терминал

int Promt(string message)            // плохо понятный мне кусок кода взял из примера решения
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int SumAllNumbers(int number)
{
    int result = 0;
    while (number > 0)
    {                                                                                                                                           // 3
        result+= number % 10; //result = result + number % 10  складываем с пустой переменной остаток от деления введенного числа например 0 + 123 % 10 
        number = number / 10; // уменьшаем разряд числа 123 / 10 = 12; далее цикл повторяется до тех пор пока число не станет = 0; 12 % 10 = 2 + 3 = 5 ; 1 % 10 = 1 + 5 = 6   
    }
    return result; //возвращаем результат сложения чисел
}
int number = Promt("Введи число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllNumbers(number)}"); 

//---------------------------------------------------------------------------------------------------
// int GenNum(int num)

// {
//     int num = new random.Next(10,1000);
//     Console.Write($"Cгенерированное число: {num} ");
//     return num;
// }



//     int num = new Random().Next(10,1000);
//     Console.Write($"Cгенерированное число: {num} ");
//     int numX = num;
//     int Length = 0;

//     while (numX != 0)
//     {
//         // for(int i = 0 ; i < Length;i++)
//         // {
//         //     num = num % 10;
//         //     Console.Write($" число {num} ");
//         // }
//         numX = numX / 10; 
//         Length++;

//     }
//     Console.Write($"Длинна числа {Length}");

//     for(int i = 0 ; i < Length;i++)
//         {
//             num = num % 10;
//             Console.Write($" число {num} ");
           
//         }

// void numLength(int num)
// {
//     int Length = 0;
//     while (num != 0)
//     {
//         // for(int i = 0 ; i < Length;i++)
//         // {
//         //     num = num % 10;
//         //     Console.Write($" число {num} ");
//         // }
//         num /= 10; 
//         Length++;

//     }
//     for(int i = 0 ; i < Length;i++)
//     {
//        num = num % 10;
//        Console.Write($" число {num} ");
//     }
//     Console.Write($"Длинна числа {Length}");
    
// }

// // numLength(num);

// // void SumNumbersOfNumber(int Length)
// // {
// //     for (int i = 0 ; i > Length;i++)
// //     {

// //     }
// // }